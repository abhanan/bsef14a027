using DataAccess;
using Foody.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Foody.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/
        private FoodyDBEntities db = new FoodyDBEntities();
        public ActionResult EditFoodItems()
        {
            IEnumerable<Item> fooditems = db.Items.ToList();
            return View(fooditems);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ItemModel fooditem)
        {
            if (ModelState.IsValid)
            {
                var dbItems = new Item
                {
                    itemName = fooditem.itemName,
                    Description = fooditem.Description,
                    Price = fooditem.Price,
                    Category = fooditem.Category

                };
                db.Items.Add(dbItems);
                db.SaveChanges();

                return RedirectToAction("EditFoodItems");
            }
            return View();
        }
        public ActionResult Delete()
        {
            
            return View();
        }
        [HttpGet]
        public ActionResult Delete(int itemId)
        {
            try
            {
                Item fooditem = db.Items.Find(itemId);
                db.Items.Remove(fooditem);
                db.SaveChanges();
            }
            catch (DataException/* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                return RedirectToAction("Delete", new { id = itemId, saveChangesError = true });
            }
            return RedirectToAction("EditFoodItems");
        }

        public ActionResult Edit(int itemId)
        {
            if (itemId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = db.Items.Find(itemId);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        //[HttpPost, ActionName("Edit")]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int itemId)
        //{
        //    if (itemId == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    var itemToUpdate = db.Items.Find(itemId);
        //    if (TryUpdateModel(itemToUpdate, "",
        //       new string[] { "LastName", "FirstMidName", "EnrollmentDate" }))
        //    {
        //        try
        //        {
        //            db.SaveChanges();

        //            return RedirectToAction("Index");
        //        }
        //        catch (DataException /* dex */)
        //        {
        //            //Log the error (uncomment dex variable name and add a line here to write a log.
        //            ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
        //        }
        //    }
        //    return View(itemToUpdate);
        //}
	}
}