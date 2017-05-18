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

namespace perfectTiming.View
{

    public partial class ucDashboard : MetroFramework.Controls.MetroUserControl
    {
        public ucDashboard()
        {
            InitializeComponent();
            tCurrentTime.Text = DateTime.Now.ToString("dd-MMM-yyyy \n HH:mm:ss");
            Task.Factory.StartNew(() =>
            {
                System.Threading.Thread.Sleep(50);
            });


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tCurrentTime.Text = DateTime.Now.ToString("dd-MMM-yyyy \n HH:mm:ss");
        }

        private void tStart_Click(object sender, EventArgs e)
        {
            MainView.Instance.SetUserControll(new ucStart(), Name);
            MainView.Instance.LastUserControll.Push(Name);
        }

        private void tSettings_Click(object sender, EventArgs e)
        {



            ////-------------
            //using (_Views.frmPassword frm = new _Views.frmPassword("Nastavenia: Zadajte heslo", Rights.Settings))
            //{
            //    if (frm.ShowDialog() == DialogResult.OK)
            //    {
            //        ActualSettings.LastUserControll.Push(Name);
            //        ucSettings uc = new ucSettings(frm.SelectedUser);
            //        uc.Dock = DockStyle.Fill;
            //        ActualSettings.ActualUserControll = uc.Name;
            //        MainView.Instance.MetroContainer.Controls.RemoveByKey(uc.Name);
            //        MainView.Instance.MetroContainer.Controls.Add(uc);
            //        MainView.Instance.MetroContainer.Controls[uc.Name].BringToFront();
            //        MainView.Instance.MetroDateTime.Visible = true;
            //        MainView.Instance.MetroBack.Visible = true;
            //    }
            //}
        }

        private void tRaces_Click(object sender, EventArgs e)
        {
            MainView.Instance.SetUserControll(new ucRace(), Name);
        }

        private void tQuit_Click(object sender, EventArgs e)
        {
            MainView.Instance.Close();
        }

        private void tResults_Click(object sender, EventArgs e)
        {

        }

        private void tCompetitors_Click(object sender, EventArgs e)
        {
            MainView.Instance.SetUserControll(new ucCompetitor(), Name);
        }

        private void tCategories_Click(object sender, EventArgs e)
        {
            MainView.Instance.SetUserControll(new ucCategory(), Name);

        }

        private void tRegistrations_Click(object sender, EventArgs e)
        {

        }
    }
}
