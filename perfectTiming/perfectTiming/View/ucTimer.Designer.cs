namespace perfectTiming.View
{
    partial class ucTimer
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

        #region Component Designer generated code

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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelResult = new MetroFramework.Controls.MetroLabel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnAdd = new MetroFramework.Controls.MetroTile();
            this.btnStop = new MetroFramework.Controls.MetroTile();
            this.btnPause = new MetroFramework.Controls.MetroTile();
            this.btnStart = new MetroFramework.Controls.MetroTile();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.gridActualResults = new MetroFramework.Controls.MetroGrid();
            this.bsTimings = new System.Windows.Forms.BindingSource(this.components);
            this.laptimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lapnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridActualResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTimings)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(257, 319);
            this.labelResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 0);
            this.labelResult.TabIndex = 10;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTimer.Location = new System.Drawing.Point(3, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(483, 106);
            this.lblTimer.TabIndex = 11;
            this.lblTimer.Text = "00:00:00.000";
            // 
            // btnAdd
            // 
            this.btnAdd.ActiveControl = null;
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(420, 506);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 185);
            this.btnAdd.Style = MetroFramework.MetroColorStyle.Green;
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Pridať";
            this.btnAdd.TileImage = global::perfectTiming.Properties.Resources.ic_library_add_white_36dp;
            this.btnAdd.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnAdd.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.UseStyleColors = true;
            this.btnAdd.UseTileImage = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnStop
            // 
            this.btnStop.ActiveControl = null;
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Location = new System.Drawing.Point(925, 506);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(200, 185);
            this.btnStop.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnStop.TabIndex = 14;
            this.btnStop.Text = "Koniec";
            this.btnStop.TileImage = global::perfectTiming.Properties.Resources.ic_power_settings_new_white_36dp;
            this.btnStop.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStop.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnStop.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnStop.UseSelectable = true;
            this.btnStop.UseStyleColors = true;
            this.btnStop.UseTileImage = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.ActiveControl = null;
            this.btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPause.Location = new System.Drawing.Point(925, 197);
            this.btnPause.Margin = new System.Windows.Forms.Padding(4);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(200, 185);
            this.btnPause.TabIndex = 13;
            this.btnPause.Text = "Pauza";
            this.btnPause.TileImage = global::perfectTiming.Properties.Resources.ic_pause_circle_outline_white_36dp;
            this.btnPause.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPause.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnPause.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnPause.UseSelectable = true;
            this.btnPause.UseStyleColors = true;
            this.btnPause.UseTileImage = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.ActiveControl = null;
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(925, 4);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(200, 185);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Štart";
            this.btnStart.TileImage = global::perfectTiming.Properties.Resources.ic_play_circle_outline_white_36dp;
            this.btnStart.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStart.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnStart.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnStart.UseSelectable = true;
            this.btnStart.UseStyleColors = true;
            this.btnStart.UseTileImage = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumber.Font = new System.Drawing.Font("Segoe UI Black", 78F, System.Drawing.FontStyle.Bold);
            this.txtNumber.Location = new System.Drawing.Point(3, 506);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(410, 183);
            this.txtNumber.TabIndex = 16;
            this.txtNumber.Text = "88";
            this.txtNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumber_KeyDown);
            // 
            // gridActualResults
            // 
            this.gridActualResults.AllowUserToAddRows = false;
            this.gridActualResults.AllowUserToDeleteRows = false;
            this.gridActualResults.AllowUserToResizeRows = false;
            this.gridActualResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridActualResults.AutoGenerateColumns = false;
            this.gridActualResults.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridActualResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridActualResults.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridActualResults.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridActualResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridActualResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridActualResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.laptimeDataGridViewTextBoxColumn,
            this.lapnumberDataGridViewTextBoxColumn});
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
            this.gridActualResults.Location = new System.Drawing.Point(3, 109);
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
            this.gridActualResults.Size = new System.Drawing.Size(617, 391);
            this.gridActualResults.TabIndex = 17;
            // 
            // bsTimings
            // 
            this.bsTimings.DataSource = typeof(perfectTiming.Model.Timing);
            // 
            // laptimeDataGridViewTextBoxColumn
            // 
            this.laptimeDataGridViewTextBoxColumn.DataPropertyName = "lap_time";
            this.laptimeDataGridViewTextBoxColumn.HeaderText = "lap_time";
            this.laptimeDataGridViewTextBoxColumn.Name = "laptimeDataGridViewTextBoxColumn";
            this.laptimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lapnumberDataGridViewTextBoxColumn
            // 
            this.lapnumberDataGridViewTextBoxColumn.DataPropertyName = "lap_number";
            this.lapnumberDataGridViewTextBoxColumn.HeaderText = "lap_number";
            this.lapnumberDataGridViewTextBoxColumn.Name = "lapnumberDataGridViewTextBoxColumn";
            this.lapnumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ucTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridActualResults);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.labelResult);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucTimer";
            this.Size = new System.Drawing.Size(1129, 695);
            ((System.ComponentModel.ISupportInitialize)(this.gridActualResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTimings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLabel labelResult;
        private System.Windows.Forms.Label lblTimer;
        private MetroFramework.Controls.MetroTile btnStop;
        private MetroFramework.Controls.MetroTile btnPause;
        private MetroFramework.Controls.MetroTile btnStart;
        private MetroFramework.Controls.MetroTile btnAdd;
        private System.Windows.Forms.TextBox txtNumber;
        private MetroFramework.Controls.MetroGrid gridActualResults;
        private System.Windows.Forms.BindingSource bsTimings;
        private System.Windows.Forms.DataGridViewTextBoxColumn laptimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lapnumberDataGridViewTextBoxColumn;
    }
}
