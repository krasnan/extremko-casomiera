using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfectTiming.Model
{
    public static class Db
    {
        private static perfecttimingEntities _context = new perfecttimingEntities();
        public static perfecttimingEntities Context { get; set; }
    }
}
