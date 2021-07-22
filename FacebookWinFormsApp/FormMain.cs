using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CefSharp.DevTools.LayerTree;
using FacebookAppLogic;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private readonly AppSettings r_AppSettings;
        private FacebookAppManager m_FacebookAppManager;
        private LoginResult m_LoginResult;

        public FacebookAppManager FacebookAppManager
        {
            get
            {
                return m_FacebookAppManager;
            }
        }

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
            r_AppSettings = AppSettings.LoadFromFile();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = r_AppSettings.LastWindowLocation;
            this.Size = r_AppSettings.LastWindowSize;
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginAndInit();
            (sender as Button).Enabled = false;
            buttonLogout.Enabled = true;
            checkBoxRememberMe.Enabled = true;
            buttonLogin.Enabled = false;
            buttonHelpToElder.Enabled = true;
            radioButtonEvents.Enabled = true;
            radioButtonFriends.Enabled = true;
            radioButtonGroups.Enabled = true;
            buttonFetchData.Enabled = true;
        }

        private void loginAndInit()
        {
            Clipboard.SetText("design.patterns20cc"); /// the current password for Desig Patter

            m_LoginResult = FacebookService.Login(
                "452659572840281",
                /// requested permissions:
                "email",
                "public_profile",
                "user_age_range",
                "user_birthday",
                "user_events",
                "user_friends",
                "user_gender",
                "user_hometown",
                "user_likes",
                "user_link",
                "user_location",
                "user_photos",
                "user_posts",
                "user_videos");
            buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
            //buttonLogin.ForeColor = Color.Azure;

            fetchLoggedInUser();
        }


        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (r_AppSettings.RememberUser && !string.IsNullOrEmpty(r_AppSettings.LastAccessToken))
            {
                m_LoginResult = FacebookService.Connect(r_AppSettings.LastAccessToken);
                buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
                fetchLoggedInUser();
                buttonLogin.Enabled = false;
                buttonLogout.Enabled = true;
                buttonHelpToElder.Enabled = true;
                checkBoxRememberMe.Enabled = true;
                buttonFetchData.Enabled = true;
                radioButtonEvents.Enabled = true;
                radioButtonFriends.Enabled = true;
                radioButtonGroups.Enabled = true;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            r_AppSettings.LastWindowSize = this.Size;
            r_AppSettings.LastWindowLocation = this.Location;
            r_AppSettings.RememberUser = this.checkBoxRememberMe.Checked;
            r_AppSettings.LastAccessToken = r_AppSettings.RememberUser ? m_LoginResult.AccessToken : null;
            r_AppSettings.SaveToFile();
        }
        
        private void fetchLoggedInUser()
        {
            m_FacebookAppManager = new FacebookAppManager(m_LoginResult.LoggedInUser);
            this.Text = "Welcome to our Desktop Facebook app";
            buttonLogin.ForeColor = Color.White;
            pictureBoxProfile.LoadAsync(m_FacebookAppManager.LoggedInUser.PictureNormalURL);
            labelCurrentDate.Text = DateTime.Now.ToLongDateString();
            labelFullName.Text = labelFullName.Text + " " + m_FacebookAppManager.LoggedInUser.Name;
            labelLocation.Text = labelLocation.Text + " " + m_FacebookAppManager.LoggedInUser.Location.Name.ToString();
            labelBirthday.Text = labelBirthday.Text + " "  + m_FacebookAppManager.UsersBirthday;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            m_FacebookAppManager.Logout();
            buttonLogin.Enabled = true;
            buttonLogin.Text = "Logged to Facebook";
            buttonLogin.ForeColor = Color.WhiteSmoke;
            (sender as Button).Enabled = false;
        }

        private void radioButtonFriends_Click(object sender, EventArgs e)
        {
            fetchFriends();
        }

        private void radioButtonEvents_Click(object sender, EventArgs e)
        {
            fetchEvents();
        }

        private void radioButtonGroups_Click(object sender, EventArgs e)
        {
            fetchGroups();
        }

        private void fetchFriends()
        {
            listBoxFriends.Items.Clear();
            listBoxFriends.DisplayMember = "Name";
            foreach (User friend in m_FacebookAppManager.GetFriends)
            {
                listBoxFriends.Items.Add(friend);
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }

            if (m_FacebookAppManager.GetFriends.Count == 0)
            {
                MessageBox.Show("Sorry, no friends to retrieve.");
            }
        }

        private void fetchGroups()
        {
            listBoxGroups.Items.Clear();
            listBoxGroups.DisplayMember = "Name";

            try
            {
                foreach (Group group in m_FacebookAppManager.LoggedInUser.Groups)
                {
                    listBoxGroups.Items.Add(group);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBoxGroups.Items.Count == 0)
            {
                MessageBox.Show("Sorry, no groups to retrieve.");
            }
        }

        private void fetchEvents()
        {
            listBoxEvents.Items.Clear();
            listBoxEvents.DisplayMember = "Name";
            foreach (Event fbEvent in m_FacebookAppManager.LoggedInUser.Events)
            {
                listBoxEvents.Items.Add(fbEvent);
            }

            if (listBoxEvents.Items.Count == 0)
            {
                MessageBox.Show("Sorry, no events to retrieve.");
            }
        }

        private void buttonHelpToElder_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFindElderToHelp helpToElderly = new FormFindElderToHelp(this);
            helpToElderly.ShowDialog();
            this.Show();
        }

        private void buttonFetchData_Click(object sender, EventArgs e)
        {
            fetchFriends();
            fetchEvents();
            fetchGroups();
        }
    }
}
