﻿using oct6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace oct6.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        static List<ProductModel> prodList = new List<ProductModel>();
        static ProductController()
        {
            prodList.Add(new ProductModel { Prodid = 1, Prodname = "Board", ManufacturingDate = new DateTime(2002, 01, 2) });

            prodList.Add(new ProductModel { Prodid = 2, Prodname = "Bench", ManufacturingDate = new DateTime(2022, 05, 21) });
            prodList.Add(new ProductModel { Prodid = 3, Prodname = "Chalk", ManufacturingDate = new DateTime(2021, 05, 7) });

        }
        public ActionResult Index()
        {
            return View(prodList);
        }

        public ActionResult AcceptData()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AcceptData(ProductModel model)
        {
            ProductModel p = new ProductModel();
            p.Prodid = model.Prodid;
            p.Prodname = model.Prodname;
            p.ManufacturingDate = model.ManufacturingDate;
            return View();
        }
        public ActionResult ProdData()
        {
            return View();
        }


        [HttpPost]
        public ActionResult ProdData(int id, string name)
        {
            ProductModel c = new ProductModel();
            c.Prodid = id;
            c.Prodname = name;

            //passing the values using the route parameter
            //route parameter is declared in Route.config(App_Start Folder)

            return RedirectToAction("FindProd", new { prodid = c.Prodid, name = c.Prodname });
        }


        public ActionResult FindProd(int prodid, string pname)
        {
            string s = null;
            string gotname = pname;
            if (prodid != 0)
            {
                s = "trying to find customer by its id";
            }
            return Content(s);
        }


        public ActionResult NowEditOrderDetails(int id)
        {
            ProductModel foundData = prodList.Find(Product => Product.Prodid == id);


            return View(foundData);
        }

        [HttpPost]

        public ActionResult NowEditOrderDetails(int id, ProductModel m)
        {
            ProductModel foundData = prodList.Find(Product => Product.Prodid == id);
            prodList.Remove(foundData);
            prodList.Add(m);
            return RedirectToAction("Index");
        }




    }
}
