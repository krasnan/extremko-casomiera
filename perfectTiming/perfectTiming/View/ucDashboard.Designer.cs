namespace perfectTiming.View
{
    partial class ucDashboard
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
            this.tCurrentTime = new MetroFramework.Controls.MetroTile();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tStart = new MetroFramework.Controls.MetroTile();
            this.tQuit = new MetroFramework.Controls.MetroTile();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.tRaces = new MetroFramework.Controls.MetroTile();
            this.tCompetitors = new MetroFramework.Controls.MetroTile();
            this.tCategories = new MetroFramework.Controls.MetroTile();
            this.tRegistrations = new MetroFramework.Controls.MetroTile();
            this.tResults = new MetroFramework.Controls.MetroTile();
            this.tSettings = new MetroFramework.Controls.MetroTile();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tCurrentTime
            // 
            this.tCurrentTime.ActiveControl = null;
            this.tCurrentTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tCurrentTime.Location = new System.Drawing.Point(709, 28);
            this.tCurrentTime.Name = "tCurrentTime";
            this.tCurrentTime.Size = new System.Drawing.Size(306, 150);
            this.tCurrentTime.TabIndex = 9999;
            this.tCurrentTime.TabStop = false;
            this.tCurrentTime.Text = "11/10/2016\r\n18:05:42";
            this.tCurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tCurrentTime.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tCurrentTime.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tCurrentTime.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tCurrentTime.UseSelectable = true;
            this.tCurrentTime.UseStyleColors = true;
            this.tCurrentTime.UseTileImage = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tStart
            // 
            this.tStart.ActiveControl = null;
            this.tStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tStart.Location = new System.Drawing.Point(25, 28);
            this.tStart.Name = "tStart";
            this.tStart.Size = new System.Drawing.Size(306, 150);
            this.tStart.TabIndex = 1;
            this.tStart.Text = "Spustiť Meranie";
            this.tStart.TileImage = global::perfectTiming.Properties.Resources.ic_alarm_on_white_36dp;
            this.tStart.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tStart.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tStart.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tStart.UseSelectable = true;
            this.tStart.UseStyleColors = true;
            this.tStart.UseTileImage = true;
            this.tStart.Click += new System.EventHandler(this.tStart_Click);
            // 
            // tQuit
            // 
            this.tQuit.ActiveControl = null;
            this.tQuit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tQuit.Location = new System.Drawing.Point(709, 184);
            this.tQuit.Name = "tQuit";
            this.tQuit.Size = new System.Drawing.Size(150, 150);
            this.tQuit.Style = MetroFramework.MetroColorStyle.Orange;
            this.tQuit.TabIndex = 8;
            this.tQuit.Text = "Ukončiť";
            this.tQuit.TileImage = global::perfectTiming.Properties.Resources.ic_power_settings_new_white_36dp;
            this.tQuit.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tQuit.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tQuit.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tQuit.UseSelectable = true;
            this.tQuit.UseStyleColors = true;
            this.tQuit.UseTileImage = true;
            this.tQuit.Click += new System.EventHandler(this.tQuit_Click);
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(211, 377);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(66, 15);
            this.metroCheckBox1.TabIndex = 1;
            this.metroCheckBox1.Text = "unfocus";
            this.metroCheckBox1.UseSelectable = true;
            // 
            // tRaces
            // 
            this.tRaces.ActiveControl = null;
            this.tRaces.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tRaces.Location = new System.Drawing.Point(368, 28);
            this.tRaces.Name = "tRaces";
            this.tRaces.Size = new System.Drawing.Size(150, 150);
            this.tRaces.TabIndex = 4;
            this.tRaces.Text = "Udalosti";
            this.tRaces.TileImage = global::perfectTiming.Properties.Resources.ic_date_range_white_36dp;
            this.tRaces.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tRaces.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tRaces.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tRaces.UseSelectable = true;
            this.tRaces.UseStyleColors = true;
            this.tRaces.UseTileImage = true;
            this.tRaces.Click += new System.EventHandler(this.tRaces_Click);
            // 
            // tCompetitors
            // 
            this.tCompetitors.ActiveControl = null;
            this.tCompetitors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tCompetitors.Location = new System.Drawing.Point(524, 28);
            this.tCompetitors.Name = "tCompetitors";
            this.tCompetitors.Size = new System.Drawing.Size(150, 150);
            this.tCompetitors.TabIndex = 5;
            this.tCompetitors.Text = "Účastníci";
            this.tCompetitors.TileImage = global::perfectTiming.Properties.Resources.ic_perm_identity_white_36dp;
            this.tCompetitors.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tCompetitors.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tCompetitors.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tCompetitors.UseSelectable = true;
            this.tCompetitors.UseStyleColors = true;
            this.tCompetitors.UseTileImage = true;
            this.tCompetitors.Click += new System.EventHandler(this.tCompetitors_Click);
            // 
            // tCategories
            // 
            this.tCategories.ActiveControl = null;
            this.tCategories.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tCategories.Location = new System.Drawing.Point(368, 184);
            this.tCategories.Name = "tCategories";
            this.tCategories.Size = new System.Drawing.Size(150, 150);
            this.tCategories.TabIndex = 6;
            this.tCategories.Text = "Kategórie";
            this.tCategories.TileImage = global::perfectTiming.Properties.Resources.ic_donut_small_white_36dp;
            this.tCategories.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tCategories.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tCategories.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tCategories.UseSelectable = true;
            this.tCategories.UseStyleColors = true;
            this.tCategories.UseTileImage = true;
            this.tCategories.Click += new System.EventHandler(this.tCategories_Click);
            // 
            // tRegistrations
            // 
            this.tRegistrations.ActiveControl = null;
            this.tRegistrations.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tRegistrations.Location = new System.Drawing.Point(524, 184);
            this.tRegistrations.Name = "tRegistrations";
            this.tRegistrations.Size = new System.Drawing.Size(150, 150);
            this.tRegistrations.TabIndex = 7;
            this.tRegistrations.Text = "Registrácie";
            this.tRegistrations.TileImage = global::perfectTiming.Properties.Resources.ic_verified_user_white_36dp;
            this.tRegistrations.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tRegistrations.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tRegistrations.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tRegistrations.UseSelectable = true;
            this.tRegistrations.UseStyleColors = true;
            this.tRegistrations.UseTileImage = true;
            this.tRegistrations.Click += new System.EventHandler(this.tRegistrations_Click);
            // 
            // tResults
            // 
            this.tResults.ActiveControl = null;
            this.tResults.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tResults.Location = new System.Drawing.Point(25, 184);
            this.tResults.Name = "tResults";
            this.tResults.Size = new System.Drawing.Size(150, 150);
            this.tResults.TabIndex = 2;
            this.tResults.Text = "Výsledky";
            this.tResults.TileImage = global::perfectTiming.Properties.Resources.ic_assessment_white_36dp;
            this.tResults.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tResults.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tResults.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tResults.UseSelectable = true;
            this.tResults.UseStyleColors = true;
            this.tResults.UseTileImage = true;
            this.tResults.Click += new System.EventHandler(this.tResults_Click);
            // 
            // tSettings
            // 
            this.tSettings.ActiveControl = null;
            this.tSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tSettings.Location = new System.Drawing.Point(181, 184);
            this.tSettings.Name = "tSettings";
            this.tSettings.Size = new System.Drawing.Size(150, 150);
            this.tSettings.TabIndex = 3;
            this.tSettings.Text = "Nastavenia";
            this.tSettings.TileImage = global::perfectTiming.Properties.Resources.ic_settings_applications_white_36dp;
            this.tSettings.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tSettings.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tSettings.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tSettings.UseSelectable = true;
            this.tSettings.UseStyleColors = true;
            this.tSettings.UseTileImage = true;
            this.tSettings.Click += new System.EventHandler(this.tSettings_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.AutoScroll = true;
            this.metroPanel1.Controls.Add(this.tCurrentTime);
            this.metroPanel1.Controls.Add(this.tStart);
            this.metroPanel1.Controls.Add(this.tSettings);
            this.metroPanel1.Controls.Add(this.tQuit);
            this.metroPanel1.Controls.Add(this.tResults);
            this.metroPanel1.Controls.Add(this.tRegistrations);
            this.metroPanel1.Controls.Add(this.tRaces);
            this.metroPanel1.Controls.Add(this.tCategories);
            this.metroPanel1.Controls.Add(this.tCompetitors);
            this.metroPanel1.HorizontalScrollbar = true;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1037, 364);
            this.metroPanel1.TabIndex = 10000;
            this.metroPanel1.VerticalScrollbar = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // ucDashboard
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroCheckBox1);
            this.Name = "ucDashboard";
            this.Size = new System.Drawing.Size(1060, 367);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTile tStart;
        private MetroFramework.Controls.MetroTile tCurrentTime;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroTile tQuit;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroTile tRaces;
        private MetroFramework.Controls.MetroTile tCompetitors;
        private MetroFramework.Controls.MetroTile tCategories;
        private MetroFramework.Controls.MetroTile tRegistrations;
        private MetroFramework.Controls.MetroTile tResults;
        private MetroFramework.Controls.MetroTile tSettings;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}
