using perfectTiming.Controller;
using perfectTiming.Helpers;
using perfectTiming.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Deployment.Application;
using System.Reflection;

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
            
            Race r = (Race)bsItem.Current;

            RequestResult<Race> result;
            if (r.id != 0)
                result = app.RaceController.Update(r);
            else
                result = app.RaceController.Add(r);
            if (result.Status == Enums.RequestStatus.Success)
                this.DialogResult = DialogResult.OK;

            else
                lblErrorHolder.Text = result.Detail;
        }

    }
}
