using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SC.Models;

namespace SC.Controllers
{
    public class StoreManagerController : Controller
    {
        private SCEntities db = new SCEntities();
        // GET: StoreManager
        public ViewResult Index()
        {
            var products = db.Products;
            return View(products.ToList());
        }

        //
        // GET: /StoreManager/Details/5
        public ViewResult Details(int id)
        {
            Product product = db.Products.Find(id);
            return View(product);
        }
    }
}