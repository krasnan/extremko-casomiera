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
    public partial class ucCategory : MetroFramework.Controls.MetroUserControl
    {
        private AppController app;
        public ucCategory()
        {
            this.AccessibleName = " - Zoznam Kategórií";
            InitializeComponent();
            app = AppController.Instance;
            bsItems.DataSource = app.CategoryController.Categories;
            dataGridView_SelectionChanged(null, null);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Category item = (Category)dataGridView.CurrentRow.DataBoundItem;
            if (item != null)
            {
                using (frmCategoryEditorView frm = new frmCategoryEditorView(item))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        RequestResult<Category> result = app.CategoryController.Update(item);
                        if (result.Status == Enums.RequestStatus.Success)
                            MetroFramework.MetroMessageBox.Show(this, "Kategória úspešne upravená", "Kategória upravená", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        else
                            MetroFramework.MetroMessageBox.Show(this, result.Message, "Chyba: Nastala chyba pri ukladaní", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category item = new Category();
            using (frmCategoryEditorView frm = new frmCategoryEditorView(item))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    RequestResult<Category> result = app.CategoryController.Update(item);
                    if (result.Status == Enums.RequestStatus.Success)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Kategória úspešne vložená", "Kategória vložená", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bsItems.DataSource = app.CategoryController.Categories;
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
            if (MetroFramework.MetroMessageBox.Show(this, "Naozaj chcete vymazať označené kategórie?", "Vyazať označené položky?", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
                return;


            foreach (DataGridViewRow r in dataGridView.SelectedRows)
            {
                Category item = (Category)r.DataBoundItem;
                app.CategoryController.Remove(item);
            }

            bsItems.DataSource = app.CategoryController.Categories;
        }
        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = (dataGridView.SelectedRows.Count > 0);
            btnEdit.Enabled = (dataGridView.SelectedRows.Count == 1);
        }
    }
}
