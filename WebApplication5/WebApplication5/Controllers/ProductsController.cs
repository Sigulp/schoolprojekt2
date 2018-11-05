using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using SchoolProjekt.FE.Models;
using System.Net;
using System.Web.Http;

namespace SchoolProjekt.FE.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
        };

        //public JsonResult GetData()
        //{
        //    return Json(products, JsonRequestBehavior.AllowGet);
        //}
        
    }
}
