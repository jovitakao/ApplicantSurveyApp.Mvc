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

		public ActionResult CreateApplicant() {
			return View();
		}


    }
}
