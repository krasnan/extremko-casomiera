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
using perfectTiming.Helpers;
using perfectTiming.Model;

namespace perfectTiming.View
{
    public partial class ucRace : MetroFramework.Controls.MetroUserControl
    {
        private AppController app;
        public ucRace()
        {


            InitializeComponent();
            app = AppController.Instance;
            bsRaces.DataSource = app.RaceController.Races;
            dataGridView_SelectionChanged(null, null);
        }
        private void ucRace_Load(object sender, EventArgs e)
        {

        }
        private void btnEditItem_Click(object sender, EventArgs e)
        {
            Race item = (Race)dataGridView.CurrentRow.DataBoundItem;
            if (item != null)
            {
                using (frmRacesEditorView frm = new frmRacesEditorView(item))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        bsRaces.DataSource = app.RaceController.Races;
                        dataGridView.Refresh();
                        MetroFramework.MetroMessageBox.Show(this, "", "Operácia úspešná.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            Race item = new Race();
            item.status = (int)Enums.RaceStatus.NotStarted;

            using (frmRacesEditorView frm = new frmRacesEditorView(item))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    bsRaces.DataSource = app.RaceController.Races;
                    dataGridView.Refresh();

                    MetroFramework.MetroMessageBox.Show(this, "", "Operácia úspešná.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
                return;
            if (MetroFramework.MetroMessageBox.Show(this, "Naozaj chcete vymazať označené udalosti?", "Vyazať označené položky?", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
                return;

            

            foreach (DataGridViewRow r in dataGridView.SelectedRows)
            {
                Race item = (Race)r.DataBoundItem;
                app.RaceController.Remove(item);
                    //long actId = (long)r.Cells[0].Value;
                    //var item = new _Model.Item { Id = actId };
                    //db.Items.Attach(item);
                    //db.Items.Remove(item);
            }

            bsRaces.DataSource = app.RaceController.Races;
            //db.SaveChanges();
            //bsItems.DataSource = db.Items.ToList();
            dataGridView.Refresh();

        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = (dataGridView.SelectedRows.Count > 0);
            btnEdit.Enabled = (dataGridView.SelectedRows.Count == 1);
            dataGridView.Refresh();
        }
    }
}
