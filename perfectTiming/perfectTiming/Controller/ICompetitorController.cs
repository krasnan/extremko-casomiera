using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using perfectTiming.Model;
using perfectTiming.Helpers;


namespace perfectTiming.Controller
{
    interface ICompetitorController
    {
        List<Competitor> Competitors { get; set; }

        RequestResult<Competitor> AddCompetitor(Competitor item);
        RequestResult<Competitor> UpdateCompetitor(Competitor item);
        RequestResult<Competitor> RemoveCompetitor(Competitor item);

        RequestResult<List<Competitor>> RemoveRangeCompetitors(List<Competitor> range);
    }
}
