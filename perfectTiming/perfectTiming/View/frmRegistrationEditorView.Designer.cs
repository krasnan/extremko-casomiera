namespace perfectTiming.View
{
    partial class frmRegistrationEditorView
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
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.lblErrorHolder = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cmbCompetitors = new MetroFramework.Controls.MetroComboBox();
            this.bsItem = new System.Windows.Forms.BindingSource(this.components);
            this.bsCompetitors = new System.Windows.Forms.BindingSource(this.components);
            this.cmbCategories = new MetroFramework.Controls.MetroComboBox();
            this.bsCategories = new System.Windows.Forms.BindingSource(this.components);
            this.cmbRaces = new MetroFramework.Controls.MetroComboBox();
            this.bsRaces = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lNazovArtiklu = new MetroFramework.Controls.MetroLabel();
            this.lblIdPolozky = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.iStartNumber = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCompetitors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRaces)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.Tomato;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCancel.Highlight = true;
            this.btnCancel.Location = new System.Drawing.Point(145, 294);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 35);
            this.btnCancel.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "&Zrušiť";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.UseStyleColors = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.AutoScroll = true;
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.cmbCompetitors);
            this.metroPanel1.Controls.Add(this.cmbCategories);
            this.metroPanel1.Controls.Add(this.cmbRaces);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.lNazovArtiklu);
            this.metroPanel1.Controls.Add(this.btnCancel);
            this.metroPanel1.Controls.Add(this.lblIdPolozky);
            this.metroPanel1.Controls.Add(this.btnSave);
            this.metroPanel1.Controls.Add(this.iStartNumber);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbar = true;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(372, 332);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbar = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel2.AutoScroll = true;
            this.metroPanel2.Controls.Add(this.lblErrorHolder);
            this.metroPanel2.HorizontalScrollbar = true;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(3, 225);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(366, 63);
            this.metroPanel2.TabIndex = 102;
            this.metroPanel2.VerticalScrollbar = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // lblErrorHolder
            // 
            this.lblErrorHolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorHolder.AutoSize = true;
            this.lblErrorHolder.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblErrorHolder.Location = new System.Drawing.Point(3, 0);
            this.lblErrorHolder.MinimumSize = new System.Drawing.Size(50, 5);
            this.lblErrorHolder.Name = "lblErrorHolder";
            this.lblErrorHolder.Size = new System.Drawing.Size(0, 0);
            this.lblErrorHolder.Style = MetroFramework.MetroColorStyle.Orange;
            this.lblErrorHolder.TabIndex = 8;
            this.lblErrorHolder.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 162);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(94, 19);
            this.metroLabel2.TabIndex = 100;
            this.metroLabel2.Text = "Štartovné číslo";
            // 
            // cmbCompetitors
            // 
            this.cmbCompetitors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCompetitors.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bsItem, "Competitor", true));
            this.cmbCompetitors.DataSource = this.bsCompetitors;
            this.cmbCompetitors.DisplayMember = "name";
            this.cmbCompetitors.FormattingEnabled = true;
            this.cmbCompetitors.ItemHeight = 23;
            this.cmbCompetitors.Location = new System.Drawing.Point(3, 130);
            this.cmbCompetitors.Name = "cmbCompetitors";
            this.cmbCompetitors.Size = new System.Drawing.Size(366, 29);
            this.cmbCompetitors.TabIndex = 3;
            this.cmbCompetitors.UseSelectable = true;
            this.cmbCompetitors.ValueMember = "id";
            this.cmbCompetitors.SelectionChangeCommitted += new System.EventHandler(this.cmbCompetitors_SelectionChangeCommitted);
            // 
            // bsItem
            // 
            this.bsItem.DataSource = typeof(perfectTiming.Model.Registration);
            // 
            // bsCompetitors
            // 
            this.bsCompetitors.DataSource = typeof(perfectTiming.Model.Competitor);
            // 
            // cmbCategories
            // 
            this.cmbCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCategories.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bsItem, "Category", true));
            this.cmbCategories.DataSource = this.bsCategories;
            this.cmbCategories.DisplayMember = "name";
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.ItemHeight = 23;
            this.cmbCategories.Location = new System.Drawing.Point(3, 76);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(366, 29);
            this.cmbCategories.TabIndex = 2;
            this.cmbCategories.UseSelectable = true;
            this.cmbCategories.ValueMember = "id";
            this.cmbCategories.SelectionChangeCommitted += new System.EventHandler(this.cmbCategories_SelectedValueChanged);
            // 
            // bsCategories
            // 
            this.bsCategories.DataSource = typeof(perfectTiming.Model.Category);
            // 
            // cmbRaces
            // 
            this.cmbRaces.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRaces.DataSource = this.bsRaces;
            this.cmbRaces.DisplayMember = "name";
            this.cmbRaces.FormattingEnabled = true;
            this.cmbRaces.ItemHeight = 23;
            this.cmbRaces.Location = new System.Drawing.Point(3, 22);
            this.cmbRaces.Name = "cmbRaces";
            this.cmbRaces.Size = new System.Drawing.Size(366, 29);
            this.cmbRaces.TabIndex = 1;
            this.cmbRaces.UseSelectable = true;
            this.cmbRaces.ValueMember = "id";
            this.cmbRaces.SelectionChangeCommitted += new System.EventHandler(this.cmbRaces_SelectedValueChanged);
            // 
            // bsRaces
            // 
            this.bsRaces.DataSource = typeof(perfectTiming.Model.Race);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 108);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(59, 19);
            this.metroLabel3.TabIndex = 95;
            this.metroLabel3.Text = "Účastník:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 91;
            this.metroLabel1.Text = "Pretek:";
            // 
            // lNazovArtiklu
            // 
            this.lNazovArtiklu.AutoSize = true;
            this.lNazovArtiklu.Location = new System.Drawing.Point(3, 54);
            this.lNazovArtiklu.Name = "lNazovArtiklu";
            this.lNazovArtiklu.Size = new System.Drawing.Size(68, 19);
            this.lNazovArtiklu.TabIndex = 89;
            this.lNazovArtiklu.Text = "Kategória:";
            // 
            // lblIdPolozky
            // 
            this.lblIdPolozky.AutoSize = true;
            this.lblIdPolozky.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblIdPolozky.Location = new System.Drawing.Point(68, 0);
            this.lblIdPolozky.Name = "lblIdPolozky";
            this.lblIdPolozky.Size = new System.Drawing.Size(17, 19);
            this.lblIdPolozky.TabIndex = 59;
            this.lblIdPolozky.Text = "0";
            this.lblIdPolozky.UseStyleColors = true;
            this.lblIdPolozky.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSave.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSave.Highlight = true;
            this.btnSave.Location = new System.Drawing.Point(3, 294);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(136, 35);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Green;
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "&Uložiť";
            this.btnSave.UseSelectable = true;
            this.btnSave.UseStyleColors = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // iStartNumber
            // 
            this.iStartNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.iStartNumber.CustomButton.Image = null;
            this.iStartNumber.CustomButton.Location = new System.Drawing.Point(102, 1);
            this.iStartNumber.CustomButton.Name = "";
            this.iStartNumber.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.iStartNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.iStartNumber.CustomButton.TabIndex = 1;
            this.iStartNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.iStartNumber.CustomButton.UseSelectable = true;
            this.iStartNumber.CustomButton.Visible = false;
            this.iStartNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsItem, "start_number", true));
            this.iStartNumber.Enabled = false;
            this.iStartNumber.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.iStartNumber.Lines = new string[0];
            this.iStartNumber.Location = new System.Drawing.Point(3, 184);
            this.iStartNumber.MaxLength = 32767;
            this.iStartNumber.Name = "iStartNumber";
            this.iStartNumber.PasswordChar = '\0';
            this.iStartNumber.PromptText = "...";
            this.iStartNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.iStartNumber.SelectedText = "";
            this.iStartNumber.SelectionLength = 0;
            this.iStartNumber.SelectionStart = 0;
            this.iStartNumber.ShortcutsEnabled = true;
            this.iStartNumber.Size = new System.Drawing.Size(136, 35);
            this.iStartNumber.TabIndex = 4;
            this.iStartNumber.UseSelectable = true;
            this.iStartNumber.WaterMark = "...";
            this.iStartNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.iStartNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmRegistrationEditorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 412);
            this.Controls.Add(this.metroPanel1);
            this.Name = "frmRegistrationEditorView";
            this.Text = "Editor Registrácie";
            this.Load += new System.EventHandler(this.frmRegistrationEditorView_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCompetitors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRaces)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroComboBox cmbRaces;
        private System.Windows.Forms.BindingSource bsRaces;
        private System.Windows.Forms.BindingSource bsCategories;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lNazovArtiklu;
        private MetroFramework.Controls.MetroLabel lblIdPolozky;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroComboBox cmbCompetitors;
        private MetroFramework.Controls.MetroComboBox cmbCategories;
        private MetroFramework.Controls.MetroTextBox iStartNumber;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.BindingSource bsCompetitors;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel lblErrorHolder;
        private System.Windows.Forms.BindingSource bsItem;
    }
}