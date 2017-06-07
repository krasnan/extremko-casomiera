using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using perfectTiming.Model;
using perfectTiming.Helpers;
using System.Text.RegularExpressions;

namespace perfectTiming.Controller
{
    public class CompetitorController : ICompetitorController
    {
        public List<Competitor> Competitors { get { return _context.Competitors.ToList(); } }

        private perfecttimingEntities _context; // context databazy

        /// <summary>
        /// Controller na spravu ucastnikov
        /// </summary>
        public CompetitorController(ref perfecttimingEntities context)
        {
            _context = context; 
        }

        public CompetitorController(List<Competitor> range)
        {
            _context = new perfecttimingEntities();
        }

        /// <summary>
        /// Prida objekt do databazy a do zoznamu
        /// </summary>
        /// <param name="item">Objekty ktory ma byt pridany</param>
        /// <returns></returns>
        public RequestResult<Competitor> Add(Competitor item)
        {
            try
            {
                _context.Competitors.Add(item);
                _context.SaveChanges();
                return new RequestResult<Competitor>{ Status = Enums.RequestStatus.Success, Message = "Účastník úspešne uložený.", Data = item };
            }
            catch (Exception ex)
            {
                return new RequestResult<Competitor> { Status = Enums.RequestStatus.Error, Message = "Účastníka sa nepodarilo vložiť.", Detail = ex.Message};
            }
        }

        /// <summary>
        /// Aktualizuje vlastnosti objektu
        /// </summary>
        /// <param name="item">Aktualizovany objekt</param>
        /// <returns></returns>
        public RequestResult<Competitor> Update(Competitor item)
        {
            try
            {
                _context.Competitors.Attach(item);
                var entry = _context.Entry(item);
                entry.State = System.Data.Entity.EntityState.Modified;
                _context.SaveChanges();
                return new RequestResult<Competitor> { Status = Enums.RequestStatus.Success, Message = "Účastník úspešne uložený.", Data = item };
            }
            catch (Exception ex)
            {
                return new RequestResult<Competitor> { Status = Enums.RequestStatus.Error, Message = "Účastníka sa nepodarilo zmeniť.", Detail = ex.Message };
            }
        }

        /// <summary>
        /// Vymaze objekt z databazy a zoznamu
        /// </summary>
        /// <param name="item">Objekt ktory ma byt vymazany</param>
        /// <returns></returns>
        public RequestResult<Competitor> Remove(Competitor item)
        {
            try {
                _context.Competitors.Attach(item);
                _context.Competitors.Remove(item);
                _context.SaveChanges();
                return new RequestResult<Competitor> { Status = Enums.RequestStatus.Success, Message = "Účastník úspešne vymazaný.", Data = item };
            }
            catch (Exception ex)
            {
                return new RequestResult<Competitor> { Status = Enums.RequestStatus.Error, Message = "Účastníka sa nepodarilo vymazať.", Detail = ex.Message };
            }
        }

        /// <summary>
        /// Vymaze vsetky objekty zo zoznamu
        /// </summary>
        /// <param name="range">zoznam poloziek na vymazanie</param>
        /// <returns></returns>
        public RequestResult<List<Competitor>> RemoveRangeCompetitors(List<Competitor> range)
        {
            try
            {
                _context.Competitors.RemoveRange(range);
                _context.SaveChanges();
                return new RequestResult<List<Competitor>> { Status = Enums.RequestStatus.Success, Message = "Záznami úspešne odstránené.", Data = range};
            }
            catch (Exception ex)
            {
                return new RequestResult<List<Competitor>> { Status = Enums.RequestStatus.Error, Message = "Záznamy sa nepodarilo odstrániť.", Detail = ex.Message };
            }
        }

        public bool IsValidEmial(Competitor item)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(item.email);
                return addr.Address == item.email;
            }
            catch
            {
                return false;
            }
        }

        public bool IsValidName(Competitor item)
        {
            if (item.name.Length < 3)
                return false;
            //if (item.name.All(char.IsLetter))
            //    return true;
            return false;
        }

        public bool IsValidBirthDate(Competitor item)
        {
            if (item.birth_date <= DateTime.Now)
                return true;
            return false;
        }

        public bool IsValidPhone(Competitor item)
        {
            return Regex.Match(item.phone, @"^(\+421)? ?[1-9][0-9]{2} ?[0-9]{3} ?[0-9]{3}$").Success
                || Regex.Match(item.phone, @"^([0-9]{10})$").Success;
        }
        public RequestResult<bool> Save()
        {
            try
            {
                _context.SaveChanges();
                return new RequestResult<bool> { Status = Enums.RequestStatus.Success, Message = "Kategória uložená", Data = true };
            }
            catch (Exception)
            {

                return new RequestResult<bool> { Status = Enums.RequestStatus.Error, Message = "Nepodarilo sa uložiť kategoriu", Data = false };
            }
        }
    }
}
