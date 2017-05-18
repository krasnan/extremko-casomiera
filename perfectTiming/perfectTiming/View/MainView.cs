using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using perfectTiming.Controller;
using System.Deployment.Application;
using System.Reflection;

namespace perfectTiming.View
{
    public partial class MainView : MetroFramework.Forms.MetroForm
    {
        private static Stack<string> _lastUserControll = new Stack<string>();
        private static string _actualUserControll;



        public MainView()
        {
            //using (_Model.WeightControllEntities db = new _Model.WeightControllEntities())
            //{
            //    var items = db.Items.ToList();
            //    var cnt = items.Count;

            //}
            this.Text = "     PerfectTiming";
            InitializeComponent();



        }
        static MainView _instance;
        public static MainView Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MainView();
                return _instance;
            }
        }
        public MetroFramework.Controls.MetroPanel MetroContainer
        {
            get { return mPanel; }
            set { mPanel = value; }
        }
        public MetroFramework.Controls.MetroLink MetroBack
        {
            get { return btnBack; }
            set { btnBack = value; }
        }
        public MetroFramework.Controls.MetroLabel MetroDateTime
        {
            get { return lblDateTime; }
            set { lblDateTime = value; }
        }
        public string ActualUserControll
        {
            get { return _actualUserControll; }
            set { _actualUserControll = value; }
        }
        public Stack<string> LastUserControll
        {
            get { return _lastUserControll; }
            set { _lastUserControll = value; }
        }

        //public string CurrentVersion
        //{
        //    get
        //    {
        //        return ApplicationDeployment.IsNetworkDeployed
        //               ? ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()
        //               : Assembly.GetExecutingAssembly().GetName().Version.ToString();
        //    }
        //}
        private void MainView_Load(object sender, EventArgs e)
        {
            lblDateTime.Visible = false;
            btnBack.Visible = false;
            _instance = this;
            // System.Windows.Automation.AutomationElement.FromHandle(this.Handle);

            ucDashboard uc = new ucDashboard();
            uc.Dock = DockStyle.Fill;
            mPanel.Controls.Add(uc);

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (ActualUserControll == "ucTimer")
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Chcete ukončiť prácu s časovačom?", "Upozornenie.", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
                {
                    return;
                }
                mPanel.Controls[ActualUserControll].Dispose();
                mPanel.Controls.Remove(mPanel.Controls[ActualUserControll]);
            }
            string lastUcName = Instance.LastUserControll.Pop();
            ActualUserControll = lastUcName;
            mPanel.Controls[lastUcName].BringToFront();

            btnBack.Visible = Instance.LastUserControll.Count != 0;
            lblDateTime.Visible = Instance.LastUserControll.Count != 0;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString();
        }

        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Naozaj chcete ukončiť prácu s programom?", "Upozornenie.", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        public void SetUserControll(UserControl uc, string name)
        {
            Instance.LastUserControll.Push(name);
            uc.Dock = DockStyle.Fill;
            Instance.ActualUserControll = uc.Name;
            Instance.MetroContainer.Controls.RemoveByKey(uc.Name);
            Instance.MetroContainer.Controls.Add(uc);
            Instance.MetroContainer.Controls[uc.Name].BringToFront();
            Instance.MetroDateTime.Visible = true;
            Instance.MetroBack.Visible = true;
        }
    }
}
