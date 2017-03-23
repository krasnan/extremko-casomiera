using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using perfectTiming.Controller;
using perfectTiming.Model;
using perfectTiming.Helpers;
using System.Collections.Generic;

namespace PerfectTimingTest.UnitTests
{
    [TestClass]
    public class CompetitorTest
    {
        [TestMethod]
        public void AddCompetitorTest()
        {
            CompetitorController ctrl = new CompetitorController();
            Competitor c = new Competitor { email = "test@test.sk", name = "Tester Novy", phone = "+421944123456", birth_date = DateTime.Now };
            //conflict asdf as fa s
            Assert.AreEqual(Enums.RequestStatus.Success, ctrl.AddCompetitor(c).Status);
        }

        [TestMethod]
        public void UpdateCompetitorTest()
        {
            CompetitorController ctrl = new CompetitorController();
            Competitor c = new Competitor { email = "test@test.sk", name = "Tester", phone = "+421944123456", birth_date = DateTime.Now };
            Assert.AreEqual(Enums.RequestStatus.Success, ctrl.AddCompetitor(c).Status);
            c.name = "Tester Zmeneny";
            Assert.AreEqual(Enums.RequestStatus.Success, ctrl.UpdateCompetitor(c).Status);
        }

        [TestMethod]
        public void RemoveCompetitorTest()
        {
            CompetitorController ctrl = new CompetitorController();
            Competitor c = new Competitor { email = "test@test.sk", name = "Tester Na Vymazanie", phone = "+421944123456", birth_date = DateTime.Now };
            Assert.AreEqual(Enums.RequestStatus.Success, ctrl.AddCompetitor(c).Status);
            Assert.AreEqual(Enums.RequestStatus.Success, ctrl.RemoveCompetitor(c).Status);
        }

        [TestMethod]
        public void RemoveRangeCompetitorTest()
        {
            CompetitorController ctrl = new CompetitorController();
            List<Competitor> range = ctrl.Competitors.FindAll(item => item.email == "test@test.sk");
            Assert.AreEqual(Enums.RequestStatus.Success, ctrl.RemoveRangeCompetitors(range).Status);
        }
    }
}
