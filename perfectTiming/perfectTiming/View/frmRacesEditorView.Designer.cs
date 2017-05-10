namespace perfectTiming.View
{
    partial class frmRacesEditorView
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.lNazovArtiklu = new MetroFramework.Controls.MetroLabel();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.lblIdPolozky = new MetroFramework.Controls.MetroLabel();
            this.lblErrorHolder = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.iNazovArtiklu = new MetroFramework.Controls.MetroTextBox();
            this.bsRace = new System.Windows.Forms.BindingSource(this.components);
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsRace)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.AutoScroll = true;
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroDateTime1);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.metroTextBox1);
            this.metroPanel1.Controls.Add(this.lNazovArtiklu);
            this.metroPanel1.Controls.Add(this.btnCancel);
            this.metroPanel1.Controls.Add(this.lblIdPolozky);
            this.metroPanel1.Controls.Add(this.lblErrorHolder);
            this.metroPanel1.Controls.Add(this.btnSave);
            this.metroPanel1.Controls.Add(this.iNazovArtiklu);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbar = true;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(611, 349);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbar = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 60);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(101, 19);
            this.metroLabel3.TabIndex = 95;
            this.metroLabel3.Text = "Poloha udalosti:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 169);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(100, 19);
            this.metroLabel2.TabIndex = 94;
            this.metroLabel2.Text = "Dátum udalosti:";
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRace, "start_date", true));
            this.metroDateTime1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsRace, "start_date", true));
            this.metroDateTime1.Location = new System.Drawing.Point(3, 191);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(289, 29);
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
            // metroTextBox1
            // 
            this.metroTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(523, 2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(79, 79);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRace, "location", true));
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(3, 82);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Multiline = true;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.PromptText = "Zadajte adresu udalosti";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(605, 84);
            this.metroTextBox1.TabIndex = 90;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "Zadajte adresu udalosti";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lNazovArtiklu
            // 
            this.lNazovArtiklu.AutoSize = true;
            this.lNazovArtiklu.Location = new System.Drawing.Point(3, 0);
            this.lNazovArtiklu.Name = "lNazovArtiklu";
            this.lNazovArtiklu.Size = new System.Drawing.Size(98, 19);
            this.lNazovArtiklu.TabIndex = 89;
            this.lNazovArtiklu.Text = "Názov udalosti:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.Tomato;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCancel.Highlight = true;
            this.btnCancel.Location = new System.Drawing.Point(145, 311);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 35);
            this.btnCancel.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnCancel.TabIndex = 88;
            this.btnCancel.Text = "Zrušiť";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.UseStyleColors = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            // lblErrorHolder
            // 
            this.lblErrorHolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorHolder.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblErrorHolder.Location = new System.Drawing.Point(3, 223);
            this.lblErrorHolder.MinimumSize = new System.Drawing.Size(50, 5);
            this.lblErrorHolder.Name = "lblErrorHolder";
            this.lblErrorHolder.Size = new System.Drawing.Size(605, 63);
            this.lblErrorHolder.Style = MetroFramework.MetroColorStyle.Orange;
            this.lblErrorHolder.TabIndex = 58;
            this.lblErrorHolder.UseStyleColors = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSave.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSave.Highlight = true;
            this.btnSave.Location = new System.Drawing.Point(3, 311);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(136, 35);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Green;
            this.btnSave.TabIndex = 80;
            this.btnSave.Text = "&Uložiť";
            this.btnSave.UseSelectable = true;
            this.btnSave.UseStyleColors = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // iNazovArtiklu
            // 
            this.iNazovArtiklu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.iNazovArtiklu.CustomButton.Image = null;
            this.iNazovArtiklu.CustomButton.Location = new System.Drawing.Point(571, 1);
            this.iNazovArtiklu.CustomButton.Name = "";
            this.iNazovArtiklu.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.iNazovArtiklu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.iNazovArtiklu.CustomButton.TabIndex = 1;
            this.iNazovArtiklu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.iNazovArtiklu.CustomButton.UseSelectable = true;
            this.iNazovArtiklu.CustomButton.Visible = false;
            this.iNazovArtiklu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRace, "name", true));
            this.iNazovArtiklu.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.iNazovArtiklu.Lines = new string[0];
            this.iNazovArtiklu.Location = new System.Drawing.Point(3, 22);
            this.iNazovArtiklu.MaxLength = 32767;
            this.iNazovArtiklu.Name = "iNazovArtiklu";
            this.iNazovArtiklu.PasswordChar = '\0';
            this.iNazovArtiklu.PromptText = "Zadajte názov artiklu";
            this.iNazovArtiklu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.iNazovArtiklu.SelectedText = "";
            this.iNazovArtiklu.SelectionLength = 0;
            this.iNazovArtiklu.SelectionStart = 0;
            this.iNazovArtiklu.ShortcutsEnabled = true;
            this.iNazovArtiklu.Size = new System.Drawing.Size(605, 35);
            this.iNazovArtiklu.TabIndex = 41;
            this.iNazovArtiklu.UseSelectable = true;
            this.iNazovArtiklu.WaterMark = "Zadajte názov artiklu";
            this.iNazovArtiklu.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.iNazovArtiklu.WaterMarkFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bsRace
            // 
            this.bsRace.DataSource = typeof(perfectTiming.Model.Race);
            // 
            // frmRacesEditorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 429);
            this.Controls.Add(this.metroPanel1);
            this.Name = "frmRacesEditorView";
            this.Text = "Editor Udalosti";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsRace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsRace;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroLabel lblIdPolozky;
        private MetroFramework.Controls.MetroLabel lblErrorHolder;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTextBox iNazovArtiklu;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel lNazovArtiklu;
    }
}