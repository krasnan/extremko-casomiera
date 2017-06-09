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
        RequestResult<bool> IsValidEmial(Competitor item);
        RequestResult<bool> IsValidName(Competitor item);
        RequestResult<bool> IsValidBirthDate(Competitor item);
        RequestResult<bool> IsValidPhone(Competitor item);

        RequestResult<List<Competitor>> RemoveRangeCompetitors(List<Competitor> range);
    }
}
