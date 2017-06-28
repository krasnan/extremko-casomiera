using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using perfectTiming.Model;
using perfectTiming.Helpers;

namespace perfectTiming.Controller
{
    interface ITimingController
    {

        List<Timing> Timings { get; }

        RequestResult<Timing> Add(Timing item);
        RequestResult<Timing> Update(Timing item);
        RequestResult<Timing> Remove(Timing item);
        RequestResult<bool> Save();

    }
}
