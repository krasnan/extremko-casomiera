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
        private RaceController ctrl;
        public ucRace()
        {


            InitializeComponent();
            ctrl = new RaceController();
            bsRaces.DataSource = ctrl.Races;
        }
        private void ucRace_Load(object sender, EventArgs e)
        {

        }
        private void btnEditItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
                return;
            if (MetroFramework.MetroMessageBox.Show(this, "Naozaj chcete vymazať označené artikle?", "Vyazať označené položky?", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
                return;

            

            foreach (DataGridViewRow r in dataGridView.SelectedRows)
            {
                ctrl.Remove((Race)r.DataBoundItem);
                bsRaces.DataSource = ctrl.Races;
                    //long actId = (long)r.Cells[0].Value;
                    //var item = new _Model.Item { Id = actId };
                    //db.Items.Attach(item);
                    //db.Items.Remove(item);
            }
                //db.SaveChanges();
                //bsItems.DataSource = db.Items.ToList();
            
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = (dataGridView.SelectedRows.Count > 0);
            btnEdit.Enabled = (dataGridView.SelectedRows.Count == 1);
        }
    }
}
