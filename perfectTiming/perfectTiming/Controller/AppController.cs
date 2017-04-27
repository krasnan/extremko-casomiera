using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using perfectTiming.Model;
using perfectTiming.Helpers;


namespace perfectTiming.Controller
{
   public class AppController
    {
        private perfecttimingEntities _context;
        public RaceController RaceController;
        public CompetitorController CompetitorController;
        public CategoryController CategoryController;
        public RegistrationController RegistrationController;
        public TimingController TimingController;
    
        public AppController()
        {
            _context = new perfecttimingEntities();

            RaceController = new RaceController(ref _context);
            CompetitorController = new CompetitorController();
            CategoryController = new CategoryController();
            RegistrationController = new RegistrationController();
            TimingController = new TimingController();

        }
   
    }
}
