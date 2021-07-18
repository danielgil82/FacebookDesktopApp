namespace BasicFacebookFeatures
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.panelForUserInfo = new System.Windows.Forms.Panel();
            this.labelUserFullName = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.labelCurrentDate = new System.Windows.Forms.Label();
            this.pictureBoxFbLogo = new System.Windows.Forms.PictureBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.pictureBoxFriendsLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxGroupsLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxEventsLogo = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.radioButtonFriends = new System.Windows.Forms.RadioButton();
            this.radioButtonEvents = new System.Windows.Forms.RadioButton();
            this.radioButtonGroups = new System.Windows.Forms.RadioButton();
            this.panelOptions.SuspendLayout();
            this.panelForUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendsLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroupsLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEventsLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.DarkBlue;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogin.Location = new System.Drawing.Point(17, 19);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(294, 58);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login to Facebook";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.DarkBlue;
            this.buttonLogout.Enabled = false;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogout.Location = new System.Drawing.Point(17, 784);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(294, 58);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // panelOptions
            // 
            this.panelOptions.Controls.Add(this.buttonLogin);
            this.panelOptions.Controls.Add(this.buttonLogout);
            this.panelOptions.Location = new System.Drawing.Point(14, 46);
            this.panelOptions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(330, 898);
            this.panelOptions.TabIndex = 53;
            // 
            // panelForUserInfo
            // 
            this.panelForUserInfo.Controls.Add(this.labelUserFullName);
            this.panelForUserInfo.Controls.Add(this.pictureBoxProfile);
            this.panelForUserInfo.Location = new System.Drawing.Point(423, 46);
            this.panelForUserInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelForUserInfo.Name = "panelForUserInfo";
            this.panelForUserInfo.Size = new System.Drawing.Size(540, 249);
            this.panelForUserInfo.TabIndex = 54;
            // 
            // labelUserFullName
            // 
            this.labelUserFullName.AutoSize = true;
            this.labelUserFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserFullName.Location = new System.Drawing.Point(16, 204);
            this.labelUserFullName.Name = "labelUserFullName";
            this.labelUserFullName.Size = new System.Drawing.Size(0, 29);
            this.labelUserFullName.TabIndex = 2;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(20, 19);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(155, 145);
            this.pictureBoxProfile.TabIndex = 0;
            this.pictureBoxProfile.TabStop = false;
            // 
            // labelCurrentDate
            // 
            this.labelCurrentDate.AutoSize = true;
            this.labelCurrentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentDate.Location = new System.Drawing.Point(9, 11);
            this.labelCurrentDate.Name = "labelCurrentDate";
            this.labelCurrentDate.Size = new System.Drawing.Size(116, 25);
            this.labelCurrentDate.TabIndex = 3;
            this.labelCurrentDate.Text = "Today is :";
            // 
            // pictureBoxFbLogo
            // 
            this.pictureBoxFbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxFbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFbLogo.Image")));
            this.pictureBoxFbLogo.Location = new System.Drawing.Point(1078, 46);
            this.pictureBoxFbLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxFbLogo.Name = "pictureBoxFbLogo";
            this.pictureBoxFbLogo.Size = new System.Drawing.Size(115, 122);
            this.pictureBoxFbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFbLogo.TabIndex = 2;
            this.pictureBoxFbLogo.TabStop = false;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 20;
            this.listBoxFriends.Location = new System.Drawing.Point(375, 602);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(192, 284);
            this.listBoxFriends.TabIndex = 2;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 20;
            this.listBoxEvents.Location = new System.Drawing.Point(703, 602);
            this.listBoxEvents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(192, 284);
            this.listBoxEvents.TabIndex = 57;
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 20;
            this.listBoxGroups.Location = new System.Drawing.Point(1011, 602);
            this.listBoxGroups.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(192, 284);
            this.listBoxGroups.TabIndex = 58;
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Enabled = false;
            this.checkBoxRememberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRememberMe.Location = new System.Drawing.Point(423, 321);
            this.checkBoxRememberMe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(183, 29);
            this.checkBoxRememberMe.TabIndex = 59;
            this.checkBoxRememberMe.Text = "Remember me ";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // pictureBoxFriendsLogo
            // 
            this.pictureBoxFriendsLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFriendsLogo.Image")));
            this.pictureBoxFriendsLogo.Location = new System.Drawing.Point(400, 520);
            this.pictureBoxFriendsLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxFriendsLogo.Name = "pictureBoxFriendsLogo";
            this.pictureBoxFriendsLogo.Size = new System.Drawing.Size(113, 32);
            this.pictureBoxFriendsLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxFriendsLogo.TabIndex = 3;
            this.pictureBoxFriendsLogo.TabStop = false;
            // 
            // pictureBoxGroupsLogo
            // 
            this.pictureBoxGroupsLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGroupsLogo.Image")));
            this.pictureBoxGroupsLogo.Location = new System.Drawing.Point(1032, 521);
            this.pictureBoxGroupsLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxGroupsLogo.Name = "pictureBoxGroupsLogo";
            this.pictureBoxGroupsLogo.Size = new System.Drawing.Size(107, 31);
            this.pictureBoxGroupsLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxGroupsLogo.TabIndex = 61;
            this.pictureBoxGroupsLogo.TabStop = false;
            // 
            // pictureBoxEventsLogo
            // 
            this.pictureBoxEventsLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEventsLogo.Image")));
            this.pictureBoxEventsLogo.Location = new System.Drawing.Point(721, 521);
            this.pictureBoxEventsLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxEventsLogo.Name = "pictureBoxEventsLogo";
            this.pictureBoxEventsLogo.Size = new System.Drawing.Size(134, 40);
            this.pictureBoxEventsLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEventsLogo.TabIndex = 62;
            this.pictureBoxEventsLogo.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // radioButtonFriends
            // 
            this.radioButtonFriends.AutoSize = true;
            this.radioButtonFriends.Location = new System.Drawing.Point(400, 568);
            this.radioButtonFriends.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonFriends.Name = "radioButtonFriends";
            this.radioButtonFriends.Size = new System.Drawing.Size(160, 24);
            this.radioButtonFriends.TabIndex = 63;
            this.radioButtonFriends.TabStop = true;
            this.radioButtonFriends.Text = "Show Friends List";
            this.radioButtonFriends.UseVisualStyleBackColor = true;
            this.radioButtonFriends.Click += new System.EventHandler(this.radioButtonFriends_Click);
            // 
            // radioButtonEvents
            // 
            this.radioButtonEvents.AutoSize = true;
            this.radioButtonEvents.Location = new System.Drawing.Point(721, 568);
            this.radioButtonEvents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonEvents.Name = "radioButtonEvents";
            this.radioButtonEvents.Size = new System.Drawing.Size(156, 24);
            this.radioButtonEvents.TabIndex = 64;
            this.radioButtonEvents.TabStop = true;
            this.radioButtonEvents.Text = "Show Events List";
            this.radioButtonEvents.UseVisualStyleBackColor = true;
            this.radioButtonEvents.Click += new System.EventHandler(this.radioButtonEvents_Click);
            // 
            // radioButtonGroups
            // 
            this.radioButtonGroups.AutoSize = true;
            this.radioButtonGroups.Location = new System.Drawing.Point(1032, 568);
            this.radioButtonGroups.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonGroups.Name = "radioButtonGroups";
            this.radioButtonGroups.Size = new System.Drawing.Size(160, 24);
            this.radioButtonGroups.TabIndex = 65;
            this.radioButtonGroups.TabStop = true;
            this.radioButtonGroups.Text = "Show Groups List";
            this.radioButtonGroups.UseVisualStyleBackColor = true;
            this.radioButtonGroups.Click += new System.EventHandler(this.radioButtonGroups_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1235, 952);
            this.Controls.Add(this.radioButtonGroups);
            this.Controls.Add(this.radioButtonEvents);
            this.Controls.Add(this.radioButtonFriends);
            this.Controls.Add(this.pictureBoxEventsLogo);
            this.Controls.Add(this.pictureBoxGroupsLogo);
            this.Controls.Add(this.pictureBoxFriendsLogo);
            this.Controls.Add(this.checkBoxRememberMe);
            this.Controls.Add(this.labelCurrentDate);
            this.Controls.Add(this.listBoxGroups);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.pictureBoxFbLogo);
            this.Controls.Add(this.panelForUserInfo);
            this.Controls.Add(this.panelOptions);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelOptions.ResumeLayout(false);
            this.panelForUserInfo.ResumeLayout(false);
            this.panelForUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendsLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroupsLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEventsLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.Panel panelForUserInfo;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.PictureBox pictureBoxFbLogo;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.Label labelCurrentDate;
        private System.Windows.Forms.Label labelUserFullName;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.PictureBox pictureBoxFriendsLogo;
        private System.Windows.Forms.PictureBox pictureBoxGroupsLogo;
        private System.Windows.Forms.PictureBox pictureBoxEventsLogo;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.RadioButton radioButtonFriends;
        private System.Windows.Forms.RadioButton radioButtonEvents;
        private System.Windows.Forms.RadioButton radioButtonGroups;
    }
}

