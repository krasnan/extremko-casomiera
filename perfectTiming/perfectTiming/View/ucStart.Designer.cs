namespace perfectTiming.View
{
    partial class ucStart
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
            this.lblArtikel = new MetroFramework.Controls.MetroLabel();
            this.cmbRace = new MetroFramework.Controls.MetroComboBox();
            this.bsRaces = new System.Windows.Forms.BindingSource(this.components);
            this.lblErrorHolder = new MetroFramework.Controls.MetroLabel();
            this.btnStart = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.bsRaces)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArtikel
            // 
            this.lblArtikel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblArtikel.AutoSize = true;
            this.lblArtikel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblArtikel.Location = new System.Drawing.Point(489, 97);
            this.lblArtikel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArtikel.Name = "lblArtikel";
            this.lblArtikel.Size = new System.Drawing.Size(65, 20);
            this.lblArtikel.TabIndex = 3;
            this.lblArtikel.Text = "Udalosť:";
            // 
            // cmbRace
            // 
            this.cmbRace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbRace.DataSource = this.bsRaces;
            this.cmbRace.DisplayMember = "name";
            this.cmbRace.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cmbRace.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbRace.FormattingEnabled = true;
            this.cmbRace.ItemHeight = 29;
            this.cmbRace.Location = new System.Drawing.Point(489, 124);
            this.cmbRace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbRace.Name = "cmbRace";
            this.cmbRace.Size = new System.Drawing.Size(376, 35);
            this.cmbRace.TabIndex = 4;
            this.cmbRace.UseSelectable = true;
            this.cmbRace.ValueMember = "id";
            // 
            // bsRaces
            // 
            this.bsRaces.DataSource = typeof(perfectTiming.Model.Race);
            // 
            // lblErrorHolder
            // 
            this.lblErrorHolder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorHolder.AutoSize = true;
            this.lblErrorHolder.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblErrorHolder.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblErrorHolder.Location = new System.Drawing.Point(489, 386);
            this.lblErrorHolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorHolder.MinimumSize = new System.Drawing.Size(67, 6);
            this.lblErrorHolder.Name = "lblErrorHolder";
            this.lblErrorHolder.Size = new System.Drawing.Size(0, 0);
            this.lblErrorHolder.TabIndex = 37;
            this.lblErrorHolder.UseCustomForeColor = true;
            // 
            // btnStart
            // 
            this.btnStart.ActiveControl = null;
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStart.Location = new System.Drawing.Point(489, 175);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(377, 208);
            this.btnStart.TabIndex = 38;
            this.btnStart.Text = "Spustiť";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStart.TileImage = global::perfectTiming.Properties.Resources.ic_check_circle_white_36dp1;
            this.btnStart.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStart.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnStart.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnStart.UseSelectable = true;
            this.btnStart.UseStyleColors = true;
            this.btnStart.UseTileImage = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // ucStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblErrorHolder);
            this.Controls.Add(this.cmbRace);
            this.Controls.Add(this.lblArtikel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ucStart";
            this.Size = new System.Drawing.Size(1276, 507);
            ((System.ComponentModel.ISupportInitialize)(this.bsRaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lblArtikel;
        private MetroFramework.Controls.MetroComboBox cmbRace;
        private System.Windows.Forms.BindingSource bsRaces;
        private MetroFramework.Controls.MetroLabel lblErrorHolder;
        private MetroFramework.Controls.MetroTile btnStart;
    }
}
