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
using perfectTiming.Model;
namespace perfectTiming.View
{
    public partial class frmRacesEditorView : MetroFramework.Forms.MetroForm
    {
        private AppController app = AppController.Instance;
        public frmRacesEditorView(Race item)
        {
            
            InitializeComponent();
            bsItem.DataSource = item;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            lblErrorHolder.Text = "";
            Race r = (Race)bsItem.Current;
            
            lblErrorHolder.Text += app.RaceController.IsValidName(r).Message;
            lblErrorHolder.Text += app.RaceController.IsValidLocation(r).Message;
            lblErrorHolder.Text += app.RaceController.IsValidStartDate(r).Message;

            if (lblErrorHolder.Text == "")
                this.DialogResult = DialogResult.OK;
        }

    }
}
