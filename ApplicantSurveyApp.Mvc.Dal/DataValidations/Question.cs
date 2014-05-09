using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace ApplicantSurveyApp.Mvc.Dal {

    [MetadataType(typeof(QuestionMetaData))]
    public partial class Question {
        //public Question(QuestionMetaData question)
        //{
        //    QuestionID = question.QuestionID;
        //    QuestionDescription = question.QuestionDescription;
        //    QuestionTypeID = question.QuestionTypeID;
        //}
        //public Question()
        //{
        //}
    }

	public class QuestionMetaData {
		
		public int QuestionID { get; set; }
		public string QuestionDescription { get; set; }
		public int QuestionTypeID { get; set; }
	}
}
