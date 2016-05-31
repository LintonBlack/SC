using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SC.Models;

namespace SC.Controllers
{
    public class HomeController : Controller
    {
        SCEntities productDB = new SCEntities();
        // GET: Home
        public ActionResult Index()
        {
            var products = productDB.Products.ToList();
            return View(products);
        }

        public ActionResult Details(int id)
        {
            var url = "/StoreManager/Details/" + id; //this is the url

            return Redirect(url);
        }


    }
}