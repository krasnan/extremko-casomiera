namespace perfectTiming.View
{
    partial class frmCategoryEditorView
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
            this.iDescription = new MetroFramework.Controls.MetroTextBox();
            this.bsItem = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lNazovArtiklu = new MetroFramework.Controls.MetroLabel();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.lblIdPolozky = new MetroFramework.Controls.MetroLabel();
            this.lblErrorHolder = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.iName = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsItem)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.AutoScroll = true;
            this.metroPanel1.Controls.Add(this.iDescription);
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
            this.metroPanel1.Size = new System.Drawing.Size(464, 291);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbar = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // iDescription
            // 
            this.iDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.iDescription.CustomButton.Image = null;
            this.iDescription.CustomButton.Location = new System.Drawing.Point(376, 2);
            this.iDescription.CustomButton.Name = "";
            this.iDescription.CustomButton.Size = new System.Drawing.Size(79, 79);
            this.iDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.iDescription.CustomButton.TabIndex = 1;
            this.iDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.iDescription.CustomButton.UseSelectable = true;
            this.iDescription.CustomButton.Visible = false;
            this.iDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsItem, "description", true));
            this.iDescription.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.iDescription.Lines = new string[0];
            this.iDescription.Location = new System.Drawing.Point(3, 82);
            this.iDescription.MaxLength = 32767;
            this.iDescription.Multiline = true;
            this.iDescription.Name = "iDescription";
            this.iDescription.PasswordChar = '\0';
            this.iDescription.PromptText = "Zadajte popis kategórie";
            this.iDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.iDescription.SelectedText = "";
            this.iDescription.SelectionLength = 0;
            this.iDescription.SelectionStart = 0;
            this.iDescription.ShortcutsEnabled = true;
            this.iDescription.Size = new System.Drawing.Size(458, 84);
            this.iDescription.TabIndex = 96;
            this.iDescription.UseSelectable = true;
            this.iDescription.WaterMark = "Zadajte popis kategórie";
            this.iDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.iDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bsItem
            // 
            this.bsItem.DataSource = typeof(perfectTiming.Model.Category);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 60);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(102, 19);
            this.metroLabel3.TabIndex = 95;
            this.metroLabel3.Text = "Popis kategórie:";
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
            // lNazovArtiklu
            // 
            this.lNazovArtiklu.AutoSize = true;
            this.lNazovArtiklu.Location = new System.Drawing.Point(3, 0);
            this.lNazovArtiklu.Name = "lNazovArtiklu";
            this.lNazovArtiklu.Size = new System.Drawing.Size(109, 19);
            this.lNazovArtiklu.TabIndex = 89;
            this.lNazovArtiklu.Text = "Názov Kategórie:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.Tomato;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCancel.Highlight = true;
            this.btnCancel.Location = new System.Drawing.Point(145, 253);
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
            // lblErrorHolder
            // 
            this.lblErrorHolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorHolder.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblErrorHolder.Location = new System.Drawing.Point(3, 169);
            this.lblErrorHolder.MinimumSize = new System.Drawing.Size(50, 5);
            this.lblErrorHolder.Name = "lblErrorHolder";
            this.lblErrorHolder.Size = new System.Drawing.Size(458, 63);
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
            this.btnSave.Location = new System.Drawing.Point(3, 253);
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
            this.iName.CustomButton.Location = new System.Drawing.Point(424, 1);
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
            this.iName.PromptText = "Zadajte názov kategórie";
            this.iName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.iName.SelectedText = "";
            this.iName.SelectionLength = 0;
            this.iName.SelectionStart = 0;
            this.iName.ShortcutsEnabled = true;
            this.iName.Size = new System.Drawing.Size(458, 35);
            this.iName.TabIndex = 41;
            this.iName.UseSelectable = true;
            this.iName.WaterMark = "Zadajte názov kategórie";
            this.iName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.iName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmCategoryEditorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 371);
            this.Controls.Add(this.metroPanel1);
            this.Name = "frmCategoryEditorView";
            this.Text = "Editor Kategórie";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.BindingSource bsItem;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lNazovArtiklu;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroLabel lblIdPolozky;
        private MetroFramework.Controls.MetroLabel lblErrorHolder;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTextBox iName;
        private MetroFramework.Controls.MetroTextBox iDescription;
    }
}