namespace BasicFacebookFeatures
{
    internal partial class FormMain
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
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label localeLabel;
            System.Windows.Forms.Label religionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label endTimeLabel;
            System.Windows.Forms.Label startTimeLabel;
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.buttonTimeLine = new System.Windows.Forms.Button();
            this.buttonFetchData = new System.Windows.Forms.Button();
            this.buttonHelpToElder = new System.Windows.Forms.Button();
            this.panelForUserInfo = new System.Windows.Forms.Panel();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.labelCurrentDate = new System.Windows.Forms.Label();
            this.pictureBoxFbLogo = new System.Windows.Forms.PictureBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.pictureBoxFriendsLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxGroupsLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxEventsLogo = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.radioButtonFriends = new System.Windows.Forms.RadioButton();
            this.radioButtonEvents = new System.Windows.Forms.RadioButton();
            this.radioButtonGroups = new System.Windows.Forms.RadioButton();
            this.panelCurrentFriendDetails = new System.Windows.Forms.Panel();
            this.birthdayLabel1 = new System.Windows.Forms.Label();
            this.emailLabel1 = new System.Windows.Forms.Label();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.localeLabel1 = new System.Windows.Forms.Label();
            this.religionLabel1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.endTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.imageNormalPictureBox1 = new System.Windows.Forms.PictureBox();
            this.startTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            birthdayLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            localeLabel = new System.Windows.Forms.Label();
            religionLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            endTimeLabel = new System.Windows.Forms.Label();
            startTimeLabel = new System.Windows.Forms.Label();
            this.panelOptions.SuspendLayout();
            this.panelForUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendsLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroupsLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEventsLogo)).BeginInit();
            this.panelCurrentFriendDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(25, 97);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(64, 17);
            birthdayLabel.TabIndex = 0;
            birthdayLabel.Text = "Birthday:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(25, 120);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 17);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email:";
            // 
            // localeLabel
            // 
            localeLabel.AutoSize = true;
            localeLabel.Location = new System.Drawing.Point(25, 143);
            localeLabel.Name = "localeLabel";
            localeLabel.Size = new System.Drawing.Size(54, 17);
            localeLabel.TabIndex = 8;
            localeLabel.Text = "Locale:";
            // 
            // religionLabel
            // 
            religionLabel.AutoSize = true;
            religionLabel.Location = new System.Drawing.Point(25, 166);
            religionLabel.Name = "religionLabel";
            religionLabel.Size = new System.Drawing.Size(63, 17);
            religionLabel.TabIndex = 10;
            religionLabel.Text = "Religion:";
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
            this.buttonLogin.Size = new System.Drawing.Size(230, 61);
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
            this.buttonLogout.Location = new System.Drawing.Point(0, 656);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(230, 62);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // panelOptions
            // 
            this.panelOptions.Controls.Add(this.buttonTimeLine);
            this.panelOptions.Controls.Add(this.buttonFetchData);
            this.panelOptions.Controls.Add(this.buttonHelpToElder);
            this.panelOptions.Controls.Add(this.buttonLogin);
            this.panelOptions.Controls.Add(this.buttonLogout);
            this.panelOptions.Location = new System.Drawing.Point(12, 37);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(230, 718);
            this.panelOptions.TabIndex = 53;
            // 
            // buttonTimeLine
            // 
            this.buttonTimeLine.BackColor = System.Drawing.Color.Azure;
            this.buttonTimeLine.Enabled = false;
            this.buttonTimeLine.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimeLine.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonTimeLine.Location = new System.Drawing.Point(31, 493);
            this.buttonTimeLine.Name = "buttonTimeLine";
            this.buttonTimeLine.Size = new System.Drawing.Size(157, 84);
            this.buttonTimeLine.TabIndex = 67;
            this.buttonTimeLine.Text = "How Somene Changed:";
            this.buttonTimeLine.UseVisualStyleBackColor = false;
            this.buttonTimeLine.Click += new System.EventHandler(this.buttonTimeLine_Click);
            // 
            // buttonFetchData
            // 
            this.buttonFetchData.BackColor = System.Drawing.Color.Azure;
            this.buttonFetchData.Enabled = false;
            this.buttonFetchData.Image = ((System.Drawing.Image)(resources.GetObject("buttonFetchData.Image")));
            this.buttonFetchData.Location = new System.Drawing.Point(31, 106);
            this.buttonFetchData.Name = "buttonFetchData";
            this.buttonFetchData.Size = new System.Drawing.Size(157, 93);
            this.buttonFetchData.TabIndex = 66;
            this.buttonFetchData.Text = "Fetch All Data";
            this.buttonFetchData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonFetchData.UseVisualStyleBackColor = false;
            this.buttonFetchData.Click += new System.EventHandler(this.buttonFetchData_Click);
            // 
            // buttonHelpToElder
            // 
            this.buttonHelpToElder.BackColor = System.Drawing.Color.Azure;
            this.buttonHelpToElder.Enabled = false;
            this.buttonHelpToElder.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelpToElder.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelpToElder.Image")));
            this.buttonHelpToElder.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonHelpToElder.Location = new System.Drawing.Point(31, 293);
            this.buttonHelpToElder.Name = "buttonHelpToElder";
            this.buttonHelpToElder.Size = new System.Drawing.Size(157, 117);
            this.buttonHelpToElder.TabIndex = 53;
            this.buttonHelpToElder.Text = "Find an elderly to help:";
            this.buttonHelpToElder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonHelpToElder.UseVisualStyleBackColor = false;
            this.buttonHelpToElder.Click += new System.EventHandler(this.buttonHelpToElder_Click);
            // 
            // panelForUserInfo
            // 
            this.panelForUserInfo.Controls.Add(this.labelBirthday);
            this.panelForUserInfo.Controls.Add(this.labelLocation);
            this.panelForUserInfo.Controls.Add(this.labelFullName);
            this.panelForUserInfo.Controls.Add(this.pictureBoxProfile);
            this.panelForUserInfo.Location = new System.Drawing.Point(297, 37);
            this.panelForUserInfo.Name = "panelForUserInfo";
            this.panelForUserInfo.Size = new System.Drawing.Size(499, 199);
            this.panelForUserInfo.TabIndex = 54;
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.BackColor = System.Drawing.Color.AntiqueWhite;
            this.labelBirthday.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthday.Location = new System.Drawing.Point(190, 103);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(98, 24);
            this.labelBirthday.TabIndex = 5;
            this.labelBirthday.Text = "Birthday:";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.BackColor = System.Drawing.Color.AntiqueWhite;
            this.labelLocation.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.Location = new System.Drawing.Point(190, 64);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(66, 24);
            this.labelLocation.TabIndex = 4;
            this.labelLocation.Text = "From:";
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.BackColor = System.Drawing.Color.AntiqueWhite;
            this.labelFullName.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullName.Location = new System.Drawing.Point(190, 25);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(112, 24);
            this.labelFullName.TabIndex = 3;
            this.labelFullName.Text = "Full Name:";
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(18, 15);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(138, 116);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 0;
            this.pictureBoxProfile.TabStop = false;
            // 
            // labelCurrentDate
            // 
            this.labelCurrentDate.AutoSize = true;
            this.labelCurrentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentDate.Location = new System.Drawing.Point(8, 9);
            this.labelCurrentDate.Name = "labelCurrentDate";
            this.labelCurrentDate.Size = new System.Drawing.Size(92, 20);
            this.labelCurrentDate.TabIndex = 3;
            this.labelCurrentDate.Text = "Today is :";
            // 
            // pictureBoxFbLogo
            // 
            this.pictureBoxFbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxFbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFbLogo.Image")));
            this.pictureBoxFbLogo.Location = new System.Drawing.Point(1402, 37);
            this.pictureBoxFbLogo.Name = "pictureBoxFbLogo";
            this.pictureBoxFbLogo.Size = new System.Drawing.Size(102, 98);
            this.pictureBoxFbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFbLogo.TabIndex = 2;
            this.pictureBoxFbLogo.TabStop = false;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxFriends.DataSource = this.userBindingSource;
            this.listBoxFriends.DisplayMember = "Name";
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 16;
            this.listBoxFriends.Location = new System.Drawing.Point(403, 527);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(171, 228);
            this.listBoxFriends.TabIndex = 2;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxEvents.DataSource = this.eventBindingSource;
            this.listBoxEvents.DisplayMember = "Name";
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 16;
            this.listBoxEvents.Location = new System.Drawing.Point(835, 527);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(171, 228);
            this.listBoxEvents.TabIndex = 57;
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 16;
            this.listBoxGroups.Location = new System.Drawing.Point(1349, 527);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(171, 228);
            this.listBoxGroups.TabIndex = 58;
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Enabled = false;
            this.checkBoxRememberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRememberMe.Location = new System.Drawing.Point(321, 273);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(146, 24);
            this.checkBoxRememberMe.TabIndex = 59;
            this.checkBoxRememberMe.Text = "Remember me ";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // pictureBoxFriendsLogo
            // 
            this.pictureBoxFriendsLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxFriendsLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFriendsLogo.Image")));
            this.pictureBoxFriendsLogo.Location = new System.Drawing.Point(431, 455);
            this.pictureBoxFriendsLogo.Name = "pictureBoxFriendsLogo";
            this.pictureBoxFriendsLogo.Size = new System.Drawing.Size(113, 32);
            this.pictureBoxFriendsLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFriendsLogo.TabIndex = 3;
            this.pictureBoxFriendsLogo.TabStop = false;
            // 
            // pictureBoxGroupsLogo
            // 
            this.pictureBoxGroupsLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxGroupsLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGroupsLogo.Image")));
            this.pictureBoxGroupsLogo.Location = new System.Drawing.Point(1367, 456);
            this.pictureBoxGroupsLogo.Name = "pictureBoxGroupsLogo";
            this.pictureBoxGroupsLogo.Size = new System.Drawing.Size(107, 31);
            this.pictureBoxGroupsLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGroupsLogo.TabIndex = 61;
            this.pictureBoxGroupsLogo.TabStop = false;
            // 
            // pictureBoxEventsLogo
            // 
            this.pictureBoxEventsLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxEventsLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEventsLogo.Image")));
            this.pictureBoxEventsLogo.Location = new System.Drawing.Point(850, 454);
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
            this.radioButtonFriends.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonFriends.AutoSize = true;
            this.radioButtonFriends.Enabled = false;
            this.radioButtonFriends.Location = new System.Drawing.Point(419, 499);
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
            this.radioButtonEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonEvents.AutoSize = true;
            this.radioButtonEvents.Enabled = false;
            this.radioButtonEvents.Location = new System.Drawing.Point(845, 498);
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
            this.radioButtonGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonGroups.AutoSize = true;
            this.radioButtonGroups.Enabled = false;
            this.radioButtonGroups.Location = new System.Drawing.Point(1362, 500);
            this.radioButtonGroups.Name = "radioButtonGroups";
            this.radioButtonGroups.Size = new System.Drawing.Size(140, 21);
            this.radioButtonGroups.TabIndex = 65;
            this.radioButtonGroups.TabStop = true;
            this.radioButtonGroups.Text = "Show Groups List";
            this.radioButtonGroups.UseVisualStyleBackColor = true;
            this.radioButtonGroups.Click += new System.EventHandler(this.radioButtonGroups_Click);
            // 
            // panelCurrentFriendDetails
            // 
            this.panelCurrentFriendDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCurrentFriendDetails.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panelCurrentFriendDetails.Controls.Add(birthdayLabel);
            this.panelCurrentFriendDetails.Controls.Add(this.birthdayLabel1);
            this.panelCurrentFriendDetails.Controls.Add(emailLabel);
            this.panelCurrentFriendDetails.Controls.Add(this.emailLabel1);
            this.panelCurrentFriendDetails.Controls.Add(this.imageNormalPictureBox);
            this.panelCurrentFriendDetails.Controls.Add(localeLabel);
            this.panelCurrentFriendDetails.Controls.Add(this.localeLabel1);
            this.panelCurrentFriendDetails.Controls.Add(religionLabel);
            this.panelCurrentFriendDetails.Controls.Add(this.religionLabel1);
            this.panelCurrentFriendDetails.Location = new System.Drawing.Point(590, 527);
            this.panelCurrentFriendDetails.Name = "panelCurrentFriendDetails";
            this.panelCurrentFriendDetails.Size = new System.Drawing.Size(230, 228);
            this.panelCurrentFriendDetails.TabIndex = 69;
            // 
            // birthdayLabel1
            // 
            this.birthdayLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.birthdayLabel1.Location = new System.Drawing.Point(130, 97);
            this.birthdayLabel1.Name = "birthdayLabel1";
            this.birthdayLabel1.Size = new System.Drawing.Size(100, 23);
            this.birthdayLabel1.TabIndex = 1;
            this.birthdayLabel1.Text = "label1";
            // 
            // emailLabel1
            // 
            this.emailLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.emailLabel1.Location = new System.Drawing.Point(130, 120);
            this.emailLabel1.Name = "emailLabel1";
            this.emailLabel1.Size = new System.Drawing.Size(100, 23);
            this.emailLabel1.TabIndex = 3;
            this.emailLabel1.Text = "label1";
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(12, 10);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(71, 64);
            this.imageNormalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageNormalPictureBox.TabIndex = 7;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // localeLabel1
            // 
            this.localeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Locale", true));
            this.localeLabel1.Location = new System.Drawing.Point(130, 143);
            this.localeLabel1.Name = "localeLabel1";
            this.localeLabel1.Size = new System.Drawing.Size(100, 23);
            this.localeLabel1.TabIndex = 9;
            this.localeLabel1.Text = "label1";
            // 
            // religionLabel1
            // 
            this.religionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Religion", true));
            this.religionLabel1.Location = new System.Drawing.Point(130, 166);
            this.religionLabel1.Name = "religionLabel1";
            this.religionLabel1.Size = new System.Drawing.Size(100, 23);
            this.religionLabel1.TabIndex = 11;
            this.religionLabel1.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Violet;
            this.panel1.Controls.Add(descriptionLabel);
            this.panel1.Controls.Add(this.descriptionTextBox);
            this.panel1.Controls.Add(endTimeLabel);
            this.panel1.Controls.Add(this.endTimeDateTimePicker);
            this.panel1.Controls.Add(this.imageNormalPictureBox1);
            this.panel1.Controls.Add(startTimeLabel);
            this.panel1.Controls.Add(this.startTimeDateTimePicker);
            this.panel1.Location = new System.Drawing.Point(1015, 527);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 228);
            this.panel1.TabIndex = 70;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(28, 97);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(83, 17);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(117, 94);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 41);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.Location = new System.Drawing.Point(28, 176);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new System.Drawing.Size(72, 17);
            endTimeLabel.TabIndex = 2;
            endTimeLabel.Text = "End Time:";
            // 
            // endTimeDateTimePicker
            // 
            this.endTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "EndTime", true));
            this.endTimeDateTimePicker.Location = new System.Drawing.Point(117, 172);
            this.endTimeDateTimePicker.Name = "endTimeDateTimePicker";
            this.endTimeDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.endTimeDateTimePicker.TabIndex = 3;
            // 
            // imageNormalPictureBox1
            // 
            this.imageNormalPictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.eventBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox1.Location = new System.Drawing.Point(22, 7);
            this.imageNormalPictureBox1.Name = "imageNormalPictureBox1";
            this.imageNormalPictureBox1.Size = new System.Drawing.Size(78, 67);
            this.imageNormalPictureBox1.TabIndex = 5;
            this.imageNormalPictureBox1.TabStop = false;
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Location = new System.Drawing.Point(28, 148);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new System.Drawing.Size(77, 17);
            startTimeLabel.TabIndex = 6;
            startTimeLabel.Text = "Start Time:";
            // 
            // startTimeDateTimePicker
            // 
            this.startTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "StartTime", true));
            this.startTimeDateTimePicker.Location = new System.Drawing.Point(117, 144);
            this.startTimeDateTimePicker.Name = "startTimeDateTimePicker";
            this.startTimeDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.startTimeDateTimePicker.TabIndex = 7;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1537, 802);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelCurrentFriendDetails);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelOptions.ResumeLayout(false);
            this.panelForUserInfo.ResumeLayout(false);
            this.panelForUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendsLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroupsLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEventsLogo)).EndInit();
            this.panelCurrentFriendDetails.ResumeLayout(false);
            this.panelCurrentFriendDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox1)).EndInit();
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
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.PictureBox pictureBoxFriendsLogo;
        private System.Windows.Forms.PictureBox pictureBoxGroupsLogo;
        private System.Windows.Forms.PictureBox pictureBoxEventsLogo;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.RadioButton radioButtonFriends;
        private System.Windows.Forms.RadioButton radioButtonEvents;
        private System.Windows.Forms.RadioButton radioButtonGroups;
        private System.Windows.Forms.Button buttonHelpToElder;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Button buttonFetchData;
        private System.Windows.Forms.Button buttonTimeLine;
        private System.Windows.Forms.Panel panelCurrentFriendDetails;
        private System.Windows.Forms.Label birthdayLabel1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Label emailLabel1;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.Label localeLabel1;
        private System.Windows.Forms.Label religionLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.DateTimePicker endTimeDateTimePicker;
        private System.Windows.Forms.PictureBox imageNormalPictureBox1;
        private System.Windows.Forms.DateTimePicker startTimeDateTimePicker;
    }
}