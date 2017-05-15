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
    }
    
}
