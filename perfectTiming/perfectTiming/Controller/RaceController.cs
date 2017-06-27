using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using perfectTiming.Model;
using perfectTiming.Helpers;

namespace perfectTiming.Controller
{
   public class RaceController : IRaceController
    {
        private perfecttimingEntities _context; // context databazy


        public List<Race> Races { get { return _context.Races.ToList(); } }

        /// <summary>
        /// Controller na spravu jednotlivých závodov
        /// </summary>
        public RaceController(ref perfecttimingEntities  context)
        {
            _context = context;
        }

        /// <summary>
        /// Prida do databázy nový závod
        /// </summary>
        /// <param name="item"> Závod ktorý ma byt pridaný</param>
        /// <returns></returns>
        public RequestResult<Race> Add(Race item)
        {
            try
            {

                string msg = "";

                msg += IsValidName(item).Message;
                msg += IsValidLocation(item).Message;
                msg += IsValidStartDate(item).Message;
                if (msg != "")
                    throw new Exception(msg);

                _context.Races.Add(item);
                _context.SaveChanges();
                return new RequestResult<Race> { Status = Enums.RequestStatus.Success, Message = "Záznam úspešne uložený", Data = item };
            }
            catch (Exception ex)
            {
                return new RequestResult<Race> { Status = Enums.RequestStatus.Error, Message = "Záznam sa nepodarilo vložiť", Detail = ex.Message };
            }
        }
        /// <summary>
        /// Aktualizuje vlastnost závodu
        /// </summary>
        /// <param name="item">Aktualizovaný objekt</param>
        /// <returns></returns>
        public RequestResult<Race> Update(Race item)
        {
            try
            {

                string msg = "";

                msg += IsValidName(item).Message;
                msg += IsValidLocation(item).Message;
                msg += IsValidStartDate(item).Message;
                if (msg != "")
                    throw new Exception(msg);


                _context.Races.Attach(item);
                var entry = _context.Entry(item);
                entry.State = System.Data.Entity.EntityState.Modified;
                _context.SaveChanges();
                return new RequestResult<Race> { Status = Enums.RequestStatus.Success, Message = "Záznam úspešne uložený", Data = item };
            }
            catch (Exception ex)
            {
                return new RequestResult<Race> { Status = Enums.RequestStatus.Error, Message = "Záznam sa nepodarilo zmeniť.", Detail = ex.Message };
            }

        }

        /// <summary>
        /// Vymaze závod z databazy
        /// </summary>
        /// <param name="item">Objekt ktorý ma byt vymazany</param>
        /// <returns></returns>
        public RequestResult<Race> Remove(Race item)
        {
            try
            {
                _context.Races.Attach(item);
                _context.Races.Remove(item);
                _context.SaveChanges();
                return new RequestResult<Race> { Status = Enums.RequestStatus.Success, Message = "Záznam úspešne vymazaný.", Data = item };
            }
            catch (Exception ex)
            {
                return new RequestResult<Race> { Status = Enums.RequestStatus.Error, Message = "Záznam sa nepodarilo vymazať.", Detail = ex.Message };
            }
        }



        /// <summary>
        /// Vymaze vsetky objekty zo zoznamu
        /// </summary>
        /// <param name="range">Zoznam poloziek na vymazanie</param>
        /// <returns></returns>
        public RequestResult<List<Race>> RemoveRange(List<Race> range)
        {

            try
            {
                _context.Races.RemoveRange(range);
                _context.SaveChanges();
                return new RequestResult<List<Race>> { Status = Enums.RequestStatus.Success, Message = "Záznami úspešne odstránené.", Data = range };
            }
            catch (Exception ex)
            {
                return new RequestResult<List<Race>> { Status = Enums.RequestStatus.Error, Message = "Záznamy sa nepodarilo odstrániť.", Detail = ex.Message };
            }
        }

        public RequestResult<bool> IsValidName(Race item)
        {
            if (item.name == null)
                return new RequestResult<bool> {
                    Status = Enums.RequestStatus.Error,
                    Message = "Nezadali ste názov udalosti.\n"
                };
            if (item.name.Length < 3 || item.name.Length > 255)
                return new RequestResult<bool> {
                    Status = Enums.RequestStatus.Error,
                    Message = "Názov udalosti musí obsahovať 3 až 255 znakov.\n"
                };
            return new RequestResult<bool> { Status = Enums.RequestStatus.Success };
        }

        public RequestResult<bool> IsValidLocation(Race item)
        {
            if (item.location == null)
                return new RequestResult<bool>{
                    Status = Enums.RequestStatus.Error,
                    Message = "Nezadali ste miesto udalosti.\n"
                };
            if(item.location.Length < 3 || item.location.Length > 65535)
                return new RequestResult<bool>{
                    Status = Enums.RequestStatus.Error,
                    Message = "Miesto udalosti musí obsahovať 3 až 65535 znakov.\n"
                };
            return new RequestResult<bool>{ Status = Enums.RequestStatus.Success };
        }
        public RequestResult<bool> IsValidStartDate(Race item)
        {
            if (item.start_date == null)
                return new RequestResult<bool>
                {
                    Status = Enums.RequestStatus.Error,
                    Message = "Nezadali ste dátum začiatku udalosti.\n"
                };
            if (item.start_date < DateTime.Now.AddDays(-1))
                return new RequestResult<bool>
                {
                    Status = Enums.RequestStatus.Error,
                    Message = "Dátum začiatku udalosti môže byť maximálne 24 hodín späť od aktuálneho času.\n"
                };
            return new RequestResult<bool> { Status = Enums.RequestStatus.Success };
        }
    }
}
