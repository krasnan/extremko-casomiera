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

namespace perfectTiming.View
{
    public partial class ucTiming : MetroFramework.Controls.MetroUserControl
    {

        Stopwatch stopwatch;
        //Chybne zadanie cisla
        bool incorrectInput = false;
        double lastCorrectTime;
        string lastCas;


        public ucTiming()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();




        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            // Pauza Button
            stopwatch.Stop();
            timer1.Stop();
            metroTile1.Enabled = true;
            metroTile2.Enabled = true;
            metroTile3.Enabled = false;

            metroTile1.Text = "Pokracuj";
        }

        // Start Button
        private void metroTile1_Click(object sender, EventArgs e)
        {



            // Vycistenie policka pre zadavanie cisel
            metroTextBox1.Text = "";
            metroTextBox1.Focus();
            stopwatch.Start();

            // Prepnutie tlacidiel
            metroTile1.Enabled = false;
            metroTile2.Enabled = true;
            metroTile3.Enabled = true;


            // Zmenit statusu preteku
            // TODO: Upravit v liste pretekov

        }

        // Koniec button
        private void metroTile2_Click(object sender, EventArgs e)
        {
            DialogResult result = MetroMessageBox.Show(this,"Chcete naozaj ukočiť časovanie preteku ??", "Pozor !!!!", MessageBoxButtons.YesNo);
            if (!(result == DialogResult.Yes))
            {
                return;
            }

            stopwatch.Stop();
            timer1.Stop();
            stopwatch = new Stopwatch();
            labelTimer.Text= "00:00:00.000";

            metroTile2.Enabled = false;
            metroTile3.Enabled = false;



            // Update stavu zavodu na ukonceny
            // TODO: zmenti stav preteku


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = stopwatch.Elapsed;
            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            labelTimer.Text = elapsedTime;

        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {


                int cislo;

                // kontrola ci bolo startovne cislo zadane do texboxu v spravnom tvare a to teda ako integer
                if (int.TryParse(metroTextBox1.Text, out cislo) == false)
                {

                    labelResult.ForeColor = System.Drawing.Color.Red;
                    labelResult.Text = "Chyba vstupu!! Vstupy môžu byť iba čísla !!";
                    metroTextBox1.Text = "";
                    metroTextBox1.Focus();
                    return;
                }


                TimeSpan ts = stopwatch.Elapsed;
                String cas = String.Format("{0:00}:{1:00}:{2:00}.{3:000}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);

                double times = ts.TotalMilliseconds;

                // Ak vsetko oki pridaj to do vysledkov

            }
        


         

        }

    }
}
