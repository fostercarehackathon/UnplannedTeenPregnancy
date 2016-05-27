using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FosterConnect.Models.Resources;

namespace FosterConnect.Controllers
{
    public class ResourcesController : Controller
    {
        // GET: Resources
        public ActionResult Index()
        {
            return View(IndexModel.GetLocations());
        }
    }
}