
namespace BasicFacebookFeatures
{
    partial class FormFindElderToHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFindElderToHelp));
            this.labelFindElderTitle = new System.Windows.Forms.Label();
            this.labelGenderInterest = new System.Windows.Forms.Label();
            this.panelElederly = new System.Windows.Forms.Panel();
            this.checkedListBoxAgeRange = new System.Windows.Forms.CheckedListBox();
            this.labelElderAge = new System.Windows.Forms.Label();
            this.checkedListBoxElders = new System.Windows.Forms.CheckedListBox();
            this.labelOptionalElders = new System.Windows.Forms.Label();
            this.pictureBoxElderPicture = new System.Windows.Forms.PictureBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.checkedListBoxGenderPrefrence = new System.Windows.Forms.CheckedListBox();
            this.panelElederly.SuspendLayout();
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
            this.panelElederly.Controls.Add(this.buttonBack);
            this.panelElederly.Controls.Add(this.pictureBoxElderPicture);
            this.panelElederly.Controls.Add(this.labelOptionalElders);
            this.panelElederly.Controls.Add(this.checkedListBoxElders);
            this.panelElederly.Controls.Add(this.checkedListBoxGenderPrefrence);
            this.panelElederly.Controls.Add(this.checkedListBoxAgeRange);
            this.panelElederly.Controls.Add(this.labelElderAge);
            this.panelElederly.Controls.Add(this.labelGenderInterest);
            this.panelElederly.Controls.Add(this.labelFindElderTitle);
            this.panelElederly.Location = new System.Drawing.Point(0, 0);
            this.panelElederly.Name = "panelElederly";
            this.panelElederly.Size = new System.Drawing.Size(935, 656);
            this.panelElederly.TabIndex = 5;
            // 
            // checkedListBoxAgeRange
            // 
            this.checkedListBoxAgeRange.FormattingEnabled = true;
            this.checkedListBoxAgeRange.Items.AddRange(new object[] {
            "65-70",
            "71-75",
            "76-80",
            "81-85",
            "86-90",
            "91-95",
            "96-100",
            "101-105",
            "106-110",
            "111-115",
            "116-120"});
            this.checkedListBoxAgeRange.Location = new System.Drawing.Point(543, 164);
            this.checkedListBoxAgeRange.Name = "checkedListBoxAgeRange";
            this.checkedListBoxAgeRange.Size = new System.Drawing.Size(195, 123);
            this.checkedListBoxAgeRange.TabIndex = 6;
            // 
            // labelElderAge
            // 
            this.labelElderAge.AutoSize = true;
            this.labelElderAge.BackColor = System.Drawing.Color.White;
            this.labelElderAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelElderAge.Location = new System.Drawing.Point(528, 124);
            this.labelElderAge.Name = "labelElderAge";
            this.labelElderAge.Size = new System.Drawing.Size(227, 25);
            this.labelElderAge.TabIndex = 5;
            this.labelElderAge.Text = "Choose an age range:";
            // 
            // checkedListBoxElders
            // 
            this.checkedListBoxElders.FormattingEnabled = true;
            this.checkedListBoxElders.Location = new System.Drawing.Point(47, 469);
            this.checkedListBoxElders.Name = "checkedListBoxElders";
            this.checkedListBoxElders.Size = new System.Drawing.Size(195, 123);
            this.checkedListBoxElders.TabIndex = 7;
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
            // pictureBoxElderPicture
            // 
            this.pictureBoxElderPicture.BackColor = System.Drawing.Color.White;
            this.pictureBoxElderPicture.Location = new System.Drawing.Point(459, 469);
            this.pictureBoxElderPicture.Name = "pictureBoxElderPicture";
            this.pictureBoxElderPicture.Size = new System.Drawing.Size(193, 123);
            this.pictureBoxElderPicture.TabIndex = 9;
            this.pictureBoxElderPicture.TabStop = false;
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
            // checkedListBoxGenderPrefrence
            // 
            this.checkedListBoxGenderPrefrence.FormattingEnabled = true;
            this.checkedListBoxGenderPrefrence.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Both"});
            this.checkedListBoxGenderPrefrence.Location = new System.Drawing.Point(47, 164);
            this.checkedListBoxGenderPrefrence.Name = "checkedListBoxGenderPrefrence";
            this.checkedListBoxGenderPrefrence.Size = new System.Drawing.Size(86, 55);
            this.checkedListBoxGenderPrefrence.TabIndex = 6;
            // 
            // FormFindElderToHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(912, 629);
            this.Controls.Add(this.panelElederly);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormFindElderToHelp";
            this.RightToLeftLayout = true;
            this.Text = "FormFindElderToHelp";
            this.panelElederly.ResumeLayout(false);
            this.panelElederly.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxElderPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelFindElderTitle;
        private System.Windows.Forms.Label labelGenderInterest;
        private System.Windows.Forms.Panel panelElederly;
        private System.Windows.Forms.CheckedListBox checkedListBoxAgeRange;
        private System.Windows.Forms.Label labelElderAge;
        private System.Windows.Forms.PictureBox pictureBoxElderPicture;
        private System.Windows.Forms.Label labelOptionalElders;
        private System.Windows.Forms.CheckedListBox checkedListBoxElders;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.CheckedListBox checkedListBoxGenderPrefrence;
    }
}