using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace oct4mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SearchProduct(int id)
        {
            //content=string
            return Content("Tried to find the product id= " + id);
        }
        public ActionResult AddProduct()
        {
            //Add product logic

            //Same controller -different action
            return RedirectToAction("Index");
        }

        public ActionResult GoToGoogle()
        {

            return Redirect("https://www.google.com");
        }


        public ActionResult DeleteProduct()
        {

            return View();
        }
        public ActionResult GoToIndexPageofHomeController()
        {

            //Different controller and action
            return RedirectToAction("Contact", "Home");
        }

    }
}
    