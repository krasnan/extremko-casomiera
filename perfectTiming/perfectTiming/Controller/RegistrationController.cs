using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using perfectTiming.Model;
using perfectTiming.Helpers;

namespace perfectTiming.Controller
{
    class RegistrationController : IRegistrationController
    {
        private List<Registration> _registrations;
        public List<Registration> Registrations { get { return _registrations; } set { _registrations = value; } }
        public List<Competitor> Competitors { get { return this.GetCompetitors().Data; } }
        //public List<Competitor>

        public RequestResult<Registration> Add(Registration item)
        {
            throw new NotImplementedException();
        }

        public RequestResult<List<Category>> GetCategories()
        {
            throw new NotImplementedException();
            //return Registrations.Select(i => i.Category).ToList();
        }

        public RequestResult<List<Competitor>> GetCompetitors()
        {
            throw new NotImplementedException();
        }

        public RequestResult<Registration> Remove(Registration item)
        {
            throw new NotImplementedException();
        }

        public RequestResult<Registration> RemoveRange(List<Registration> range)
        {
            throw new NotImplementedException();
        }

        public RequestResult<Registration> Update(Registration item)
        {
            throw new NotImplementedException();
        }
    }
}
