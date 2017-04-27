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
            CompetitorController = new CompetitorController(ref _context);
            CategoryController = new CategoryController(ref _context);
            RegistrationController = new RegistrationController(ref _context);
            TimingController = new TimingController(ref _context);

        }

        public RequestResult<bool> SaveAll()
        {


            RaceController.Save();
            CompetitorController.Save();
            CategoryController.Save();
            RegistrationController.Save();
            TimingController.Save();


            return new RequestResult<bool> { Status = Enums.RequestStatus.Success, Message = "Všetky zmeny uložené", Data = true };
        }

    }

}
