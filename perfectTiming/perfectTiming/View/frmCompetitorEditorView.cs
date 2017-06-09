using perfectTiming.Controller;
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

namespace perfectTiming.View
{
    public partial class frmCompetitorEditorView : MetroFramework.Forms.MetroForm
    {
        private AppController app = AppController.Instance;
        public frmCompetitorEditorView(Competitor item)
        {
            InitializeComponent();
            bsItem.DataSource = item;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Competitor comp = (Competitor)bsItem.Current;
            lblErrorHolder.Text = "";

            lblErrorHolder.Text += app.CompetitorController.IsValidName(comp).Message;
            lblErrorHolder.Text += app.CompetitorController.IsValidBirthDate(comp).Message;
            lblErrorHolder.Text += app.CompetitorController.IsValidEmial(comp).Message;
            lblErrorHolder.Text += app.CompetitorController.IsValidPhone(comp).Message;

            if (lblErrorHolder.Text == "")
                this.DialogResult = DialogResult.OK;
        }
    }
}
