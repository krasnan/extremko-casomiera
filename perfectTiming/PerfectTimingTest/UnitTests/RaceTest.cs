using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using perfectTiming.Controller;
using perfectTiming.Model;
using perfectTiming.Helpers;
using System.Collections.Generic;

namespace PerfectTimingTest.UnitTests
{
    [TestClass]
    public class RaceTest
    {
        [TestMethod]
        public void AddRaceTest()
        {
            RaceController ctrl = new RaceController();
            Race c = new Race { name = "Pridany Vecerny beh mestom AAA", location = "test", start_date = DateTime.Now, status = (int)Enums.RaceStatus.NotStarted }; ;
            Assert.AreEqual(Enums.RequestStatus.Success, ctrl.Add(c).Status);
        }

        [TestMethod] 
        public void UpdateRaceTest()
        {
            RaceController ctrl = new RaceController();
            Race c = new Race { name = "Pridany Vecerny beh mestom UPRAVENY", location = "test",  start_date = DateTime.Now , status = (int)Enums.RaceStatus.NotStarted };
            Assert.AreEqual(Enums.RequestStatus.Success, ctrl.Add(c).Status);
            c.name = "Tester Zmeneny";
            Assert.AreEqual(Enums.RequestStatus.Success, ctrl.Update(c).Status);
        }

        [TestMethod]
        public void RemoveRaceTest()
        {
            RaceController ctrl = new RaceController();
            Race c = new Race { name = "Vecerny beh mestom", location = "test", start_date = DateTime.Now, status = (int)Enums.RaceStatus.NotStarted };
            Assert.AreEqual(Enums.RequestStatus.Success, ctrl.Add(c).Status);
            Assert.AreEqual(Enums.RequestStatus.Success, ctrl.Remove(c).Status);
        }

        [TestMethod]
        public void RemoveRangeRaceTest()
        {
            RaceController ctrl = new RaceController();
            List<Race> range = ctrl.Races.FindAll(item => item.name == "Pridany Vecerny beh mestom UPRAVENY");
            Assert.AreEqual(Enums.RequestStatus.Success, ctrl.RemoveRange(range).Status);
        }
    }
}
