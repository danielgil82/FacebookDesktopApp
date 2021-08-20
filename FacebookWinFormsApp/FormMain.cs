using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FacebookAppLogic;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    internal partial class FormMain : Form
    {
        private const string k_UnknownMessage = "Unknown";
        private const string k_LoggedInUser = "Logged In";
        private const string k_FormFindElderToHelp = "FormFindElderToHelp";
        private const string k_FormHowSomeoneChanged = "FormHowSomeoneChanged";
        private const string k_CannotRetrieveData = "Sorry, could not retrieve any ";
        private readonly AppSettings r_AppSettings;
        private FacebookAppManagerFacade m_FacebookAppManagerFacade;
        private LoginResult m_LoginResult;

        internal FacebookAppManagerFacade FacebookAppManagerFacade
        {
            get { return m_FacebookAppManagerFacade; }
        }

        internal FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
            r_AppSettings = AppSettings.LoadFromFile();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            fetchFormSettings();
            if (r_AppSettings.RememberUser && !string.IsNullOrEmpty(r_AppSettings.LastAccessToken))
            {
                new Thread(autoLogin).Start();
            }
        }


        private void autoLogin()
        {
            m_LoginResult = FacebookService.Connect(r_AppSettings.LastAccessToken);
            fetchLoggedInUser();
            enablingAndDisablingButtonsWhenLoggedIn();
        }

        private void enablingAndDisablingButtonsWhenLoggedIn()
        {
            this.Invoke(
                new Action(
                    () =>
                    {
                        buttonLogout.Enabled = true;
                        checkBoxRememberMe.Enabled = true;
                        buttonLogin.Enabled = false;
                        buttonHelpToElder.Enabled = true;
                        radioButtonEvents.Enabled = true;
                        radioButtonFriends.Enabled = true;
                        radioButtonGroups.Enabled = true;
                        buttonFetchData.Enabled = true;
                        buttonTimeLine.Enabled = true;
                    }));
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            r_AppSettings.LastWindowSize = this.Size;
            r_AppSettings.LastWindowLocation = this.Location;
            r_AppSettings.RememberUser = this.checkBoxRememberMe.Checked;
            if (r_AppSettings.RememberUser)
            {
                r_AppSettings.LastAccessToken = m_LoginResult.AccessToken;
            }

            r_AppSettings.SaveToFile();
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
            Clipboard.SetText("design.patterns.c21"); /// the current password for Desig Patter
            m_LoginResult = FacebookService.Login(
                "452659572840281",
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
            new Thread(fetchLoggedInUser).Start();
        }

        private void fetchLoggedInUser()
        {
            this.Invoke(
                new Action(
                    () =>
                    {
                        this.Text = "Welcome To Our Desktop Facebook App";
                        buttonLogin.Text = k_LoggedInUser;
                        m_FacebookAppManagerFacade = new FacebookAppManagerFacade(m_LoginResult.LoggedInUser);
                        buttonLogin.BackColor = Color.BlueViolet;
                        pictureBoxProfile.LoadAsync(m_FacebookAppManagerFacade.LoggedInUser.PictureNormalURL);
                        labelCurrentDate.Text = DateTime.Now.ToLongDateString();
                        labelFullName.Text += " " + m_FacebookAppManagerFacade.LoggedInUser.Name;
                        try
                        {
                            fetchUsersLivingLocation();
                            fetchUsersBirthday();
                        }
                        catch (NullReferenceException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }));
        }

        private void fetchUsersBirthday()
        {
            if (m_FacebookAppManagerFacade.LoggedInUser.Location.Name != null)
            {
                labelBirthday.Text += " " + m_FacebookAppManagerFacade.GetBirthday;
            }
            else
            {
                throw new NullReferenceException(k_UnknownMessage);
            }
        }

        private void fetchUsersLivingLocation()
        {
            if (m_FacebookAppManagerFacade.LoggedInUser.Location.Name != null)
            {
                labelLocation.Text += " " + m_FacebookAppManagerFacade.LoggedInUser.Location.Name;
            }
            else
            {
                throw new NullReferenceException(k_UnknownMessage);
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            m_FacebookAppManagerFacade.Logout();
            buttonLogin.Enabled = true;
            buttonLogin.Text = "Login To Facebook";
            buttonLogin.BackColor = Color.MidnightBlue;
            (sender as Button).Enabled = false;
        }

        private void radioButtonFriends_Click(object sender, EventArgs e)
        {
            new Thread(fetchFriends).Start();
        }

        private void radioButtonEvents_Click(object sender, EventArgs e)
        {
            new Thread(fetchEvents).Start();
        }

        private void radioButtonGroups_Click(object sender, EventArgs e)
        {
            new Thread(fetchGroups).Start();
        }

        private void fetchFriends()
        {
            listBoxFriends.Invoke(new Action(() =>
            {
                userBindingSource.DataSource = m_FacebookAppManagerFacade.GetFriends;
                if (m_FacebookAppManagerFacade.GetFriends.Count == 0)
                {
                    MessageBox.Show(string.Format(k_CannotRetrieveData + "Friends"));
                }
            }));
        }

        private void fetchGroups()
        {
            listBoxGroups.Invoke(new Action(() =>
            {
                groupBindingSource.DataSource = m_FacebookAppManagerFacade.GetGroups;
                if (listBoxGroups.Items.Count == 0)
                {
                    MessageBox.Show(string.Format(k_CannotRetrieveData + "Groups"));
                }
            }));
        }

        private void fetchEvents()
        {
            listBoxEvents.Invoke(new Action(() =>
            {
                eventBindingSource.DataSource = m_FacebookAppManagerFacade.GetEvents;
                if (listBoxEvents.Items.Count == 0)
                {
                    MessageBox.Show(string.Format(k_CannotRetrieveData + "Events"));
                }
            }));
        }

        private void buttonFetchData_Click(object sender, EventArgs e)
        {
            new Thread(fetchFriends).Start();
            new Thread(fetchEvents).Start();
            new Thread(fetchGroups).Start();
        }

        private void buttonHelpToElder_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FormFindElderToHelp helpToElderly = 
                    FormFactory.CreateForm(k_FormFindElderToHelp) as FormFindElderToHelp;
                helpToElderly.ShowDialog();
                this.Show();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonTimeLine_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FormHowSomeoneChanged timeLineInfo
                    = FormFactory.CreateForm(k_FormHowSomeoneChanged) as FormHowSomeoneChanged;
                timeLineInfo.ShowDialog();
                this.Show();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}