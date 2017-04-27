using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using perfectTiming.Model;
using perfectTiming.Helpers;


namespace perfectTiming.Controller
{
    interface IRegistrationController
    {
        List<Registration> Registrations { get; set; }


        RequestResult<Registration> Add(Registration item);
        RequestResult<Registration> Update(Registration item);
        RequestResult<Registration> Remove(Registration item);
        RequestResult<bool> Save();
        RequestResult<List<Competitor>> GetCompetitors(Race item);
        RequestResult<List<Category>> GetCategories(Race item);
        RequestResult<List<Competitor>> GetCategoryCompetitors(Category item);
    }
}
