using FosterConnect.Handlers;
using FosterConnect.Models.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FosterConnect.Controllers
{
    public class QuestionsController : Controller
    {
        private static readonly GeographyHandler _geographyHandler = new GeographyHandler();

        public ActionResult Index()
        {
            var model = new IndexModel
            {
                States = _geographyHandler.GetStates()
            };

            return View(model);
        }
    }
}