namespace perfectTiming.View
{
    partial class frmActualTimings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTimer = new System.Windows.Forms.Label();
            this.gridActualResults = new MetroFramework.Controls.MetroGrid();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Registration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lapnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laptimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laptimestampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTimings = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridActualResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTimings)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTimer.Location = new System.Drawing.Point(7, 60);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(394, 86);
            this.lblTimer.TabIndex = 12;
            this.lblTimer.Text = "00:00:00.000";
            // 
            // gridActualResults
            // 
            this.gridActualResults.AllowUserToAddRows = false;
            this.gridActualResults.AllowUserToDeleteRows = false;
            this.gridActualResults.AllowUserToResizeRows = false;
            this.gridActualResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridActualResults.AutoGenerateColumns = false;
            this.gridActualResults.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridActualResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridActualResults.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridActualResults.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridActualResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridActualResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridActualResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Registration,
            this.dataGridViewTextBoxColumn2,
            this.lapnumberDataGridViewTextBoxColumn,
            this.laptimeDataGridViewTextBoxColumn,
            this.laptimestampDataGridViewTextBoxColumn});
            this.gridActualResults.DataSource = this.bsTimings;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridActualResults.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridActualResults.EnableHeadersVisualStyles = false;
            this.gridActualResults.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridActualResults.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridActualResults.Location = new System.Drawing.Point(22, 148);
            this.gridActualResults.Margin = new System.Windows.Forms.Padding(2);
            this.gridActualResults.Name = "gridActualResults";
            this.gridActualResults.ReadOnly = true;
            this.gridActualResults.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridActualResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridActualResults.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridActualResults.RowTemplate.Height = 24;
            this.gridActualResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridActualResults.Size = new System.Drawing.Size(1284, 566);
            this.gridActualResults.TabIndex = 13;
            this.gridActualResults.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridActualResults_CellFormatting);
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Registration.start_number";
            this.dataGridViewTextBoxColumn1.HeaderText = "Štartovné čílo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Registration
            // 
            this.Registration.DataPropertyName = "Registration.Competitor.name";
            this.Registration.HeaderText = "Účastník";
            this.Registration.Name = "Registration";
            this.Registration.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Registration.Category.name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Kategória";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // lapnumberDataGridViewTextBoxColumn
            // 
            this.lapnumberDataGridViewTextBoxColumn.DataPropertyName = "lap_number";
            this.lapnumberDataGridViewTextBoxColumn.HeaderText = "Kolo č.";
            this.lapnumberDataGridViewTextBoxColumn.Name = "lapnumberDataGridViewTextBoxColumn";
            this.lapnumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // laptimeDataGridViewTextBoxColumn
            // 
            this.laptimeDataGridViewTextBoxColumn.DataPropertyName = "lap_time";
            this.laptimeDataGridViewTextBoxColumn.HeaderText = "Čas Kola(ms)";
            this.laptimeDataGridViewTextBoxColumn.Name = "laptimeDataGridViewTextBoxColumn";
            this.laptimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // laptimestampDataGridViewTextBoxColumn
            // 
            this.laptimestampDataGridViewTextBoxColumn.DataPropertyName = "lap_timestamp";
            this.laptimestampDataGridViewTextBoxColumn.HeaderText = "Celkový čas(ms)";
            this.laptimestampDataGridViewTextBoxColumn.Name = "laptimestampDataGridViewTextBoxColumn";
            this.laptimestampDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsTimings
            // 
            this.bsTimings.DataSource = typeof(perfectTiming.Model.Timing);
            // 
            // frmActualTimings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 736);
            this.Controls.Add(this.gridActualResults);
            this.Controls.Add(this.lblTimer);
            this.Name = "frmActualTimings";
            this.Text = "Priebežné výsledky";
            ((System.ComponentModel.ISupportInitialize)(this.gridActualResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTimings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimer;
        private MetroFramework.Controls.MetroGrid gridActualResults;
        private System.Windows.Forms.BindingSource bsTimings;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Registration;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn lapnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn laptimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn laptimestampDataGridViewTextBoxColumn;
    }
}