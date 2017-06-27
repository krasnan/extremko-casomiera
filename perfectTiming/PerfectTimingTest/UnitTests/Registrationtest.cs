using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using perfectTiming.Controller;
using perfectTiming.Model;
using perfectTiming.Helpers;
using System.Collections.Generic;

namespace PerfectTimingTest.UnitTests
{
    [TestClass]
    public class RegistrationTest
    {

        private perfecttimingEntities _context;
        private RegistrationController ctrl;

        public RegistrationTest()
        {
            this._context = new perfecttimingEntities();
            this.ctrl = new RegistrationController(ref _context);
        }

        [TestMethod]
        public void TestMethod1()
        {
           
            
            Registration item = new Registration {
                start_number = 1,
                Category = new Category
                {
                    description = "test",
                    name = "test"
                },
                Competitor = new Competitor {
                    name = "tester",
                    birth_date = DateTime.Now,
                    email = "test@test.com",
                    phone = "test"
                }
            };
            
        }
    }
}
