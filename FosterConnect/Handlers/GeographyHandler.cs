using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace FosterConnect.Handlers
{
    public class GeographyHandler
    {
        private static readonly ReadOnlyCollection<StateData> _states = new List<StateData>
        {
            new StateData { Abbreviation = "AL", Name = "Alabama" },
            new StateData { Abbreviation = "AK", Name = "Alaska" },
            new StateData { Abbreviation = "AZ", Name = "Arizona" },
            new StateData { Abbreviation = "AR", Name = "Arkansas" },
            new StateData { Abbreviation = "CA", Name = "California" },
            new StateData { Abbreviation = "CO", Name = "Colorado" },
            new StateData { Abbreviation = "CT", Name = "Connecticut" },
            new StateData { Abbreviation = "DE", Name = "Delaware" },
            new StateData { Abbreviation = "DC", Name = "District Of Columbia" },
            new StateData { Abbreviation = "FL", Name = "Florida" },
            new StateData { Abbreviation = "GA", Name = "Georgia" },
            new StateData { Abbreviation = "HI", Name = "Hawaii" },
            new StateData { Abbreviation = "ID", Name = "Idaho" },
            new StateData { Abbreviation = "IL", Name = "Illinois" },
            new StateData { Abbreviation = "IN", Name = "Indiana" },
            new StateData { Abbreviation = "IA", Name = "Iowa" },
            new StateData { Abbreviation = "KS", Name = "Kansas" },
            new StateData { Abbreviation = "KY", Name = "Kentucky" },
            new StateData { Abbreviation = "LA", Name = "Louisiana" },
            new StateData { Abbreviation = "ME", Name = "Maine" },
            new StateData { Abbreviation = "MD", Name = "Maryland" },
            new StateData { Abbreviation = "MA", Name = "Massachusetts" },
            new StateData { Abbreviation = "MI", Name = "Michigan" },
            new StateData { Abbreviation = "MN", Name = "Minnesota" },
            new StateData { Abbreviation = "MS", Name = "Mississippi" },
            new StateData { Abbreviation = "MO", Name = "Missouri" },
            new StateData { Abbreviation = "MT", Name = "Montana" },
            new StateData { Abbreviation = "NE", Name = "Nebraska" },
            new StateData { Abbreviation = "NV", Name = "Nevada" },
            new StateData { Abbreviation = "NH", Name = "New Hampshire" },
            new StateData { Abbreviation = "NJ", Name = "New Jersey" },
            new StateData { Abbreviation = "NM", Name = "New Mexico" },
            new StateData { Abbreviation = "NY", Name = "New York" },
            new StateData { Abbreviation = "NC", Name = "North Carolina" },
            new StateData { Abbreviation = "ND", Name = "North Dakota" },
            new StateData { Abbreviation = "OH", Name = "Ohio" },
            new StateData { Abbreviation = "OK", Name = "Oklahoma" },
            new StateData { Abbreviation = "OR", Name = "Oregon" },
            new StateData { Abbreviation = "PA", Name = "Pennsylvania" },
            new StateData { Abbreviation = "RI", Name = "Rhode Island" },
            new StateData { Abbreviation = "SC", Name = "South Carolina" },
            new StateData { Abbreviation = "SD", Name = "South Dakota" },
            new StateData { Abbreviation = "TN", Name = "Tennessee" },
            new StateData { Abbreviation = "TX", Name = "Texas" },
            new StateData { Abbreviation = "UT", Name = "Utah" },
            new StateData { Abbreviation = "VT", Name = "Vermont" },
            new StateData { Abbreviation = "VA", Name = "Virginia" },
            new StateData { Abbreviation = "WA", Name = "Washington" },
            new StateData { Abbreviation = "WV", Name = "West Virginia" },
            new StateData { Abbreviation = "WI", Name = "Wisconsin" },
            new StateData { Abbreviation = "WY", Name = "Wyoming" }
        }.OrderBy(i => i.Name).ToList().AsReadOnly();

        public ReadOnlyCollection<StateData> GetStates()
        {
            return _states;
        }
    }

    public class StateData
    {
        public string Abbreviation { get; set; }
        public string Name { get; set; }
    }
}