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
        public ActionResult ShowVisit()
        {
            return View(lstVisit);
        }


        //ADD VISIT
        [HttpGet]
        public ActionResult AddVisit()
        {
            //Add dropdown list here!
            return View();
        }

        [HttpPost]
        public ActionResult AddVisit(Visit myVisit)
        {
            if (ModelState.IsValid)
            {
                //autoincrement the visitID
                myVisit.visitCode = lstVisit.Count() + 1;
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
        public ActionResult EditVisit(int ivisitCode)
        {
            Visit oVisit = lstVisit.Find(x => x.visitCode == ivisitCode);
            return View(oVisit);
        }


        [HttpPost]
        public ActionResult EditVisit(Visit myModel)
        {
            var obj = lstVisit.FirstOrDefault(x => x.visitCode == myModel.visitCode);

            if (obj != null)
            {
                obj.restName = myModel.restName;
                obj.visitRate = myModel.visitRate;
                obj.restLocation = myModel.restLocation;
                obj.order = myModel.order;
                obj.comments = myModel.comments;

            }

            return View("DisplayVisit", lstVisit);
        }

    }
}