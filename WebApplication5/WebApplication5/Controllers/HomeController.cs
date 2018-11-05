using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using SchoolProjekt.FE.Models;
using System.Net;
using System.Web.Http;
using SchoolProjekt.BE.Services;
using SchoolProjekt.BE;


namespace SchoolProjekt.FE.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Index2()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Index3()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public async Task<ActionResult> Rendel(GoodViewModel model)
        {
            var ezabool = true;

            if (ezabool)
            {
                ezabool = false;
            }

            return RedirectToAction("Index", "Home");
        }
        Product[] products = new Product[]
       {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
       };

        

        public async Task<JsonResult> GetData()
        {
            var service = new HomeService();

            var productList = await service.GetProducts();
            

            var returndata = productList;

            return Json(returndata, JsonRequestBehavior.AllowGet);
        }

        public class Thing
        {
            public int id { get; set; }
            public string color { get; set; }
        }

        public JsonResult AddProductToList(Thing[] things)
        {
            List<Product> productList = new List<Product>();
            var prod = new Product();
            //prod.Name = product[0].Name;
            //prod.Category = product[0].Category;
            //prod.Price = product[0].Price;
            productList.Add(prod);

            var returndata = productList;

            return Json(returndata, JsonRequestBehavior.AllowGet);
        }
        

        
    }
}
