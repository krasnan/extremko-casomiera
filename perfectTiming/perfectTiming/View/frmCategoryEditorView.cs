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
        public frmCategoryEditorView(Category item)
        {
            InitializeComponent();
            bsItem.DataSource = item;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //TODO overenie a nastavenie chybovych hlasok to lblErrorHolder.Text = "...";
        }
    }
}
