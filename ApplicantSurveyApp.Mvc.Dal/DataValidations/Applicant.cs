using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
namespace ApplicantSurveyApp.Mvc.Dal {

    [MetadataType(typeof(ApplicantMetaData))]
    public partial class Applicant {
    }

	public class ApplicantMetaData { 
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}


}
