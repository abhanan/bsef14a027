using DataAccess;
using Foody.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace Foody.Controllers
{
    public class FoodItemsController : ApiController
    {
       
        //{
        //    var fooditemsList = db.FoodItems.ToList();
        //    return fooditemsList;
        //}

        //private ActionResult View(List<FoodItemsModel> resultList)
        //{
        //    throw new NotImplementedException();
        //}
        //public List<FoodItemsModel> GET(int cid)  //Here cid is CategoryId(foreign key in FoodItems table) that product belongs to
        //{
        //    var query = "Select * from FoodItems where categoryId = " + cid;
        //    var fooditems = db.FoodItems.SqlQuery(query).ToList();

        //    List<FoodItemsModel> resultList = new List<FoodItemsModel>();
        //    foreach (var item in fooditems)
        //    {
        //        FoodItemsModel result = new FoodItemsModel();
        //        result.itemName = item.ItemName;
        //        result.itemDescp = item.Description;
        //        result.itemPrice = item.Price;
        //        resultList .Add(result);
        //    }
        //    return resultList;
        //}
        //}
        //public FoodItem Post(FoodItem model)
        //{
        //    db.FoodItems.Add(model);
        //    db.SaveChanges();

        //    return model; 
        //}
    }
}


