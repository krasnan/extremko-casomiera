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

        }

    }
}
