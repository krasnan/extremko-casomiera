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
using System.Reflection;

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
            bsTimings.DataSource = app.TimingController.Timings;
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
            addTiming();
        }

        private void txtNumber_KeyDown(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13) // Enter key pressed
            {
                addTiming();
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void addTiming()
        {

            Timing item;

            int start_number = Int32.Parse(txtNumber.Text);
            TimeSpan ts = stopwatch.Elapsed;

            Registration reg = registrations.FirstOrDefault(r => r.start_number == start_number);

            if(reg == null)
            {
                Console.WriteLine("Zle cislo");
            }
            else
            {
                Timing last = reg.Timings.LastOrDefault();
                if (last == null)
                    last = new Timing { lap_number = 0, lap_time = 0, Registration = reg, registration_id = reg.id };

                item = new Timing
                {
                    lap_number = last.lap_number + 1,
                    lap_time = ts.TotalMilliseconds - last.lap_time,
                    Registration = reg,
                    registration_id = reg.id
                };
                app.TimingController.Add(item);
                bsTimings.DataSource = app.TimingController.Timings;
                gridActualResults.FirstDisplayedScrollingRowIndex = gridActualResults.RowCount - 1;
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


        private void gridActualResults_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            DataGridView grid = (DataGridView)sender;
            DataGridViewRow row = grid.Rows[e.RowIndex];
            DataGridViewColumn col = grid.Columns[e.ColumnIndex];
            if (row.DataBoundItem != null && col.DataPropertyName.Contains("."))
            {
                string[] props = col.DataPropertyName.Split('.');
                PropertyInfo propInfo = row.DataBoundItem.GetType().GetProperty(props[0]);
                if (propInfo == null)
                    return;
                object val = propInfo.GetValue(row.DataBoundItem, null);
                for (int i = 1; i < props.Length; i++)
                {
                    propInfo = val.GetType().GetProperty(props[i]);
                    val = propInfo.GetValue(val, null);
                }
                e.Value = val;
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
