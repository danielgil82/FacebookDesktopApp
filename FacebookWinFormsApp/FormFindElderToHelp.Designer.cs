namespace BasicFacebookFeatures
{
    internal partial class FormFindElderToHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFindElderToHelp));
            this.labelFindElderTitle = new System.Windows.Forms.Label();
            this.labelGenderInterest = new System.Windows.Forms.Label();
            this.panelElederly = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.photoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxPotentialElders = new System.Windows.Forms.ListBox();
            this.buttonFindElderToHelp = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelOptionalElders = new System.Windows.Forms.Label();
            this.checkedListBoxGender = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxAgeRange = new System.Windows.Forms.CheckedListBox();
            this.labelElderAge = new System.Windows.Forms.Label();
            this.pictureBoxElderPicture = new System.Windows.Forms.PictureBox();
            this.panelElederly.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxElderPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFindElderTitle
            // 
            this.labelFindElderTitle.AutoSize = true;
            this.labelFindElderTitle.BackColor = System.Drawing.Color.White;
            this.labelFindElderTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFindElderTitle.Location = new System.Drawing.Point(275, 22);
            this.labelFindElderTitle.Name = "labelFindElderTitle";
            this.labelFindElderTitle.Size = new System.Drawing.Size(367, 32);
            this.labelFindElderTitle.TabIndex = 0;
            this.labelFindElderTitle.Text = "Help To Elder In Your City";
            // 
            // labelGenderInterest
            // 
            this.labelGenderInterest.AutoSize = true;
            this.labelGenderInterest.BackColor = System.Drawing.Color.White;
            this.labelGenderInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenderInterest.Location = new System.Drawing.Point(42, 124);
            this.labelGenderInterest.Name = "labelGenderInterest";
            this.labelGenderInterest.Size = new System.Drawing.Size(210, 25);
            this.labelGenderInterest.TabIndex = 1;
            this.labelGenderInterest.Text = "Interested to help to:";
            // 
            // panelElederly
            // 
            this.panelElederly.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelElederly.BackgroundImage")));
            this.panelElederly.Controls.Add(this.panel1);
            this.panelElederly.Controls.Add(this.pictureBoxElderPicture);
            this.panelElederly.Controls.Add(this.listBoxPotentialElders);
            this.panelElederly.Controls.Add(this.buttonFindElderToHelp);
            this.panelElederly.Controls.Add(this.buttonBack);
            this.panelElederly.Controls.Add(this.labelOptionalElders);
            this.panelElederly.Controls.Add(this.checkedListBoxGender);
            this.panelElederly.Controls.Add(this.checkedListBoxAgeRange);
            this.panelElederly.Controls.Add(this.labelElderAge);
            this.panelElederly.Controls.Add(this.labelGenderInterest);
            this.panelElederly.Controls.Add(this.labelFindElderTitle);
            this.panelElederly.Location = new System.Drawing.Point(0, 0);
            this.panelElederly.Name = "panelElederly";
            this.panelElederly.Size = new System.Drawing.Size(935, 656);
            this.panelElederly.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.imageNormalPictureBox);
            this.panel1.Location = new System.Drawing.Point(620, 473);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 129);
            this.panel1.TabIndex = 15;
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.photoBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageNormalPictureBox.Location = new System.Drawing.Point(0, 0);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(150, 129);
            this.imageNormalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageNormalPictureBox.TabIndex = 1;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // photoBindingSource
            // 
            this.photoBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Photo);
            // 
            // listBoxPotentialElders
            // 
            this.listBoxPotentialElders.DataSource = this.photoBindingSource;
            this.listBoxPotentialElders.DisplayMember = "Name";
            this.listBoxPotentialElders.FormattingEnabled = true;
            this.listBoxPotentialElders.ItemHeight = 16;
            this.listBoxPotentialElders.Location = new System.Drawing.Point(56, 473);
            this.listBoxPotentialElders.Name = "listBoxPotentialElders";
            this.listBoxPotentialElders.Size = new System.Drawing.Size(196, 116);
            this.listBoxPotentialElders.TabIndex = 14;
            this.listBoxPotentialElders.SelectedIndexChanged += new System.EventHandler(this.listBoxPotentialElders_SelectedIndexChanged);
            // 
            // buttonFindElderToHelp
            // 
            this.buttonFindElderToHelp.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonFindElderToHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFindElderToHelp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFindElderToHelp.Location = new System.Drawing.Point(372, 279);
            this.buttonFindElderToHelp.Name = "buttonFindElderToHelp";
            this.buttonFindElderToHelp.Size = new System.Drawing.Size(162, 54);
            this.buttonFindElderToHelp.TabIndex = 11;
            this.buttonFindElderToHelp.Text = "Find Elder";
            this.buttonFindElderToHelp.UseVisualStyleBackColor = false;
            this.buttonFindElderToHelp.Click += new System.EventHandler(this.buttonFindElderToHelp_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.HotPink;
            this.buttonBack.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(807, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(93, 58);
            this.buttonBack.TabIndex = 10;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelOptionalElders
            // 
            this.labelOptionalElders.AutoSize = true;
            this.labelOptionalElders.BackColor = System.Drawing.Color.White;
            this.labelOptionalElders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOptionalElders.Location = new System.Drawing.Point(61, 415);
            this.labelOptionalElders.Name = "labelOptionalElders";
            this.labelOptionalElders.Size = new System.Drawing.Size(165, 25);
            this.labelOptionalElders.TabIndex = 8;
            this.labelOptionalElders.Text = "Optional elders:";
            // 
            // checkedListBoxGender
            // 
            this.checkedListBoxGender.FormattingEnabled = true;
            this.checkedListBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Both"});
            this.checkedListBoxGender.Location = new System.Drawing.Point(47, 164);
            this.checkedListBoxGender.Name = "checkedListBoxGender";
            this.checkedListBoxGender.Size = new System.Drawing.Size(105, 72);
            this.checkedListBoxGender.TabIndex = 6;
            this.checkedListBoxGender.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxGender_SelectedIndexChanged);
            // 
            // checkedListBoxAgeRange
            // 
            this.checkedListBoxAgeRange.FormattingEnabled = true;
            this.checkedListBoxAgeRange.Location = new System.Drawing.Point(606, 173);
            this.checkedListBoxAgeRange.Name = "checkedListBoxAgeRange";
            this.checkedListBoxAgeRange.Size = new System.Drawing.Size(195, 123);
            this.checkedListBoxAgeRange.TabIndex = 6;
            this.checkedListBoxAgeRange.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxAgeRange_SelectedIndexChanged);
            // 
            // labelElderAge
            // 
            this.labelElderAge.AutoSize = true;
            this.labelElderAge.BackColor = System.Drawing.Color.White;
            this.labelElderAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelElderAge.Location = new System.Drawing.Point(591, 133);
            this.labelElderAge.Name = "labelElderAge";
            this.labelElderAge.Size = new System.Drawing.Size(227, 25);
            this.labelElderAge.TabIndex = 5;
            this.labelElderAge.Text = "Choose an age range:";
            // 
            // pictureBoxElderPicture
            // 
            this.pictureBoxElderPicture.BackColor = System.Drawing.Color.White;
            this.pictureBoxElderPicture.Location = new System.Drawing.Point(491, 352);
            this.pictureBoxElderPicture.Name = "pictureBoxElderPicture";
            this.pictureBoxElderPicture.Size = new System.Drawing.Size(123, 105);
            this.pictureBoxElderPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxElderPicture.TabIndex = 9;
            this.pictureBoxElderPicture.TabStop = false;
            // 
            // FormFindElderToHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(935, 656);
            this.Controls.Add(this.panelElederly);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormFindElderToHelp";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFindElderToHelp";
            this.panelElederly.ResumeLayout(false);
            this.panelElederly.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxElderPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelFindElderTitle;
        private System.Windows.Forms.Label labelGenderInterest;
        private System.Windows.Forms.Panel panelElederly;
        private System.Windows.Forms.CheckedListBox checkedListBoxAgeRange;
        private System.Windows.Forms.Label labelElderAge;
        private System.Windows.Forms.Label labelOptionalElders;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.CheckedListBox checkedListBoxGender;
        private System.Windows.Forms.Button buttonFindElderToHelp;
        private System.Windows.Forms.ListBox listBoxPotentialElders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.BindingSource photoBindingSource;
        private System.Windows.Forms.PictureBox pictureBoxElderPicture;
    }
}