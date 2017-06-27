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

       private perfecttimingEntities _context;
       private CompetitorController ctrl;

        public CompetitorTest()
        {
            this._context = new perfecttimingEntities();
            this.ctrl = new CompetitorController(ref _context);
        }


        [TestCategory("Add")]
        [TestMethod]
        public void AddCompetitor()
        {

            Competitor c = new Competitor {
                        email = "test@test.sk",
                        name =  "Adam Sangala",
                        phone = "+421944123456",
                        birth_date = DateTime.Now
            };

            Assert.AreEqual(Enums.RequestStatus.Success, this.ctrl.Add(c).Status);
        }

        [TestMethod]
        public void AddCompetitorVstupEmail()
        {
            Competitor c = new Competitor
            {
                email = "plainaddress",
                name = "John Smith",
                phone = "+421944123456",
                birth_date = DateTime.Now
            };

            // Missing @ sign and domain
            Assert.AreEqual(Enums.RequestStatus.Error, ctrl.Add(c).Status);
            // Garbage
            c.email = "#@%^%#$@#$@#.com";
            Assert.AreEqual(Enums.RequestStatus.Error, ctrl.Add(c).Status);
            //Missing username
            c.email = "@domain.com";
            Assert.AreEqual(Enums.RequestStatus.Error, ctrl.Add(c).Status);
            // Missing @
            c.email = "email.domain.com";
            Assert.AreEqual(Enums.RequestStatus.Error, ctrl.Add(c).Status);
            // Two @ sign
            c.email = "email@domain@domain.com";
            Assert.AreEqual(Enums.RequestStatus.Error, ctrl.Add(c).Status);
            //Leading dot 
            c.email = ".email@domain.com";
            Assert.AreEqual(Enums.RequestStatus.Error, ctrl.Add(c).Status);      
        }

        [TestMethod]
        public void AddCompetitorVstupCislo()
        {
   
            Competitor c = new Competitor
            {
                email = "test@test.sk",
                name = "John Smith",
                phone = "+421944123456",
                birth_date = DateTime.Now
            };

            // emtpy
            c.phone = "";
            Assert.AreEqual(Enums.RequestStatus.Error, ctrl.Add(c).Status);

            // wrong count 
            c.phone = "012345678";
            Assert.AreEqual(Enums.RequestStatus.Error, ctrl.Add(c).Status);

            c.phone = "01234567890";
            Assert.AreEqual(Enums.RequestStatus.Error, ctrl.Add(c).Status);

        }

        [TestMethod]
        public void UpdateCompetitorTest()
        {

            Competitor c = new Competitor { email = "test@test.sk", name = "Tester", phone = "+421944123456", birth_date = DateTime.Now };
            Assert.AreEqual(Enums.RequestStatus.Success, ctrl.Add(c).Status);
            c.name = "Tester Zmeneny";
            Assert.AreEqual(Enums.RequestStatus.Success, ctrl.Update(c).Status);
        }

        [TestMethod]
        public void RemoveCompetitorTest()
        {

            Competitor c = new Competitor { email = "test@test.sk", name = "Tester Na Vymazanie", phone = "+421944123456", birth_date = DateTime.Now };
            Assert.AreEqual(Enums.RequestStatus.Success, ctrl.Add(c).Status);
            Assert.AreEqual(Enums.RequestStatus.Success, ctrl.Remove(c).Status);
        }

        [TestMethod]
        public void RemoveRangeCompetitorTest()
        {

            List<Competitor> range = ctrl.Competitors.FindAll(item => item.email == "test@test.sk");
            Assert.AreEqual(Enums.RequestStatus.Success, ctrl.RemoveRangeCompetitors(range).Status);
        }
    }
}
