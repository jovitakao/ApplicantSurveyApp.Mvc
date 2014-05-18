using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApplicantSurveyApp.Mvc.Dal;

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

		public ActionResult CreateApplicant() {
			return View();
		}

        [HttpPost]
        public ActionResult CreateApplicant(Applicant applicant)
        {
            return RedirectToAction("SurveyQuestion", applicant);
        }


        public ActionResult SurveyQuestion(Applicant applicant)
        {
            return RedirectToAction("CreateApplicant");
        }
    }
}
