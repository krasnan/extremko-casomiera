using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfectTiming.Helpers
{
    public class Enums
    {
        public enum RequestStatus : int
        {
            Error = 0,
            Warning = 1,
            Success = 2
        }
        public enum RaceStatus : int
        {
            NotStarted = 0,
            Started = 1,
            Ended = 2
        }
    }
}
