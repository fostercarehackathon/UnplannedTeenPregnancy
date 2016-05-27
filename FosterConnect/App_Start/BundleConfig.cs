using System.Web;
using System.Web.Optimization;

namespace FosterConnect
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/raleway/royal_preloader.min.js",
                "~/Scripts/raleway/bootstrap.min.js",
                "~/Scripts/raleway/jquery.easing.min.js",
                "~/Scripts/raleway/jquery.mixitup.min.js",
                "~/Scripts/raleway/scrollReveal.js",
                "~/Scripts/raleway/owl.carousel.min.js",
                "~/Scripts/raleway/jquery.magnific-popup.min.js",
                "~/Scripts/raleway/jquery.snippet.min.js",
                "~/Scripts/raleway/jquery.fitvids.js",
                "~/Scripts/raleway/activate-snippet.js",
                "~/Scripts/typeahead.bundle.js",
                "~/Scripts/moment*",
                "~/Scripts/bootstrap-datetimepicker*",
                "~/Scripts/site.js"
            ));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                "~/Content/raleway/royal_preloader.css",
                "~/Content/raleway/bootstrap.min.css",
	            "~/Content/raleway/style.css",
	            "~/Content/raleway/bootstrap-social.css",
	            "~/Content/raleway/animate.min.css",
	            "~/Content/raleway/owl.carousel.css",
	            "~/Content/raleway/jquery.snippet.css",
	            "~/Content/raleway/buttons.css",

                "~/Content/bootstrap-datetimepicker*",
                "~/Content/font-awesome.css",
                "~/Content/site.css",
                
                "~/Content/raleway/colors/pinkish.css"
            ));
        }
    }
}