using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Foody.Controllers
{
    public class FoodItemController : Controller
    {
        //
        // GET: /FoodItem/
        private FoodyDBEntities db = new FoodyDBEntities();
        public ActionResult ShowFoodItems()
        {
            IEnumerable<Item> fooditems = db.Items.ToList();
            return View(fooditems);
        }
	}
}