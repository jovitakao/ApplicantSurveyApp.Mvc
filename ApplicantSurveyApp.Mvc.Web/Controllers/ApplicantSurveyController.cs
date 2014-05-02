using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApplicantSurveyApp.Mvc.Web.Controllers
{
    public class ApplicantSurveyController : Controller
    {
        //
        // GET: /ApplicantSurvey/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /ApplicantSurvey/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /ApplicantSurvey/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ApplicantSurvey/Create
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

        //
        // GET: /ApplicantSurvey/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /ApplicantSurvey/Edit/5
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
        // GET: /ApplicantSurvey/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /ApplicantSurvey/Delete/5
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
