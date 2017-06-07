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

            if (!app.CompetitorController.IsValidName(comp))
                lblErrorHolder.Text += "Neplatné meno (môže obsahovať iba znaky abecedy).\n";
            
            if (!app.CompetitorController.IsValidBirthDate(comp))
                lblErrorHolder.Text += "Neplatný dátum narodenia.\n";
            
            if (!app.CompetitorController.IsValidEmial(comp))
                lblErrorHolder.Text += "Neplatný formát emailovej adresy.\n";
            
            if (!app.CompetitorController.IsValidPhone(comp))
                lblErrorHolder.Text += "Neplatný formát telefónneho čísla. (+421.........)\n";

            if (lblErrorHolder.Text == "")
                this.DialogResult = DialogResult.OK;
        }
    }
}
