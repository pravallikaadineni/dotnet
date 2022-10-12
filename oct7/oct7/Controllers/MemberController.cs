using HelperLibrary;
using oct7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace oct7.Controllers
{
    public class MemberController : Controller
    {
        helper_class helper = null;
        public MemberController()
        {
            helper = new helper_class();
        }
        // GET: Member
        public ActionResult Index()
        {
            var memlist = helper.ShowMemberList();
            List<MemberModel> modelsList = new List<MemberModel>();
            foreach (var item in memlist)
            {
                modelsList.Add(new MemberModel { Member_Id = item.Member_Id, Member_Name = item.Member_Name, Max_Books_Allowed = item.Max_Books_Allowed, Acc_Open_Date = item.Acc_Open_Date, Penalty_Amount = item.Penalty_Amount });
            }

            return View(modelsList);
        }

        // GET: Member/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Member/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Member/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Member/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Member/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Member/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Member/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
