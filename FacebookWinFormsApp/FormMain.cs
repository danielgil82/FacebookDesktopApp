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
    internal partial class FormMain : Form
    {
        private const string k_UnknownMessage = "Unknown";
        private readonly AppSettings r_AppSettings;
        private FacebookAppManager m_FacebookAppManager;
        private LoginResult m_LoginResult;

        internal FacebookAppManager FacebookAppManager
        {
            get
            {
                return m_FacebookAppManager;
            }
        }

        internal FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
            r_AppSettings = AppSettings.LoadFromFile();
            fetchFormSettings();
        }

        private void fetchFormSettings()
        {
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
            buttonTimeLine.Enabled = true;
        }

        private void loginAndInit()
        {
            Clipboard.SetText("design.patterns21c"); /// the current password for Desig Patter

            m_LoginResult = FacebookService.Login(
                "452659572840281",
                ///requested permissions:
                
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
            fetchLoggedInUser();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if(r_AppSettings.RememberUser && !string.IsNullOrEmpty(r_AppSettings.LastAccessToken))
            {
                m_LoginResult = FacebookService.Connect(r_AppSettings.LastAccessToken);
                fetchLoggedInUser();
                buttonLogin.Text = "Logged In";
                buttonLogout.Enabled = true;
                checkBoxRememberMe.Enabled = true;
                buttonLogin.Enabled = false;
                buttonHelpToElder.Enabled = true;
                radioButtonEvents.Enabled = true;
                radioButtonFriends.Enabled = true;
                radioButtonGroups.Enabled = true;
                buttonFetchData.Enabled = true;
                buttonTimeLine.Enabled = true;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            r_AppSettings.LastWindowSize = this.Size;
            r_AppSettings.LastWindowLocation = this.Location;
            r_AppSettings.RememberUser = this.checkBoxRememberMe.Checked;
            if(r_AppSettings.RememberUser)
            {
                r_AppSettings.LastAccessToken = m_LoginResult.AccessToken;
            }

            r_AppSettings.SaveToFile();
        }

        private void fetchLoggedInUser()
        {
            this.Text = "Welcome to our Desktop Facebook app";
            m_FacebookAppManager = new FacebookAppManager(m_LoginResult.LoggedInUser);
            buttonLogin.ForeColor = Color.White;
            pictureBoxProfile.LoadAsync(m_FacebookAppManager.LoggedInUser.PictureNormalURL);
            labelCurrentDate.Text = DateTime.Now.ToLongDateString();
            labelFullName.Text = labelFullName.Text + " " + m_FacebookAppManager.LoggedInUser.Name;
            try
            {
                fetchUsersLocation();
                fetchUsersBirthday();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fetchUsersBirthday()
        {
            if (m_FacebookAppManager.LoggedInUser.Location.Name != null)
            {
                labelBirthday.Text = labelBirthday.Text + " " + m_FacebookAppManager.GetBirthday;
            }
            else
            {
                throw new NullReferenceException(k_UnknownMessage);
            }
        }

        private void fetchUsersLocation()
        {
            if (m_FacebookAppManager.LoggedInUser.Location.Name != null)
            {
                labelLocation.Text = labelLocation.Text + " " + m_FacebookAppManager.LoggedInUser.Location.Name;
            }
            else
            {
                throw new NullReferenceException(k_UnknownMessage);
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            m_FacebookAppManager.Logout();
            buttonLogin.Enabled = true;
            buttonLogin.Text = "Login To Facebook";
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
            try
            {
                foreach (User friend in m_FacebookAppManager.GetFriends)
                {
                    listBoxFriends.Items.Add(friend);
                    friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
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
                foreach (Group group in m_FacebookAppManager.GetGroups)
                {
                    listBoxGroups.Items.Add(group);
                }
            }
            catch (ArgumentException ex)
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
            try
            {
                foreach (Event fbEvent in m_FacebookAppManager.GetEvents)
                {
                    listBoxEvents.Items.Add(fbEvent);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
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

        private void buttonTimeLine_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHowSomeoneChanged timeLineInfo = new FormHowSomeoneChanged(this);
            timeLineInfo.ShowDialog();
            this.Show();
        }
    }
}
