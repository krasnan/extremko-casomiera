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
        const int TEST_EVENT_ID = 209; // ID testovacej Udalosti 

        public TimingTest()
        {
            this._context = new perfecttimingEntities();
            this.ctrl = new TimingController(ref _context);
        }

        //public int id { get; set; }
        //public int registration_id { get; set; }
        //public Nullable<double> lap_time { get; set; }
        //public Nullable<int> lap_number { get; set; }
        //public double lap_timestamp { get; set; }

        //public virtual Registration Registration { get; set; }


        [TestMethod]
        public void AddTimingTest()
        {
            //TimingController ctrl = new TimingController();

            Timing c = new Timing {
                                registration_id = TEST_EVENT_ID,
                                lap_time = 1.0 ,
                                lap_number = 0
            };


            Assert.AreEqual(Enums.RequestStatus.Success, ctrl.Add(c).Status);
            Assert.AreEqual(Enums.RequestStatus.Success, ctrl.Remove(c).Status);

        }

        [TestMethod]
        public void UpdateTimingTest()
        {

            Timing c = new Timing
            {
                registration_id = TEST_EVENT_ID,
                lap_time = 1.0,
                lap_number = 0
            };
            Assert.AreEqual(Enums.RequestStatus.Success, ctrl.Add(c).Status);
            c.lap_number = 1;
            Assert.AreEqual(Enums.RequestStatus.Success, ctrl.Update(c).Status);
            Assert.AreEqual(Enums.RequestStatus.Success, ctrl.Remove(c).Status);


        }

        [TestMethod]
        public void RemoveTimingTest()
        {
            Timing c = new Timing
            {
                registration_id = TEST_EVENT_ID,
                lap_time = 1222.0,
                lap_number = 2
            };


            Assert.AreEqual(Enums.RequestStatus.Success, ctrl.Add(c).Status);
            Assert.AreEqual(Enums.RequestStatus.Success, ctrl.Remove(c).Status);

            Timing c2 = new Timing
            {
                registration_id = 0,
                lap_time = 0.0,
                lap_number = 2
            };

            Assert.AreEqual(Enums.RequestStatus.Error, ctrl.Remove(c2).Status);

        }


    }
}
