using _403Project1_FoodieLife.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _403Project1_FoodieLife.Controllers
{
    public class RestaurantController : Controller
    {
        public static List<Restaurant> ListRestaurants = new List<Restaurant>();

        // Show restaurants method

        public ActionResult ShowRestaurants()
        {
            return View(ListRestaurants);
        }

        // Add restaurants methods

        [HttpGet]
        public ActionResult AddRestaurant()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddRestaurant(Restaurant myRestaurant)
        {
            if (ModelState.IsValid)
            {
                myRestaurant.restID = (ListRestaurants.Count() + 1);
                ListRestaurants.Add(myRestaurant);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(myRestaurant);
            }
        }

        // Edit Restaurant methods

        [HttpGet]
        public ActionResult EditRestaurant(int sCode)
        {
            Restaurant oRestaurant = ListRestaurants.Find(x => x.restID == sCode);

            return View(oRestaurant);
        }

        [HttpPost]
        public ActionResult EditRestaurant(Restaurant myModel)
        {
            var obj = ListRestaurants.FirstOrDefault(x =>
            x.restID == myModel.restID);

            if (obj != null)
            {
                obj.restName = myModel.restName;
                obj.restCategory = myModel.restCategory;
            }

            return View("ShowRestaurants", ListRestaurants);
        }


    }
}