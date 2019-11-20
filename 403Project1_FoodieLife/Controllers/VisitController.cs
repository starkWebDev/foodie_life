using _403Project1_FoodieLife.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _403Project1_FoodieLife.Controllers
{
    public class VisitController : Controller
    {
        public static List<Visit> lstVisit = new List<Visit>();
        // GET: Visit
        public ActionResult DisplayVisit()
        {
            return View(lstVisit);
        }


        //ADD VISIT
        [HttpGet]
        public ActionResult AddVisit()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult AddVisit(Visit myVisit)
        {
            if (ModelState.IsValid)
            {
                lstVisit.Add(myVisit);
                return RedirectToAction("DisplayVisit", "Visit");
            }
            else
            {
                return View(myVisit);
            }
        }

        //EDIT VISIT
        [HttpGet]
        public ActionResult EditVisit()
        {
            return View();
        }


        [HttpPost]
        public ActionResult EditVisit(Visit myVisit)
        {
            if (ModelState.IsValid)
            {
                lstVisit.Add(myVisit);
                return RedirectToAction("DisplayVisit", "Visit");
            }
            else
            {
                return View(myVisit);
            }
        }

    }
}