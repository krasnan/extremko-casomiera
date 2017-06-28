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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelResult = new MetroFramework.Controls.MetroLabel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.gridActualResults = new MetroFramework.Controls.MetroGrid();
            this.btnDiscardCorrection = new MetroFramework.Controls.MetroTile();
            this.btnAdd = new MetroFramework.Controls.MetroTile();
            this.btnStop = new MetroFramework.Controls.MetroTile();
            this.btnPause = new MetroFramework.Controls.MetroTile();
            this.btnStart = new MetroFramework.Controls.MetroTile();
            this.btnShowResults = new MetroFramework.Controls.MetroTile();
            this.bsTimings = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Registration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lapnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laptimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.labelResult.Location = new System.Drawing.Point(193, 259);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 0);
            this.labelResult.TabIndex = 10;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTimer.Location = new System.Drawing.Point(2, 0);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(394, 86);
            this.lblTimer.TabIndex = 11;
            this.lblTimer.Text = "00:00:00.000";
            // 
            // txtNumber
            // 
            this.txtNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumber.Font = new System.Drawing.Font("Segoe UI Black", 78F, System.Drawing.FontStyle.Bold);
            this.txtNumber.Location = new System.Drawing.Point(2, 428);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(308, 148);
            this.txtNumber.TabIndex = 10;
            this.txtNumber.Text = "#";
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyDown);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            this.laptimeDataGridViewTextBoxColumn});
            this.gridActualResults.DataSource = this.bsTimings;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridActualResults.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridActualResults.EnableHeadersVisualStyles = false;
            this.gridActualResults.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridActualResults.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridActualResults.Location = new System.Drawing.Point(2, 89);
            this.gridActualResults.Margin = new System.Windows.Forms.Padding(2);
            this.gridActualResults.Name = "gridActualResults";
            this.gridActualResults.ReadOnly = true;
            this.gridActualResults.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridActualResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridActualResults.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridActualResults.RowTemplate.Height = 24;
            this.gridActualResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridActualResults.Size = new System.Drawing.Size(1106, 335);
            this.gridActualResults.TabIndex = 9;
            this.gridActualResults.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridActualResults_CellFormatting);
            // 
            // btnDiscardCorrection
            // 
            this.btnDiscardCorrection.ActiveControl = null;
            this.btnDiscardCorrection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDiscardCorrection.Location = new System.Drawing.Point(471, 428);
            this.btnDiscardCorrection.Name = "btnDiscardCorrection";
            this.btnDiscardCorrection.Size = new System.Drawing.Size(342, 150);
            this.btnDiscardCorrection.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnDiscardCorrection.TabIndex = 15;
            this.btnDiscardCorrection.Text = "Zadané zlé štartovné číslo. \r\n\r\nKliknutím zahodíte korekciu.\r\nPrepísaním a potvrd" +
    "ením čísla\r\nupravíte záznam.";
            this.btnDiscardCorrection.TileImage = global::perfectTiming.Properties.Resources.ic_highlight_off_white_36dp;
            this.btnDiscardCorrection.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDiscardCorrection.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnDiscardCorrection.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnDiscardCorrection.UseSelectable = true;
            this.btnDiscardCorrection.UseStyleColors = true;
            this.btnDiscardCorrection.UseTileImage = true;
            this.btnDiscardCorrection.Click += new System.EventHandler(this.btnDiscardCorrection_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ActiveControl = null;
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(315, 428);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 150);
            this.btnAdd.Style = MetroFramework.MetroColorStyle.Green;
            this.btnAdd.TabIndex = 11;
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
            this.btnStop.Location = new System.Drawing.Point(1113, 428);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(150, 150);
            this.btnStop.Style = MetroFramework.MetroColorStyle.Red;
            this.btnStop.TabIndex = 14;
            this.btnStop.Text = "Synchronizovať\r\na ukončiť";
            this.btnStop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStop.TileImage = global::perfectTiming.Properties.Resources.ic_power_settings_new_white_36dp;
            this.btnStop.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnPause.Location = new System.Drawing.Point(1113, 160);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(150, 150);
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
            this.btnStart.Location = new System.Drawing.Point(1113, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(150, 150);
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
            // btnShowResults
            // 
            this.btnShowResults.ActiveControl = null;
            this.btnShowResults.Location = new System.Drawing.Point(401, 20);
            this.btnShowResults.Name = "btnShowResults";
            this.btnShowResults.Size = new System.Drawing.Size(155, 49);
            this.btnShowResults.TabIndex = 16;
            this.btnShowResults.Text = "Zobraziť \r\npriebežné výsledky";
            this.btnShowResults.TileImage = global::perfectTiming.Properties.Resources.ic_assessment_white_18dp;
            this.btnShowResults.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowResults.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnShowResults.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnShowResults.UseSelectable = true;
            this.btnShowResults.UseStyleColors = true;
            this.btnShowResults.UseTileImage = true;
            this.btnShowResults.Click += new System.EventHandler(this.btnShowResults_Click);
            // 
            // bsTimings
            // 
            this.bsTimings.DataSource = typeof(perfectTiming.Model.Timing);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Registration.start_number";
            this.dataGridViewTextBoxColumn1.HeaderText = "Číslo";
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
            this.lapnumberDataGridViewTextBoxColumn.HeaderText = "Kolo";
            this.lapnumberDataGridViewTextBoxColumn.Name = "lapnumberDataGridViewTextBoxColumn";
            this.lapnumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // laptimeDataGridViewTextBoxColumn
            // 
            this.laptimeDataGridViewTextBoxColumn.DataPropertyName = "lap_time";
            dataGridViewCellStyle2.NullValue = "0";
            this.laptimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.laptimeDataGridViewTextBoxColumn.HeaderText = "Čas kola";
            this.laptimeDataGridViewTextBoxColumn.Name = "laptimeDataGridViewTextBoxColumn";
            this.laptimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ucTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnShowResults);
            this.Controls.Add(this.btnDiscardCorrection);
            this.Controls.Add(this.gridActualResults);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.labelResult);
            this.Name = "ucTimer";
            this.Size = new System.Drawing.Size(1266, 582);
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
        private MetroFramework.Controls.MetroTile btnDiscardCorrection;
        private MetroFramework.Controls.MetroTile btnShowResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Registration;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn lapnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn laptimeDataGridViewTextBoxColumn;
    }
}
