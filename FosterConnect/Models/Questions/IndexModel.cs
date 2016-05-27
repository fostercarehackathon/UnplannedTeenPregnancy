using FosterConnect.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FosterConnect.Models.Questions
{
    public class IndexModel
    {
        public IReadOnlyCollection<StateData> States { get; set; }
    }
}