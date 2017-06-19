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
        public List<Registration> Registrations { get { return _context.Registrations.ToList(); } }
        private perfecttimingEntities _context; // context databazy
        
        public RegistrationController(ref perfecttimingEntities context)
        {
            _context = context;
        }


        public RequestResult<Registration> Add(Registration item)
        {
            try
            {
                _context.Registrations.Add(item);
                _context.SaveChanges();
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
                _context.Registrations.Attach(item);
                var entry = _context.Entry(item);
                entry.State = System.Data.Entity.EntityState.Modified;
                _context.SaveChanges();
                return new RequestResult<Registration> { Status = Enums.RequestStatus.Success, Message = "Záznam úspešne uložený", Data = item };
            }
            catch (Exception ex )
            {
                return new RequestResult<Registration> { Status = Enums.RequestStatus.Error, Message = "Záznam sa nepodarilo zmeniť.", Detail = ex.Message };
            }
        }


        public RequestResult<Registration> Remove(Registration item)
        {

            try
            {
                _context.Registrations.Attach(item);
                _context.Registrations.Remove(item);
                return new RequestResult<Registration> { Status = Enums.RequestStatus.Success, Message = "Kategória vymazaná", Data = item };
            }
            catch (Exception ex)
            {

                return new RequestResult<Registration> { Status = Enums.RequestStatus.Error, Message = "Registrácia nebola vymazaná", Detail = ex.Message };
            }
        }

        public RequestResult<List<Competitor>> GetCompetitors(Race race)
        {

            try
            {
                List<Competitor> result = _context.Registrations.Where(reg => reg.Category.race_id == race.id).Select(reg => reg.Competitor).ToList();

                return new RequestResult<List<Competitor>> { Status = Enums.RequestStatus.Success, Message = "Registrácie jazdcov pre závod načítané", Data = result };

            }
            catch (Exception ex)
            {
                return new RequestResult<List<Competitor>> { Status = Enums.RequestStatus.Error, Message = "Kategóriu sa nepodarilo pridať", Detail = ex.Message };
            }

        }

        public RequestResult<List<Category>> GetCategories(Race item)
        {

         
            return null;

        }

        public RequestResult<List<Competitor>> GetCategoryCompetitors(Category item)
        {
            return null;

        }

        public RequestResult<Registration> GetRegistration(Race race,int start_number)
        {

            Registration reg;
            try
            {
                reg = _context.Registrations.Where(re => re.Category.race_id == race.id).FirstOrDefault(re => re.start_number == start_number);

                return new RequestResult<Registration> { Status = Enums.RequestStatus.Success, Message = "Registrácia získaná", Data = reg };
            }
            catch (Exception)
            {
                return new RequestResult<Registration> { Status = Enums.RequestStatus.Error, Message = "Jazdec s daným štartovným číslom neexistuje",};
            }


        }


        public RequestResult<List<Registration>> GetRegistrations(Race race)
        {

            try
            {
                List<Registration> result = _context.Registrations.Where(reg => reg.Category.race_id == race.id).ToList();

                return new RequestResult<List<Registration>> { Status = Enums.RequestStatus.Success, Message = "Registrácie jazdcov pre závod načítané", Data = result };

            }
            catch (Exception ex)
            {
                return new RequestResult<List<Registration>> { Status = Enums.RequestStatus.Error, Message = "Registracie sa nepodarilo načítať", Detail = ex.Message };
            }




        }





        public RequestResult<bool> Save()
        {
            try
            {
                _context.SaveChanges();
                return new RequestResult<bool> { Status = Enums.RequestStatus.Success, Message = "registrácia uložená", Data = true };
            }
            catch (Exception)
            {
                return new RequestResult<bool> { Status = Enums.RequestStatus.Error, Message = "Nepodarilo sa uložiť registráciu", Data = false };
            }
        }
    }
}
