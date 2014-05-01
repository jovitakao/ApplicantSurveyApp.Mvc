using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicantSurveyApp;
using ApplicantSurveyApp.Mvc.Dal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ApplicantSurveyApp.Tests
{
    [TestClass()]
    public class ApplicantSurveyAppTests
    {
        ApplicantSurveyApp app;
        [TestMethod()]
        public void SaveSurveysTest()
        { 
            Assert.Fail();
        }

        [TestMethod()]
        public void GetQuestionsTest()
        {
            app = new ApplicantSurveyApp();
            List<Question> question = new List<Question>();
            question = app.GetQuestions();
            Assert.IsTrue(question.Count == 0);
        }

        [TestMethod()]
        public void GetImagesTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetImagesFromDirectoryTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetRatesTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetLocalPathTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ExportReportTest()
        {
            Assert.Fail();
        }
    }
}
