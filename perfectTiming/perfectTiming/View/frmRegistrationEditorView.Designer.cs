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
            this.cmbRaces = new MetroFramework.Controls.MetroComboBox();
            this.bsRaces = new System.Windows.Forms.BindingSource(this.components);
            this.bsCategories = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lNazovArtiklu = new MetroFramework.Controls.MetroLabel();
            this.lblIdPolozky = new MetroFramework.Controls.MetroLabel();
            this.lblErrorHolder = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.iName = new MetroFramework.Controls.MetroTextBox();
            this.cmbCategories = new MetroFramework.Controls.MetroComboBox();
            this.cmbCompetitors = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.bsCompetitors = new System.Windows.Forms.BindingSource(this.components);
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsRaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCompetitors)).BeginInit();
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
            this.btnCancel.TabIndex = 88;
            this.btnCancel.Text = "&Zrušiť";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.UseStyleColors = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.AutoScroll = true;
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.cmbCompetitors);
            this.metroPanel1.Controls.Add(this.cmbCategories);
            this.metroPanel1.Controls.Add(this.cmbRaces);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.lNazovArtiklu);
            this.metroPanel1.Controls.Add(this.btnCancel);
            this.metroPanel1.Controls.Add(this.lblIdPolozky);
            this.metroPanel1.Controls.Add(this.lblErrorHolder);
            this.metroPanel1.Controls.Add(this.btnSave);
            this.metroPanel1.Controls.Add(this.iName);
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
            this.cmbRaces.TabIndex = 97;
            this.cmbRaces.UseSelectable = true;
            this.cmbRaces.ValueMember = "id";
            this.cmbRaces.SelectedValueChanged += new System.EventHandler(this.cmbRaces_SelectedValueChanged);
            // 
            // bsRaces
            // 
            this.bsRaces.DataSource = typeof(perfectTiming.Model.Race);
            // 
            // bsCategories
            // 
            this.bsCategories.DataSource = typeof(perfectTiming.Model.Category);
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
            // lblErrorHolder
            // 
            this.lblErrorHolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorHolder.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblErrorHolder.Location = new System.Drawing.Point(3, 222);
            this.lblErrorHolder.MinimumSize = new System.Drawing.Size(50, 5);
            this.lblErrorHolder.Name = "lblErrorHolder";
            this.lblErrorHolder.Size = new System.Drawing.Size(366, 63);
            this.lblErrorHolder.Style = MetroFramework.MetroColorStyle.Orange;
            this.lblErrorHolder.TabIndex = 58;
            this.lblErrorHolder.UseStyleColors = true;
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
            this.btnSave.TabIndex = 80;
            this.btnSave.Text = "&Uložiť";
            this.btnSave.UseSelectable = true;
            this.btnSave.UseStyleColors = true;
            // 
            // iName
            // 
            this.iName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.iName.CustomButton.Image = null;
            this.iName.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.iName.CustomButton.Name = "";
            this.iName.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.iName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.iName.CustomButton.TabIndex = 1;
            this.iName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.iName.CustomButton.UseSelectable = true;
            this.iName.CustomButton.Visible = false;
            this.iName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCategories, "name", true));
            this.iName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.iName.Lines = new string[0];
            this.iName.Location = new System.Drawing.Point(3, 184);
            this.iName.MaxLength = 32767;
            this.iName.Name = "iName";
            this.iName.PasswordChar = '\0';
            this.iName.PromptText = "...";
            this.iName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.iName.SelectedText = "";
            this.iName.SelectionLength = 0;
            this.iName.SelectionStart = 0;
            this.iName.ShortcutsEnabled = true;
            this.iName.Size = new System.Drawing.Size(224, 35);
            this.iName.TabIndex = 41;
            this.iName.UseSelectable = true;
            this.iName.WaterMark = "...";
            this.iName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.iName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbCategories
            // 
            this.cmbCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategories.DataSource = this.bsCategories;
            this.cmbCategories.DisplayMember = "name";
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.ItemHeight = 23;
            this.cmbCategories.Location = new System.Drawing.Point(3, 76);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(366, 29);
            this.cmbCategories.TabIndex = 98;
            this.cmbCategories.UseSelectable = true;
            this.cmbCategories.ValueMember = "id";
            this.cmbCategories.SelectedIndexChanged += new System.EventHandler(this.cmbCategories_SelectedIndexChanged);
            // 
            // cmbCompetitors
            // 
            this.cmbCompetitors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCompetitors.DataSource = this.bsCompetitors;
            this.cmbCompetitors.DisplayMember = "name";
            this.cmbCompetitors.FormattingEnabled = true;
            this.cmbCompetitors.ItemHeight = 23;
            this.cmbCompetitors.Location = new System.Drawing.Point(3, 130);
            this.cmbCompetitors.Name = "cmbCompetitors";
            this.cmbCompetitors.Size = new System.Drawing.Size(366, 29);
            this.cmbCompetitors.TabIndex = 99;
            this.cmbCompetitors.UseSelectable = true;
            this.cmbCompetitors.ValueMember = "id";
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
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.BackColor = System.Drawing.Color.LimeGreen;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.ForeColor = System.Drawing.SystemColors.Window;
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(233, 184);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(136, 35);
            this.metroButton1.TabIndex = 101;
            this.metroButton1.Text = "&Generuj";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            // 
            // bsCompetitors
            // 
            this.bsCompetitors.DataSource = typeof(perfectTiming.Model.Competitor);
            // 
            // frmRegistrationEditorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 412);
            this.Controls.Add(this.metroPanel1);
            this.Name = "frmRegistrationEditorView";
            this.Text = "Editor Registrácie";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsRaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCompetitors)).EndInit();
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
        private MetroFramework.Controls.MetroLabel lblErrorHolder;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroComboBox cmbCompetitors;
        private MetroFramework.Controls.MetroComboBox cmbCategories;
        private MetroFramework.Controls.MetroTextBox iName;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.BindingSource bsCompetitors;
    }
}