using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using perfectTiming.Model;
using perfectTiming.Helpers;

namespace perfectTiming.Controller
{
    public class RegistrationController : IRegistrationController
    {
        private List<Registration> _registrations;
        public List<Registration> Registrations { get { return _registrations; } set { _registrations = value; } }


        private perfecttimingEntities _context; // context databazy


        public RegistrationController()
        {
            _context = new perfecttimingEntities();
            _registrations = _context.Registrations.ToList();

        }


        public RequestResult<Registration> Add(Registration item)
        {
            
            try
            {
                _context.Registrations.Add(item);
                //_context.SaveChanges();
                _registrations.Add(item);
                return new RequestResult<Registration> { Status = Enums.RequestStatus.Success, Message = "Záznam úspešne uložený", Data = item };
            }
            catch (Exception ex)
            {
                return new RequestResult<Registration> { Status = Enums.RequestStatus.Error, Message = "Záznam sa nepodarilo vložiť", Detail = ex.Message };
            }


        }
        public RequestResult<Registration> Update(Registration item)
        {
            try
            {

                int index = _registrations.FindIndex(o => o.id == item.id);
                if( index != -1)
                {

                    _context.Registrations.Attach(item);
                    var entry = _context.Entry(item);
                    entry.State = System.Data.Entity.EntityState.Modified;
                    //_context.SaveChanges();
                    _registrations[index] = item;

                }
                return new RequestResult<Registration> { Status = Enums.RequestStatus.Success, Message = "Záznam úspešne uložený", Data = item };
            }
            catch (Exception ex )
            {

                return new RequestResult<Registration> { Status = Enums.RequestStatus.Error, Message = "Záznam sa nepodarilo zmeniť.", Detail = ex.Message };
            }

        }

        public RequestResult<List<Competitor>> GetCompetitors(Race item)
        {

            List<Competitor> result = new List<Competitor>();

            try
            {
                foreach (Registration reg in _registrations)
                {
                    if (reg.id == item.id)
                    {
                        result.Add(reg.Competitor);
                    }

                }
                return new RequestResult<List<Competitor>> { Status = Enums.RequestStatus.Success, Message = "Registrácie jazdcov pre závod načítané", Data = result };

            }
            catch (Exception ex)
            {
                return new RequestResult<List<Competitor>> { Status = Enums.RequestStatus.Error, Message = "Kategóriu sa nepodarilo pridať", Detail = ex.Message };
            }
           
        }

        public RequestResult<Registration> Remove(Registration item)
        {

            try
            {
                _context.Registrations.Attach(item);
                _context.Registrations.Remove(item);
                _registrations.Remove(item);

                return new RequestResult<Registration> { Status = Enums.RequestStatus.Success, Message = "Kategória vymazaná", Data = item };
            }
            catch (Exception ex)
            {

                return new RequestResult<Registration> { Status = Enums.RequestStatus.Error, Message = "Registrácia nebola vymazaná", Detail = ex.Message };
            }
        }

        public RequestResult<List<Category>> GetCategories(Race item)
        {
            List<Category> result = new List<Category>();

            try
            {
                foreach (Registration reg in _registrations)
                {
                    if (reg.id == item.id && !result.Contains(reg.Category))
                            result.Add(reg.Category);
                    
                }

                return new RequestResult<List<Category>> { Status = Enums.RequestStatus.Success, Message = "Zoznam kategorií načítaný", Data = result };
            }
            catch (Exception ex)
            {

                return new RequestResult<List<Category>> { Status = Enums.RequestStatus.Error, Message = "Kategórie sa nepodarilo načítať", Detail = ex.Message };
            }
        }

        public RequestResult<List<Competitor>> GetCategoryCompetitors(Category item)
        {

            List<Competitor> result = new List<Competitor>();
            try
            {

                foreach (Registration reg in _registrations)
                {
                    if (reg.id == item.id)
                    {
                        result.Add(reg.Competitor);
                    }
                }
                return new RequestResult<List<Competitor>> { Status = Enums.RequestStatus.Success, Message = "Zoznam kategorií načítaný", Data = result };
            }
            catch (Exception ex)
            {

                return new RequestResult<List<Competitor>> { Status = Enums.RequestStatus.Error, Message = "Súťažiacich sa nepodarilo načítať", Detail = ex.Message };
            }
            
        }
    }
}
