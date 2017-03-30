using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using perfectTiming.Model;

namespace PerfectTimingTest.UnitTests
{
    [TestClass]
    public class RegistrationTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            perfecttimingEntities _context=new perfecttimingEntities() ; // context databazy
            
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
                },
                Race = new Race
                {
                    name = "test",
                    location = "test",
                    start_date = DateTime.Now,
                    status = 0
                }
            };
            
        }
    }
}
