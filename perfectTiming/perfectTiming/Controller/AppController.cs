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
        public perfecttimingEntities Context;
        public RaceController RaceController;
        public CompetitorController CompetitorController;
        public CategoryController CategoryController;
        public RegistrationController RegistrationController;
        public TimingController TimingController;

        public AppController()
        {
            Context = new perfecttimingEntities();

            RaceController = new RaceController(ref Context);
            CompetitorController = new CompetitorController(ref Context);
            CategoryController = new CategoryController(ref Context);
            RegistrationController = new RegistrationController(ref Context);
            TimingController = new TimingController(ref Context);

        }

        private static AppController _instance;

        public static AppController Instance
        {
            get
            {
                if( _instance == null)
                {
                    _instance = new AppController();
                }
                return _instance;
            }
        }
    }

}
