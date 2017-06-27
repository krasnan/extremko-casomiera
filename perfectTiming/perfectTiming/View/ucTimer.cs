using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MetroFramework;
using perfectTiming.Model;
using perfectTiming.Controller;
using perfectTiming.Helpers;

namespace perfectTiming.View
{
    public partial class ucTimer : MetroFramework.Controls.MetroUserControl
    {
        AppController app = AppController.Instance;
        Stopwatch stopwatch;
        //Chybne zadanie cisla
        bool incorrectInput = false;
        double lastCorrectTime;
        string lastCas;

        private List<Registration> registrations;
        Race race;

        public ucTimer(Race race)
        {

            this.race = race;
            app = AppController.Instance;
            registrations = app.RegistrationController.GetRegistrations(race).Data;


            InitializeComponent();
            stopwatch = new Stopwatch();
            btnStart.Enabled = true;
            btnPause.Enabled = false;
            btnStop.Enabled = false;
            btnAdd.Enabled = false;
            txtNumber.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            TimeSpan ts = stopwatch.Elapsed;
            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            lblTimer.Text = elapsedTime;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            Timing item;
            int cislo_jazdca = Int32.Parse(txtNumber.Text);
            RequestResult<Registration> reg = app.RegistrationController.GetRegistration(race, cislo_jazdca);
           // Registration pom =  ;
          
            if (reg.Status == Enums.RequestStatus.Success)
            {
                TimeSpan ts = stopwatch.Elapsed;

                item = registrations.FirstOrDefault(re => re.start_number == cislo_jazdca).Timings.FirstOrDefault();
                item.lap_number++;
                item.lap_time = ts.TotalMilliseconds - item.lap_time;

                app.TimingController.Add(item);
            }
            else
            {
                // Ak napriklad je vlozene cislo ktore nieje na preteku
                Console.WriteLine("Zle vstupne cislo");
            }
            txtNumber.Text = "";
            txtNumber.Focus();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            btnStart.Enabled = false;
            btnPause.Enabled = true;
            btnStop.Enabled = true;
            btnAdd.Enabled = true;
            txtNumber.Enabled = true;
            txtNumber.Text = "";
            txtNumber.Focus();

          // re app.RegistrationController.GetRegistrations(race);


            stopwatch.Start();
            timer1.Start();
            
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnPause.Enabled = false;
            btnStop.Enabled = true;
            txtNumber.Enabled = false;
            stopwatch.Stop();
            timer1.Stop();
            txtNumber.Focus();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnPause.Enabled = false;
            btnStop.Enabled = false;
            txtNumber.Enabled = false;
            stopwatch.Stop();
            stopwatch.Reset();

            timer1.Stop();
            timer1_Tick(null, null);
        }

        private void txtNumber_KeyDown(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13) // Enter key pressed
            {
                Timing item;
                int cislo_jazdca = Int32.Parse(txtNumber.Text);
                RequestResult<Registration> reg = app.RegistrationController.GetRegistration(race, cislo_jazdca);

                if (reg.Status == Enums.RequestStatus.Success)
                {
                    TimeSpan ts = stopwatch.Elapsed;

                    item = reg.Data.Timings.FirstOrDefault();
                    item.lap_number++;
                    item.lap_time = ts.TotalMilliseconds - item.lap_time;
                    app.TimingController.Add(item);
                }
                else
                {
                    // Ak napriklad je vlozene cislo ktore nieje na preteku
                    Console.WriteLine("Zle vstupne cislo");
                }
                txtNumber.Text = "";
                txtNumber.Focus();
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }



        }

        //private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == (char)Keys.Return)
        //    {


        //        int cislo;

        //        // kontrola ci bolo startovne cislo zadane do texboxu v spravnom tvare a to teda ako integer
        //        if (int.TryParse(metroTextBox1.Text, out cislo) == false)
        //        {

        //            labelResult.ForeColor = System.Drawing.Color.Red;
        //            labelResult.Text = "Chyba vstupu!! Vstupy môžu byť iba čísla !!";
        //            metroTextBox1.Text = "";
        //            metroTextBox1.Focus();
        //            return;
        //        }


        //        TimeSpan ts = stopwatch.Elapsed;
        //        String cas = String.Format("{0:00}:{1:00}:{2:00}.{3:000}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);

        //        double times = ts.TotalMilliseconds;

        //        // Ak vsetko oki pridaj to do vysledkov

        //    }





        //}

    }
}
