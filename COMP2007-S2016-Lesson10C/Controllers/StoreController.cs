using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using COMP2007_S2016_Lesson10C.Models;

namespace COMP2007_S2016_Lesson10C.Controllers
{

    public class StoreController : Controller
    {

        FoodStoreContext foodDB = new FoodStoreContext();

        //
        // GET: /Store/
        public ActionResult Index()
        {
            //List<Food> foods = foodDB.Foods.ToList();
            var foodstuff = foodDB.Foods.Include(Food => Food.Name);
            return View(foodstuff);
        }
    }
}