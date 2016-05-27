using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FosterConnect.Models;

namespace FosterConnect.Controllers
{
    public class RemindersController : Controller
    {
        // GET: Reminders
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View(new ReminderViewModel
            {
                AppointmentDateTime = DateTime.Now,
                Amount = 1,
                FrequencyEndsAfter = 5,
                FrequencyEndsOnDateTime = DateTime.Now
            });
        }

        [HttpPost]
        public ActionResult Create(ReminderViewModel rm)
        {
            // create reminder
            TempData["Success"] = "Good job! You set up the reminder succesfully!";
            return RedirectToAction("Index");
        }
    }
}