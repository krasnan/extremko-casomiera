using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using perfectTiming.Model;
using perfectTiming.Helpers;

namespace perfectTiming.Controller
{
    interface IRaceController
    {
        //public int id { get; set; }
        //public string name { get; set; }
        //public string location { get; set; }
        //public System.DateTime start_date { get; set; }
        //public int status { get; set; }

        List<Race> Races { get; }

        RequestResult<Race> Add(Race item);
        RequestResult<Race> Update(Race item);
        RequestResult<Race> Remove(Race item);

        RequestResult<List<Race>> RemoveRange(List<Race> range);


    }
}
