using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicantSurveyApp;
using ApplicantSurveyApp.Mvc.Dal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ApplicantSurveyApp.Mvc.Dal.Tests
{
    [TestClass()]
    public class ApplicantSurveyAppTests
    {
        [TestMethod()]
        public void EntitiesTest()
        {
        }

        [TestMethod()]
        public void sp_alterdiagramTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void sp_creatediagramTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void sp_dropdiagramTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void sp_helpdiagramdefinitionTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void sp_helpdiagramsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void sp_renamediagramTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void sp_upgraddiagramsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void spGetAllReportsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void spSaveApplicantTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void spSaveSurveyTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void spViewSurveyPercentageTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void spViewSurveyStatisticsTest()
        {
            Assert.Fail();
        }
    }
}

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
            //Assert.IsTrue(question.Count == 0);
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
