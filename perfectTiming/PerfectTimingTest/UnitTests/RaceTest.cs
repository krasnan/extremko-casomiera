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
        perfecttimingEntities _context;

        [TestMethod]
        public void AddRaceTest()
        {
            RaceController ctrl = new RaceController(ref _context);
            Race c = new Race { name = "NewRace", location = "XY", start_date = DateTime.Now, status = (int)Enums.RaceStatus.NotStarted }; 
            Assert.AreEqual(Enums.RequestStatus.Success, ctrl.Add(c).Status);
        }

        [TestMethod]
        public void AddRaceTestVstupDate()
        {
           RaceController ctrl = new RaceController(ref _context);

           DateTime time = DateTime.Now;
           time.AddMinutes(-1);

            // Past time 
            Race c = new Race { name = "Back to the past", location = "Past", start_date = time, status = (int)Enums.RaceStatus.NotStarted }; ;
            Assert.AreEqual(Enums.RequestStatus.Error, ctrl.Add(c).Status);
        }

        public void AddRaceTestVstupName()
        {
            RaceController ctrl = new RaceController(ref _context);

            Race c = new Race {
                            name = "",
                            location = "XY",
                            start_date = DateTime.Now,
                            status = (int)Enums.RaceStatus.NotStarted
                        }; 
            // Emtpy name
            Assert.AreEqual(Enums.RequestStatus.Error, ctrl.Add(c).Status);
            // Long Name
            c.name = new string('a',256);
            Assert.AreEqual(Enums.RequestStatus.Error, ctrl.Add(c).Status);
            // OK Name
            c.name = new string('a', 255);
            Assert.AreEqual(Enums.RequestStatus.Success, ctrl.Add(c).Status);

        }

        [TestMethod] 
        public void UpdateRace()
        {
            RaceController ctrl = new RaceController(ref _context);
            Race old = new Race
            {
                name = "OldSuperRace",
                location = "OldLocation",
                start_date = DateTime.Now,
                status = (int)Enums.RaceStatus.NotStarted
            };

            ctrl.Add(old);
            // upravenie lokacie
            Race nnew = ctrl.Races[ctrl.Races.Count - 1];
            nnew.location = "NewLocation";
            Assert.AreEqual(Enums.RequestStatus.Success, ctrl.Update(nnew).Status);
            Assert.AreEqual(old.location, ctrl.Races[ctrl.Races.Count - 1].location);

            // Meno prazdne
            old.name = "";
            Assert.AreEqual(Enums.RequestStatus.Error, ctrl.Update(old).Status);
            Assert.AreEqual(nnew.location, ctrl.Races[ctrl.Races.Count - 1].location);

            // Upravenie mena
            old.name = "UpdatedOldSuperRace";
            Assert.AreEqual(Enums.RequestStatus.Success, ctrl.Update(old).Status);
            Assert.AreEqual(nnew.location, ctrl.Races[ctrl.Races.Count - 1].location);
        }

        [TestMethod]
        public void RemoveRaceSimple()
        {
            RaceController ctrl = new RaceController(ref _context);
            Race c = new Race { name = "RemoveTest", location = "RemovedLocation", start_date = DateTime.Now, status = (int)Enums.RaceStatus.NotStarted };
            ctrl.Add(c);
            Assert.AreEqual(Enums.RequestStatus.Success, ctrl.Remove(c).Status);
        }

        [TestMethod]
        public void RemoveRangeRaceTest()
        {
            RaceController ctrl = new RaceController(ref _context);
            int countBefore = ctrl.Races.Count;

            for(int i = 0; i < 50; i++)
            {
                ctrl.Add(new Race { name = "RemoveMe", location = "RemovedLocation", start_date = DateTime.Now, status = (int)Enums.RaceStatus.NotStarted });
            }
            List<Race> range = ctrl.Races.FindAll(item => item.name == "RemoveMe");
            Assert.AreEqual(Enums.RequestStatus.Success, ctrl.RemoveRange(range).Status);

            Assert.AreEqual(countBefore, ctrl.Races.Count);
        }
    }
}
