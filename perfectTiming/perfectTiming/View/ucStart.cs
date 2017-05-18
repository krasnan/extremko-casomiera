using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using perfectTiming.Controller;
using perfectTiming.Model;
using perfectTiming.Helpers;

namespace perfectTiming.View
{
    public partial class ucStart : MetroFramework.Controls.MetroUserControl
    {
        AppController app;
        public ucStart()
        {
            InitializeComponent();
            app = AppController.Instance;
            bsRaces.DataSource = app.RaceController.Races;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Race race = (Race)cmbRace.SelectedItem;
            if (race == null)
            {
                lblErrorHolder.Text = "Nevybrali ste pretek";
            }
            else if (race.status == (int)Enums.RaceStatus.Ended)
            {
                lblErrorHolder.Text = "Udalosť bola ukončená.";
            }
            else if (race.status == (int)Enums.RaceStatus.Started)
            {
                lblErrorHolder.Text = "Udalosť bola odštartovaná.";
            }
            else
            {
                lblErrorHolder.Text = "";
                MainView.Instance.SetUserControll(new ucTimer(race), Name);
            }

        }
    }
}
