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
using System.Reflection;

namespace perfectTiming.View
{
    public partial class ucRegistration : MetroFramework.Controls.MetroUserControl
    {
        private AppController app;
        private List<Category> categories;
        private List<Race> races;
        private List<Competitor> competitors;
        private List<Registration> registrations;
        public ucRegistration()
        {
            InitializeComponent();
            app = AppController.Instance;

            categories = app.CategoryController.Categories;
            races = app.RaceController.Races;
            registrations = app.RegistrationController.Registrations;

            bsRaces.DataSource = races;
            dataGridView_SelectionChanged(null, null);
        }

        private void cmbRaces_SelectedValueChanged(object sender, EventArgs e)
        {
            if (categories != null && cmbRaces.SelectedItem != null)
            {
                var result = categories.Where(c => c.race_id == ((Race)cmbRaces.SelectedItem).id).ToList();
                bsCategory.DataSource = (result.Count() > 0) ? result : null;
                dataGridView.Refresh();
            }
        }

        private void cmbCategories_SelectedValueChanged(object sender, EventArgs e)
        {
            if(registrations != null && cmbCategories.SelectedItem != null && cmbRaces.SelectedItem != null)
            {
                bsItems.DataSource = registrations.Where(r => r.Category.race_id == ((Race)cmbRaces.SelectedItem).id && r.category_id == ((Category)cmbCategories.SelectedItem).id);
                dataGridView.ClearSelection();
                dataGridView.Refresh();
            }
        }
        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = (dataGridView.SelectedRows.Count > 0);
            btnEdit.Enabled = (dataGridView.SelectedRows.Count == 1);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Registration item = new Registration();


            if(cmbCategories.SelectedItem != null)
                item.Category = (Category)cmbCategories.SelectedItem;

            //if (cmbRaces.SelectedItem != null)
            //    item.Category.Race = (Race)cmbRaces.SelectedItem;

            using (frmRegistrationEditorView frm = new frmRegistrationEditorView(item))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    RequestResult<Registration> result = app.RegistrationController.Add(item);
                    if (result.Status == Enums.RequestStatus.Success)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Registrácia úspešne vložená", "Registrácia vložená", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bsItems.DataSource = app.CategoryController.Categories;
                        dataGridView.Refresh();
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, result.Message, "Chyba: Nastala chyba pri ukladaní", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            Registration item = (Registration)dataGridView.CurrentRow.DataBoundItem;
            if (item != null)
            {
                using (frmRegistrationEditorView frm = new frmRegistrationEditorView(item))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        RequestResult<Registration> result = app.RegistrationController.Update(item);
                        if (result.Status == Enums.RequestStatus.Success)
                        {
                            dataGridView.Refresh();
                            MetroFramework.MetroMessageBox.Show(this, "Registrácia úspešne upravená", "Registrácia upravená", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }else
                            MetroFramework.MetroMessageBox.Show(this, result.Message, "Chyba: Nastala chyba pri ukladaní", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
                return;
            if (MetroFramework.MetroMessageBox.Show(this, "Naozaj chcete vymazať označené kategórie?", "Vyazať označené položky?", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
                return;


            foreach (DataGridViewRow r in dataGridView.SelectedRows)
            {
                Registration item = (Registration)r.DataBoundItem;
                app.RegistrationController.Remove(item);
            }
            dataGridView.Refresh();
            //bsItems.DataSource = app.CategoryController.Categories;
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            DataGridViewRow row = grid.Rows[e.RowIndex];
            DataGridViewColumn col = grid.Columns[e.ColumnIndex];
            if (row.DataBoundItem != null && col.DataPropertyName.Contains("."))
            {
                string[] props = col.DataPropertyName.Split('.');
                PropertyInfo propInfo = row.DataBoundItem.GetType().GetProperty(props[0]);
                if (propInfo == null)
                    return;
                object val = propInfo.GetValue(row.DataBoundItem, null);
                for (int i = 1; i < props.Length; i++)
                {
                    propInfo = val.GetType().GetProperty(props[i]);
                    val = propInfo.GetValue(val, null);
                }
                e.Value = val;
            }
        }
    }
}
