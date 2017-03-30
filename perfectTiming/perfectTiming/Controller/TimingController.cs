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
            throw new NotImplementedException();
        }

        /// <summary>
        /// Odstráni záznam o meraní
        /// </summary>
        /// <param name="item">Meranie ktoré ma byt vymazane</param>
        /// <returns></returns>
        public RequestResult<Timing> Remove(Timing item)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Upraví záznam o meraní
        /// </summary>
        /// <param name="item">Meranie ktoré ma byt upravené</param>
        public RequestResult<Timing> Update(Timing item)
        {
            throw new NotImplementedException();
        }
    }
}
