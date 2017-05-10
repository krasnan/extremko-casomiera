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
        List<Competitor> Competitors { get;}

        RequestResult<Competitor> Add(Competitor item);
        RequestResult<Competitor> Update(Competitor item);
        RequestResult<Competitor> Remove(Competitor item);
        bool IsValidEmial(Competitor item);
        bool IsValidName(Competitor item);
        bool IsValidBirthDate(Competitor item);
        bool IsValidPhone(Competitor item);

        RequestResult<List<Competitor>> RemoveRangeCompetitors(List<Competitor> range);
    }
}
