using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using perfectTiming.Model;
using perfectTiming.Controller;
using perfectTiming.Helpers;

namespace perfectTiming.View
{
    public partial class ucCompetitor : MetroFramework.Controls.MetroUserControl
    {
        private AppController app;
        public ucCompetitor()
        {
            InitializeComponent();
            app = AppController.Instance;
            bsItems.DataSource = app.CompetitorController.Competitors;
            dataGridView_SelectionChanged(null, null);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Competitor item = (Competitor)dataGridView.CurrentRow.DataBoundItem;
            if (item != null)
            {
                using (frmCompetitorEditorView frm = new frmCompetitorEditorView(item))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        RequestResult<Competitor> result = app.CompetitorController.Update(item);
                        if (result.Status == Enums.RequestStatus.Success)
                            MetroFramework.MetroMessageBox.Show(this, "Účastník úspešne upravený", "Účastník upravený", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        else
                            MetroFramework.MetroMessageBox.Show(this, result.Message, "Chyba: Nastala chyba pri ukladaní", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Competitor item = new Competitor();
            using (frmCompetitorEditorView frm = new frmCompetitorEditorView(item))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    RequestResult<Competitor> result = app.CompetitorController.Add(item);
                    if (result.Status == Enums.RequestStatus.Success)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Účastník úspešne vložený", "Účastník vložený", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bsItems.DataSource = app.CompetitorController.Competitors;
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, result.Message, "Chyba: Nastala chyba pri ukladaní", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
                return;
            if (MetroFramework.MetroMessageBox.Show(this, "Naozaj chcete vymazať označených účastníkov?", "Vyazať označené položky?", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
                return;
            
        
            foreach (DataGridViewRow r in dataGridView.SelectedRows)
            {
                Competitor item = (Competitor)r.DataBoundItem;
                app.CompetitorController.Remove(item);
            }

            bsItems.DataSource = app.CompetitorController.Competitors;
        }
        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = (dataGridView.SelectedRows.Count > 0);
            btnEdit.Enabled = (dataGridView.SelectedRows.Count == 1);
        }
    }
}
