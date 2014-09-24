using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCAuthTest.Models;
namespace MVCAuthTest.Controllers
{
    public class DeptController : Controller
    {
        //
        // GET: /Dept/
        List<DeptModel> Depts;
        public DeptController() {
            Depts = new List<DeptModel>();
            Depts.Add(new DeptModel("Management",1));
            Depts.Add(new DeptModel("Enginnering", 2));
            Depts.Add(new DeptModel("Production", 3));
            Depts.Add(new DeptModel("Support", 4));
            Depts.Add(new DeptModel("Sales", 5));
        }
        public ActionResult Index()
        {
            return View(Depts);
        }

        //
        // GET: /Dept/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Dept/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Dept/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Depts.Add(new DeptModel(collection.Get("Name"),Depts.Count+1));
                return RedirectToAction("Index","Home");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Dept/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Dept/Edit/5

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

        //
        // GET: /Dept/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Dept/Delete/5

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
