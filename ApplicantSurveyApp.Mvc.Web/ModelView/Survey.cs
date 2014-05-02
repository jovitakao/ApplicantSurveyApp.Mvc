using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace ApplicantSurveyApp 
{
    [MetadataType(typeof(SurveyMetaData))]
    public partial class Survey { 
    }

    public class SurveyMetaData
    {
        public int ApplicantID { get; set; }
        public int QuestionID { get; set; }
        public int RateID { get; set; }
		public string Comment { get; set; }
    }
}
