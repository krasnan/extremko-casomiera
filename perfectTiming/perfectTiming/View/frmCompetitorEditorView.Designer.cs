namespace perfectTiming.View
{
    partial class frmCompetitorEditorView
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
            this.lblErrorHolder = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.iEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.iPhone = new MetroFramework.Controls.MetroTextBox();
            this.lNazovArtiklu = new MetroFramework.Controls.MetroLabel();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.lblIdPolozky = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.iName = new MetroFramework.Controls.MetroTextBox();
            this.bsItem = new System.Windows.Forms.BindingSource(this.components);
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsItem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblErrorHolder
            // 
            this.lblErrorHolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorHolder.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblErrorHolder.Location = new System.Drawing.Point(3, 223);
            this.lblErrorHolder.MinimumSize = new System.Drawing.Size(50, 5);
            this.lblErrorHolder.Name = "lblErrorHolder";
            this.lblErrorHolder.Size = new System.Drawing.Size(430, 63);
            this.lblErrorHolder.Style = MetroFramework.MetroColorStyle.Orange;
            this.lblErrorHolder.TabIndex = 58;
            this.lblErrorHolder.UseStyleColors = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.AutoScroll = true;
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.iEmail);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroDateTime1);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.iPhone);
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
            this.metroPanel1.Size = new System.Drawing.Size(436, 372);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbar = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 114);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(100, 19);
            this.metroLabel4.TabIndex = 97;
            this.metroLabel4.Text = "Email účastníka:";
            // 
            // iEmail
            // 
            this.iEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.iEmail.CustomButton.Image = null;
            this.iEmail.CustomButton.Location = new System.Drawing.Point(402, 1);
            this.iEmail.CustomButton.Name = "";
            this.iEmail.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.iEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.iEmail.CustomButton.TabIndex = 1;
            this.iEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.iEmail.CustomButton.UseSelectable = true;
            this.iEmail.CustomButton.Visible = false;
            this.iEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsItem, "email", true));
            this.iEmail.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.iEmail.Lines = new string[0];
            this.iEmail.Location = new System.Drawing.Point(3, 136);
            this.iEmail.MaxLength = 32767;
            this.iEmail.Name = "iEmail";
            this.iEmail.PasswordChar = '\0';
            this.iEmail.PromptText = "example@domain.com";
            this.iEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.iEmail.SelectedText = "";
            this.iEmail.SelectionLength = 0;
            this.iEmail.SelectionStart = 0;
            this.iEmail.ShortcutsEnabled = true;
            this.iEmail.Size = new System.Drawing.Size(430, 29);
            this.iEmail.TabIndex = 96;
            this.iEmail.UseSelectable = true;
            this.iEmail.WaterMark = "example@domain.com";
            this.iEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.iEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 60);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(96, 19);
            this.metroLabel3.TabIndex = 95;
            this.metroLabel3.Text = "Telefónne číslo:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 169);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(114, 19);
            this.metroLabel2.TabIndex = 94;
            this.metroLabel2.Text = "Dátum narodenia:";
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroDateTime1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsItem, "birth_date", true));
            this.metroDateTime1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsItem, "birth_date", true));
            this.metroDateTime1.Location = new System.Drawing.Point(3, 191);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(430, 29);
            this.metroDateTime1.TabIndex = 92;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(13, 19);
            this.metroLabel1.TabIndex = 91;
            this.metroLabel1.Text = " ";
            // 
            // iPhone
            // 
            this.iPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.iPhone.CustomButton.Image = null;
            this.iPhone.CustomButton.Location = new System.Drawing.Point(402, 1);
            this.iPhone.CustomButton.Name = "";
            this.iPhone.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.iPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.iPhone.CustomButton.TabIndex = 1;
            this.iPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.iPhone.CustomButton.UseSelectable = true;
            this.iPhone.CustomButton.Visible = false;
            this.iPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsItem, "phone", true));
            this.iPhone.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.iPhone.Lines = new string[0];
            this.iPhone.Location = new System.Drawing.Point(3, 82);
            this.iPhone.MaxLength = 32767;
            this.iPhone.Name = "iPhone";
            this.iPhone.PasswordChar = '\0';
            this.iPhone.PromptText = "+421....";
            this.iPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.iPhone.SelectedText = "";
            this.iPhone.SelectionLength = 0;
            this.iPhone.SelectionStart = 0;
            this.iPhone.ShortcutsEnabled = true;
            this.iPhone.Size = new System.Drawing.Size(430, 29);
            this.iPhone.TabIndex = 90;
            this.iPhone.UseSelectable = true;
            this.iPhone.WaterMark = "+421....";
            this.iPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.iPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lNazovArtiklu
            // 
            this.lNazovArtiklu.AutoSize = true;
            this.lNazovArtiklu.Location = new System.Drawing.Point(3, 0);
            this.lNazovArtiklu.Name = "lNazovArtiklu";
            this.lNazovArtiklu.Size = new System.Drawing.Size(171, 19);
            this.lNazovArtiklu.TabIndex = 89;
            this.lNazovArtiklu.Text = "Meno a priezvisko účastníka";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.Tomato;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCancel.Highlight = true;
            this.btnCancel.Location = new System.Drawing.Point(145, 334);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 35);
            this.btnCancel.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnCancel.TabIndex = 88;
            this.btnCancel.Text = "&Zrušiť";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.UseStyleColors = true;
            // 
            // lblIdPolozky
            // 
            this.lblIdPolozky.AutoSize = true;
            this.lblIdPolozky.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblIdPolozky.Location = new System.Drawing.Point(107, 0);
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
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSave.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSave.Highlight = true;
            this.btnSave.Location = new System.Drawing.Point(3, 334);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(136, 35);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Green;
            this.btnSave.TabIndex = 80;
            this.btnSave.Text = "&Uložiť";
            this.btnSave.UseSelectable = true;
            this.btnSave.UseStyleColors = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // iName
            // 
            this.iName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.iName.CustomButton.Image = null;
            this.iName.CustomButton.Location = new System.Drawing.Point(396, 1);
            this.iName.CustomButton.Name = "";
            this.iName.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.iName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.iName.CustomButton.TabIndex = 1;
            this.iName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.iName.CustomButton.UseSelectable = true;
            this.iName.CustomButton.Visible = false;
            this.iName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsItem, "name", true));
            this.iName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.iName.Lines = new string[0];
            this.iName.Location = new System.Drawing.Point(3, 22);
            this.iName.MaxLength = 32767;
            this.iName.Name = "iName";
            this.iName.PasswordChar = '\0';
            this.iName.PromptText = "Zadajte meno a priezvisko";
            this.iName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.iName.SelectedText = "";
            this.iName.SelectionLength = 0;
            this.iName.SelectionStart = 0;
            this.iName.ShortcutsEnabled = true;
            this.iName.Size = new System.Drawing.Size(430, 35);
            this.iName.TabIndex = 41;
            this.iName.UseSelectable = true;
            this.iName.WaterMark = "Zadajte meno a priezvisko";
            this.iName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.iName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bsItem
            // 
            this.bsItem.DataSource = typeof(perfectTiming.Model.Competitor);
            // 
            // frmCompetitorEditorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 452);
            this.Controls.Add(this.metroPanel1);
            this.Name = "frmCompetitorEditorView";
            this.Text = "Editor účastníka";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblErrorHolder;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private System.Windows.Forms.BindingSource bsItem;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox iPhone;
        private MetroFramework.Controls.MetroLabel lNazovArtiklu;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroLabel lblIdPolozky;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTextBox iName;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox iEmail;
    }
}