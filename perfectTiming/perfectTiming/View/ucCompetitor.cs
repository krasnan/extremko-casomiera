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
                        dataGridView.ClearSelection();
                        dataGridView.Refresh();
                        MetroFramework.MetroMessageBox.Show(this, "", "Operácia úspešná.", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    dataGridView.ClearSelection();
                    dataGridView.Refresh();
                    MetroFramework.MetroMessageBox.Show(this, "", "Operácia úspešná.", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            dataGridView.ClearSelection();
            dataGridView.Refresh();
        }
        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = (dataGridView.SelectedRows.Count > 0);
            btnEdit.Enabled = (dataGridView.SelectedRows.Count == 1);

  
        }
    }
}
