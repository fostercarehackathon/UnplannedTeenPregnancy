var FosterConnect = {
    geocoder: null,

    initializeMap: function() {
        this.geocoder = new google.maps.Geocoder();

        // Call page specific initMap if it exists
        if (typeof initMap === "function") {
            initMap();
        }
    },

    getCoordsForAddress: function(address, callback) {
        this.geocoder.geocode({ "address": address }, function (results, status) {
            if (status === google.maps.GeocoderStatus.OK) {
                callback(results[0].geometry.location);
            }
            else {
                alert('Geocode was not successful for the following reason: ' + status);
            }
        });
    },

    getCoords: function (callback) {
        var key = "__location";
        var location = this.localGetItem(key);
        if (!location)
        {
            navigator.geolocation.getCurrentPosition(function (position) {
                var result = { lat: position.coords.latitude, lng: position.coords.longitude };
                FosterConnect.localSetItem(key, result);
                callback(result);
            });

            return;
        }

        callback(location);
    },

    getState: function (lat, lng, callback) {
        $.ajax({
            url: "https://maps.googleapis.com/maps/api/geocode/json?latlng=" + lat + "," + lng + "&key=AIzaSyBB4B_T6BQXrhEW06-0GGJSA1pjJI5Sw6g",
            type: "GET",
            cache: true,
            dataType: "json",
            success: function (json) {
                for (var i = 0; i < json.results.length; i++) {
                    var r = json.results[i];
                    for (var i2 = 0; i2 < r.address_components.length; i2++) {
                        var ac = r.address_components[i2];
                        for (var i3 = 0; i3 < ac.types.length; i3++) {
                            var t = ac.types[i3];
                            if (t === "administrative_area_level_1") {
                                callback({ abbreviation: ac.short_name, name: ac.long_name });
                                return;
                            }
                        }
                    }
                }
            }
        });
    },

    localSetItem: function (key, value) {
        var now = new Date().getTime();
        var item = { payload: value, time: now };
        localStorage.setItem(key, JSON.stringify(item));
    },

    localGetItem: function (key) {
        var item = JSON.parse(localStorage.getItem("__location"));
        if (!item) {
            return null;
        }

        var now = new Date().getTime();
        if ((now - item.time) > 24 * 60 * 60 * 1000) {
            localStorage.removeItem(key);
            return null;
        }

        return item.payload;
    }
};