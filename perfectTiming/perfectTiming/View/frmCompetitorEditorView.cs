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
            RequestResult<Competitor> result;
            if (comp.id != 0)
                result = app.CompetitorController.Update(comp);
            else
                result = app.CompetitorController.Add(comp);
            if (result.Status == Enums.RequestStatus.Success)
                this.DialogResult = DialogResult.OK;

            else
                lblErrorHolder.Text = result.Detail;
        }
    }
}
