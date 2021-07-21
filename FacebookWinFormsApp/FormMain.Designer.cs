﻿namespace BasicFacebookFeatures
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
            this.buttonHelpToElder = new System.Windows.Forms.Button();
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelOptions.SuspendLayout();
            this.panelForUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendsLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroupsLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEventsLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.DarkBlue;
            this.buttonLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogin.Location = new System.Drawing.Point(0, 0);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(309, 46);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login to Facebook";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.DarkBlue;
            this.buttonLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLogout.Enabled = false;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogout.Location = new System.Drawing.Point(0, 571);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(309, 46);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // panelOptions
            // 
            this.panelOptions.Controls.Add(this.buttonHelpToElder);
            this.panelOptions.Controls.Add(this.buttonLogin);
            this.panelOptions.Controls.Add(this.buttonLogout);
            this.panelOptions.Location = new System.Drawing.Point(3, 43);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(309, 617);
            this.panelOptions.TabIndex = 53;
            // 
            // buttonHelpToElder
            // 
            this.buttonHelpToElder.BackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonHelpToElder.Enabled = false;
            this.buttonHelpToElder.Location = new System.Drawing.Point(40, 110);
            this.buttonHelpToElder.Name = "buttonHelpToElder";
            this.buttonHelpToElder.Size = new System.Drawing.Size(124, 69);
            this.buttonHelpToElder.TabIndex = 53;
            this.buttonHelpToElder.Text = "Help to elderly";
            this.buttonHelpToElder.UseVisualStyleBackColor = false;
            this.buttonHelpToElder.Click += new System.EventHandler(this.buttonHelpToElder_Click);
            // 
            // panelForUserInfo
            // 
            this.panelForUserInfo.Controls.Add(this.labelUserFullName);
            this.panelForUserInfo.Controls.Add(this.pictureBoxProfile);
            this.panelForUserInfo.Controls.Add(this.checkBoxRememberMe);
            this.panelForUserInfo.Location = new System.Drawing.Point(24, 42);
            this.panelForUserInfo.Name = "panelForUserInfo";
            this.panelForUserInfo.Size = new System.Drawing.Size(413, 190);
            this.panelForUserInfo.TabIndex = 54;
            // 
            // labelUserFullName
            // 
            this.labelUserFullName.AutoSize = true;
            this.labelUserFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserFullName.Location = new System.Drawing.Point(14, 163);
            this.labelUserFullName.Name = "labelUserFullName";
            this.labelUserFullName.Size = new System.Drawing.Size(0, 25);
            this.labelUserFullName.TabIndex = 2;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(19, 15);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(103, 100);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 0;
            this.pictureBoxProfile.TabStop = false;
            // 
            // labelCurrentDate
            // 
            this.labelCurrentDate.AutoSize = true;
            this.labelCurrentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentDate.Location = new System.Drawing.Point(3, 10);
            this.labelCurrentDate.Name = "labelCurrentDate";
            this.labelCurrentDate.Size = new System.Drawing.Size(92, 20);
            this.labelCurrentDate.TabIndex = 3;
            this.labelCurrentDate.Text = "Today is :";
            // 
            // pictureBoxFbLogo
            // 
            this.pictureBoxFbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxFbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFbLogo.Image")));
            this.pictureBoxFbLogo.Location = new System.Drawing.Point(540, 10);
            this.pictureBoxFbLogo.Name = "pictureBoxFbLogo";
            this.pictureBoxFbLogo.Size = new System.Drawing.Size(102, 98);
            this.pictureBoxFbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFbLogo.TabIndex = 2;
            this.pictureBoxFbLogo.TabStop = false;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 16;
            this.listBoxFriends.Location = new System.Drawing.Point(50, 421);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(171, 228);
            this.listBoxFriends.TabIndex = 2;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 16;
            this.listBoxEvents.Location = new System.Drawing.Point(238, 421);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(171, 228);
            this.listBoxEvents.TabIndex = 57;
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 16;
            this.listBoxGroups.Location = new System.Drawing.Point(427, 421);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(171, 228);
            this.listBoxGroups.TabIndex = 58;
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Enabled = false;
            this.checkBoxRememberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRememberMe.Location = new System.Drawing.Point(19, 121);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(146, 24);
            this.checkBoxRememberMe.TabIndex = 59;
            this.checkBoxRememberMe.Text = "Remember me ";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // pictureBoxFriendsLogo
            // 
            this.pictureBoxFriendsLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFriendsLogo.Image")));
            this.pictureBoxFriendsLogo.Location = new System.Drawing.Point(73, 355);
            this.pictureBoxFriendsLogo.Name = "pictureBoxFriendsLogo";
            this.pictureBoxFriendsLogo.Size = new System.Drawing.Size(113, 32);
            this.pictureBoxFriendsLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxFriendsLogo.TabIndex = 3;
            this.pictureBoxFriendsLogo.TabStop = false;
            // 
            // pictureBoxGroupsLogo
            // 
            this.pictureBoxGroupsLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGroupsLogo.Image")));
            this.pictureBoxGroupsLogo.Location = new System.Drawing.Point(445, 356);
            this.pictureBoxGroupsLogo.Name = "pictureBoxGroupsLogo";
            this.pictureBoxGroupsLogo.Size = new System.Drawing.Size(107, 31);
            this.pictureBoxGroupsLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxGroupsLogo.TabIndex = 61;
            this.pictureBoxGroupsLogo.TabStop = false;
            // 
            // pictureBoxEventsLogo
            // 
            this.pictureBoxEventsLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEventsLogo.Image")));
            this.pictureBoxEventsLogo.Location = new System.Drawing.Point(254, 356);
            this.pictureBoxEventsLogo.Name = "pictureBoxEventsLogo";
            this.pictureBoxEventsLogo.Size = new System.Drawing.Size(119, 32);
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
            this.radioButtonFriends.Location = new System.Drawing.Point(73, 393);
            this.radioButtonFriends.Name = "radioButtonFriends";
            this.radioButtonFriends.Size = new System.Drawing.Size(140, 21);
            this.radioButtonFriends.TabIndex = 63;
            this.radioButtonFriends.TabStop = true;
            this.radioButtonFriends.Text = "Show Friends List";
            this.radioButtonFriends.UseVisualStyleBackColor = true;
            this.radioButtonFriends.Click += new System.EventHandler(this.radioButtonFriends_Click);
            // 
            // radioButtonEvents
            // 
            this.radioButtonEvents.AutoSize = true;
            this.radioButtonEvents.Location = new System.Drawing.Point(254, 393);
            this.radioButtonEvents.Name = "radioButtonEvents";
            this.radioButtonEvents.Size = new System.Drawing.Size(136, 21);
            this.radioButtonEvents.TabIndex = 64;
            this.radioButtonEvents.TabStop = true;
            this.radioButtonEvents.Text = "Show Events List";
            this.radioButtonEvents.UseVisualStyleBackColor = true;
            this.radioButtonEvents.Click += new System.EventHandler(this.radioButtonEvents_Click);
            // 
            // radioButtonGroups
            // 
            this.radioButtonGroups.AutoSize = true;
            this.radioButtonGroups.Location = new System.Drawing.Point(445, 393);
            this.radioButtonGroups.Name = "radioButtonGroups";
            this.radioButtonGroups.Size = new System.Drawing.Size(140, 21);
            this.radioButtonGroups.TabIndex = 65;
            this.radioButtonGroups.TabStop = true;
            this.radioButtonGroups.Text = "Show Groups List";
            this.radioButtonGroups.UseVisualStyleBackColor = true;
            this.radioButtonGroups.Click += new System.EventHandler(this.radioButtonGroups_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelOptions);
            this.splitContainer1.Panel1.Controls.Add(this.labelCurrentDate);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelForUserInfo);
            this.splitContainer1.Panel2.Controls.Add(this.radioButtonGroups);
            this.splitContainer1.Panel2.Controls.Add(this.listBoxFriends);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBoxGroupsLogo);
            this.splitContainer1.Panel2.Controls.Add(this.radioButtonEvents);
            this.splitContainer1.Panel2.Controls.Add(this.listBoxGroups);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBoxFbLogo);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBoxEventsLogo);
            this.splitContainer1.Panel2.Controls.Add(this.radioButtonFriends);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBoxFriendsLogo);
            this.splitContainer1.Panel2.Controls.Add(this.listBoxEvents);
            this.splitContainer1.Size = new System.Drawing.Size(959, 674);
            this.splitContainer1.SplitterDistance = 297;
            this.splitContainer1.TabIndex = 66;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(959, 674);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
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
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button buttonHelpToElder;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

