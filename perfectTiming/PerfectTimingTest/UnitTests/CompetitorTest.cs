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
        [TestCategory("Add")]
        [TestMethod]
        public void AddCompetitor()
        {
            CompetitorController ctrl = new CompetitorController();


            Competitor c = new Competitor {
                        email = "abc@abcd.sk",
                        name =  "Adam Sangala",
                        phone = "+421944123456",
                        birth_date = DateTime.Now
            };

            Assert.AreEqual(Enums.RequestStatus.Success, ctrl.AddCompetitor(c).Status);
        }

        [TestMethod]
        public void AddCompetitorVstupEmail()
        {
            CompetitorController ctrl = new CompetitorController();

            Competitor c = new Competitor
            {
                email = "plainaddress",
                name = "John Smith",
                phone = "+421944123456",
                birth_date = DateTime.Now
            };


            // Missing @ sign and domain
            Assert.AreEqual(Enums.RequestStatus.Error, ctrl.AddCompetitor(c).Status);
            // Garbage
            c.email = "#@%^%#$@#$@#.com";
            Assert.AreEqual(Enums.RequestStatus.Error, ctrl.AddCompetitor(c).Status);
            //Missing username
            c.email = "@domain.com";
            Assert.AreEqual(Enums.RequestStatus.Error, ctrl.AddCompetitor(c).Status);
            // Missing @
            c.email = "email.domain.com";
            Assert.AreEqual(Enums.RequestStatus.Error, ctrl.AddCompetitor(c).Status);
            // Two @ sign
            c.email = "email@domain@domain.com";
            Assert.AreEqual(Enums.RequestStatus.Error, ctrl.AddCompetitor(c).Status);
            //Leading dot 
            c.email = ".email@domain.com";
            Assert.AreEqual(Enums.RequestStatus.Error, ctrl.AddCompetitor(c).Status);
            // Trailing dot 
            c.email = "email.@domain.com";
            Assert.AreEqual(Enums.RequestStatus.Error, ctrl.AddCompetitor(c).Status);
            // Multiple dots
            c.email = "email..email@domain.com";
            Assert.AreEqual(Enums.RequestStatus.Error, ctrl.AddCompetitor(c).Status);
            // Missing top level domain
            c.email = "email@domain";
            Assert.AreEqual(Enums.RequestStatus.Error, ctrl.AddCompetitor(c).Status);
            // Leading dash in front of domain 
            c.email = "email@-domain.com";
            Assert.AreEqual(Enums.RequestStatus.Error, ctrl.AddCompetitor(c).Status);
            // Multiple dot in the domain portion 
            c.email = "email@domain..com";
            Assert.AreEqual(Enums.RequestStatus.Error, ctrl.AddCompetitor(c).Status);          
            // Space
            c.email = " email@domain.com";
            Assert.AreEqual(Enums.RequestStatus.Error, ctrl.AddCompetitor(c).Status);
  

        }

        [TestMethod]
        public void AddCompetitorVstupCislo()
        {
            CompetitorController ctrl = new CompetitorController();

            Competitor c = new Competitor
            {
                email = "email@domain.com",
                name = "John Smith",
                phone = "+421944123456",
                birth_date = DateTime.Now
            };

            // emtpy
            c.phone = "";
            Assert.AreEqual(Enums.RequestStatus.Error, ctrl.AddCompetitor(c).Status);


            // wrong count 
            c.phone = "012345678";
            Assert.AreEqual(Enums.RequestStatus.Error, ctrl.AddCompetitor(c).Status);

            c.phone = "01234567890";
            Assert.AreEqual(Enums.RequestStatus.Error, ctrl.AddCompetitor(c).Status);

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
