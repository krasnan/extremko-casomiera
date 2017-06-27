using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using perfectTiming.Controller;
using perfectTiming.Model;
using perfectTiming.Helpers;
using System.Collections.Generic;


namespace PerfectTimingTest.UnitTests
{
    [TestClass]
    public class TimingTest
    {
        private perfecttimingEntities _context;
        private TimingController ctrl;

        public TimingTest()
        {
            this._context = new perfecttimingEntities();
            this.ctrl = new TimingController(ref _context);
        }

        [TestMethod]
        public void AddTimingTest()
        {
            //TimingController ctrl = new TimingController();
            //Timing c = new Timing { competitor_id = 1,  race_id = 0 , lap_time = 1.0 , lap_number = 0 };
            Assert.Fail();
        }

        [TestMethod]
        public void UpdateTimingTest()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void RemoveTimingTest()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void RemoveRangeTimingTest()
        {
            Assert.Fail();
        }
    }
}
