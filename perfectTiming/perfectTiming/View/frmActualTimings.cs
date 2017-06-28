using perfectTiming.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace perfectTiming.View
{
    public partial class frmActualTimings : MetroFramework.Forms.MetroForm
    {
        private AppController app;
        public frmActualTimings()
        {
            app= AppController.Instance;
            InitializeComponent();
            bsTimings.DataSource = app.TimingController.TimingsLocal;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = app.TimingController.ElapsedTime;
            bsTimings.DataSource = app.TimingController.TimingsLocal;
        }
        private void gridActualResults_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
