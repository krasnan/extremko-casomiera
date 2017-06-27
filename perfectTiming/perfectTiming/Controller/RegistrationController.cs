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

        public RequestResult<List<Competitor>> GetCompetitors(Race item)
        {
            return null;
            List<Competitor> res = _context.Registrations.Where(r => r.Category.race_id == item.id).Select(r => r.Competitor).ToList();
                
                //

            //List<Competitor> result = new List<Competitor>();

            //try
            //{
            //    foreach (Registration reg in _registrations)
            //    {
            //        if (reg.id == item.id)
            //        {
            //            result.Add(reg.Competitor);
            //        }

            //    }
            //    return new RequestResult<List<Competitor>> { Status = Enums.RequestStatus.Success, Message = "Registrácie jazdcov pre závod načítané", Data = result };

            //}
            //catch (Exception ex)
            //{
            //    return new RequestResult<List<Competitor>> { Status = Enums.RequestStatus.Error, Message = "Kategóriu sa nepodarilo pridať", Detail = ex.Message };
            //}

        }

        public RequestResult<List<Category>> GetCategories(Race item)
        {
            return null;
            //List<Category> result = new List<Category>();

            //try
            //{
            //    foreach (Registration reg in _registrations)
            //    {
            //        if (reg.id == item.id && !result.Contains(reg.Category))
            //                result.Add(reg.Category);
                    
            //    }

            //    return new RequestResult<List<Category>> { Status = Enums.RequestStatus.Success, Message = "Zoznam kategorií načítaný", Data = result };
            //}
            //catch (Exception ex)
            //{

            //    return new RequestResult<List<Category>> { Status = Enums.RequestStatus.Error, Message = "Kategórie sa nepodarilo načítať", Detail = ex.Message };
            //}
        }

        public RequestResult<List<Competitor>> GetCategoryCompetitors(Category item)
        {
            return null;
            //List<Competitor> result = new List<Competitor>();
            //try
            //{

            //    foreach (Registration reg in _registrations)
            //    {
            //        if (reg.id == item.id)
            //        {
            //            result.Add(reg.Competitor);
            //        }
            //    }
            //    return new RequestResult<List<Competitor>> { Status = Enums.RequestStatus.Success, Message = "Zoznam kategorií načítaný", Data = result };
            //}
            //catch (Exception ex)
            //{

            //    return new RequestResult<List<Competitor>> { Status = Enums.RequestStatus.Error, Message = "Súťažiacich sa nepodarilo načítať", Detail = ex.Message };
            //}
            
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
