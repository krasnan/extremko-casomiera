using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using perfectTiming.Model;
using perfectTiming.Helpers;


namespace perfectTiming.Controller
{
    public class TimingController : ITimingController
    {
        public List<Timing> Timings { get { return _timings; } set { _timings = value; } }

        private List<Timing> _timings;           //zoznam merani
        private perfecttimingEntities _context; // context databazy

        public TimingController()
        {

            _context = new perfecttimingEntities();
            _timings = _context.Timings.ToList();

        }

        public TimingController(List<Timing> range)
        {
            _context = new perfecttimingEntities();
            _timings = range;
        }

        /// <summary>
        /// Prida záznam o meradní do databazy a do zoznamu
        /// </summary>
        /// <param name="item">Meranie ktore má byt pridané</param>
        /// <returns></returns>
        public RequestResult<Timing> Add(Timing item)
        {

            try
            {
                _context.Timings.Add(item);
                _timings.Add(item);

                return new RequestResult<Timing> { Status = Enums.RequestStatus.Success, Message = "Čas bola pridaný", Data = item };
            }
            catch (Exception ex )
            {
                return new RequestResult<Timing> { Status = Enums.RequestStatus.Error, Message = "Čas sa nepodarilo pridať", Detail = ex.Message };
            }
            throw new NotImplementedException();
        }

        /// <summary>
        /// Odstráni záznam o meraní
        /// </summary>
        /// <param name="item">Meranie ktoré ma byt vymazane</param>
        /// <returns></returns>
        public RequestResult<Timing> Remove(Timing item)
        {
            try
            {
                _context.Timings.Attach(item);
                _context.Timings.Remove(item);
                _timings.Remove(item);

                return new RequestResult<Timing> { Status = Enums.RequestStatus.Success, Message = "Kategória vymazaná", Data = item };
            }
            catch (Exception ex)
            {
                return new RequestResult<Timing> { Status = Enums.RequestStatus.Error, Message = "Kategória nebola vymazaná", Detail = ex.Message };

            }
        }
        /// <summary>
        /// Upraví záznam o meraní
        /// </summary>
        /// <param name="item">Meranie ktoré ma byt upravené</param>
        public RequestResult<Timing> Update(Timing item)
        {
            try
            {
                int index = _timings.FindIndex(o => o.id == item.id);
                if (index != -1){
                    _context.Timings.Attach(item);
                    var entry = _context.Entry(item);
                    entry.State = System.Data.Entity.EntityState.Modified;
                    _timings[index] = item;
                }
                else
                {
                    throw new Exception();
                }
                return new RequestResult<Timing> { Status = Enums.RequestStatus.Success, Message = "Čas upravený", Data = item };
            }
            catch (Exception ex)
            { 
                return new RequestResult<Timing> { Status = Enums.RequestStatus.Error, Message = "Čas nebol upravený", Detail = ex.Message };
            }
        }
    }
}
