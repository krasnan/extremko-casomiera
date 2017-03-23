using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using perfectTiming.Model;
using perfectTiming.Helpers;

namespace perfectTiming.Controller
{
    public class CompetitorController : ICompetitorController
    {
        public List<Competitor> Competitors { get { return _competitors; } set { _competitors = value; } }

        private List<Competitor> _competitors; //zoznam objektov
        private perfecttimingEntities _context; // context databazy

        /// <summary>
        /// Controller na spravu ucastnikov
        /// </summary>
        public CompetitorController()
        {
            _context = new perfecttimingEntities(); 
            _competitors = _context.Competitors.ToList(); 
        }

        public CompetitorController(List<Competitor> range)
        {
            _context = new perfecttimingEntities();
            _competitors = range;
        }

        /// <summary>
        /// Prida objekt do databazy a do zoznamu
        /// </summary>
        /// <param name="item">Objekty ktory ma byt pridany</param>
        /// <returns></returns>
        public RequestResult<Competitor> AddCompetitor(Competitor item)
        {
            try
            {
                _context.Competitors.Add(item);
                _context.SaveChanges();

                _competitors.Add(item);

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
        public RequestResult<Competitor> UpdateCompetitor(Competitor item)
        {
            try
            {
                _context.Competitors.Attach(item);
                var entry = _context.Entry(item);
                entry.State = System.Data.Entity.EntityState.Modified;
                _context.SaveChanges();


                //int index = _competitors.FindIndex(o => o.id == c.id);
                //if(index != -1)
                //    _competitors[index] = c;

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
        public RequestResult<Competitor> RemoveCompetitor(Competitor item)
        {
            try {
                _context.Competitors.Attach(item);
                _context.Competitors.Remove(item);
                _context.SaveChanges();

                _competitors.Remove(item);

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
                foreach(Competitor item in range)
                {
                    _competitors.Remove(item);
                }
                return new RequestResult<List<Competitor>> { Status = Enums.RequestStatus.Success, Message = "Záznami úspešne odstránené.", Data = range};
            }
            catch (Exception ex)
            {
                return new RequestResult<List<Competitor>> { Status = Enums.RequestStatus.Error, Message = "Záznamy sa nepodarilo odstrániť.", Detail = ex.Message };
            }
        }
    }
}
