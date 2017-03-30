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
        bool IsValidEmial(Competitor item);
        bool IsValidName(Competitor item);
        bool IsValidBirthDate(Competitor item);
        bool IsValidPhone(Competitor item);
        RequestResult<List<Competitor>> RemoveRangeCompetitors(List<Competitor> range);
    }
}
