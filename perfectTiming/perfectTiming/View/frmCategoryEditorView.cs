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
    public partial class frmCategoryEditorView : MetroFramework.Forms.MetroForm
    {
        private AppController app = AppController.Instance;
        public frmCategoryEditorView(Category item)
        {
            InitializeComponent();
            bsItem.DataSource = item;
            bsRaces.DataSource = AppController.Instance.RaceController.Races;
            cmbRaces.SelectedItem = item.Race;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            Category cat = (Category)bsItem.Current;

            RequestResult<Category> result;
            if (cat.id != 0)
                result = app.CategoryController.Update(cat);
            else
                result = app.CategoryController.Add(cat);
            if (result.Status == Enums.RequestStatus.Success)
                this.DialogResult = DialogResult.OK;

            else
                lblErrorHolder.Text = result.Detail;
        }
    }
}
