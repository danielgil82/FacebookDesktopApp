using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using FacebookAppLogic;
using FacebookWrapper.ObjectModel;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    internal partial class FormHowSomeoneChanged : Form
    {
        private const string k_ChooseAUser = "You must choose a friend, via Display Friends Button!!";
        private const string k_FiveDifferentYears = "Oops you must select 5 different options in the years section";
        private const string k_NoneStr = "None";
        private const string k_DateLabel = "Creation Date:";
        private readonly FacebookAppManager r_FacebookAppManager;
        private readonly FacebookObjectCollection<User> r_UsersFriends = null;
        private readonly Hashtable r_HasTheYearBeenChosen = new Hashtable();
        private readonly List<int> r_YearsChoosenByUser;
        private User m_PreferredUser;

        public List<Photo> UserProfilePictures { get; internal set; }

        internal Hashtable HasTheYearBeenChosen
        {
            get
            {
                return r_HasTheYearBeenChosen;
            }
        }

        internal FacebookObjectCollection<User> UsersFriends
        {
            get
            {
                return r_UsersFriends;
            }
        }

        internal User PreferredUser
        {
            get
            {
                return m_PreferredUser;
            }
            private set
            {
                m_PreferredUser = value;
            }
        }

        internal FormHowSomeoneChanged(FormMain i_MainForm)
        {
            InitializeComponent();
            r_FacebookAppManager = i_MainForm.FacebookAppManager;
            r_UsersFriends = r_FacebookAppManager.GetFriends;
            r_YearsChoosenByUser = new List<int>();
            fetchYearsToChooseInTheComboBoxes();
        }

        private void fetchYearsToChooseInTheComboBoxes()
        {
            foreach (Control control in this.panelYearChoosing.Controls)
            {
                if (control is ComboBox)
                {
                    ComboBox cmBox = control as ComboBox;

                    for (int i = 2010; i < 2021; i++)
                    {
                        cmBox.Items.Add(i);
                    }
                }
            }
        }

        private void buttonFetchFriends_Click(object sender, EventArgs e)
        {
            new Thread(fetchUserFriends).Start();
        }

        private void fetchUserFriends()
        {
            listBoxUsersFriends.Invoke(new Action((() =>
            {
                listBoxUsersFriends.DisplayMember = "Name";
                listBoxUsersFriends.DataSource = UsersFriends;
                if (listBoxUsersFriends.Items.Count == 0)
                {
                    MessageBox.Show("No friends to retrieve");
                }
            })));
        }

        private void buttonFetchPictures_Click(object sender, EventArgs e)
        {
            if (HasTheYearBeenChosen.Count == 5)
            {
                if (PreferredUser != null)
                {

                    fetchChoosenYearsFromTheHastable();

                    Thread fetchUserProfilePicturesThread = new Thread((() =>
                    {
                        UserProfilePictures =
                            r_FacebookAppManager.GetChosenFriendProfilePictures(PreferredUser, r_YearsChoosenByUser);
                    }));
                    fetchUserProfilePicturesThread.Start();
                    fetchUserProfilePicturesThread.Join();
                    resetDataAboutPhotosAndPicturBoxes();
                    fetchProfilePicturesAndDataAboutThem(UserProfilePictures);
                }
                else
                {
                    MessageBox.Show(k_ChooseAUser);
                }
            }
            else
            {
                MessageBox.Show(k_FiveDifferentYears);
            }
        }

        private void resetDataAboutPhotosAndPicturBoxes()
        {
            resetTheImagesInThePictureBoxes();
            resetDatesInTheLables();
            resetTextBoxesTexts();
        }

        private void fetchProfilePicturesAndDataAboutThem(List<Photo> i_TimeLineProfilePictures)
        {
            displayThePicturesInThePictureBoxes(i_TimeLineProfilePictures);
            fetchPhotosDescriptions(i_TimeLineProfilePictures);
            fetchPhotosDates(i_TimeLineProfilePictures);
        }



        private void resetTextBoxesTexts()
        {
            foreach (Control control in panelDescription.Controls)
            {
                if (control is TextBox)
                {
                    if ((control as TextBox).Text != string.Empty)
                    {
                        (control as TextBox).Text = string.Empty;
                    }
                }
            }
        }

        private void resetDatesInTheLables()
        {
            foreach (Control control in panelDescription.Controls)
            {
                if (control is Label)
                {
                    if ((control as Label).Text.Contains(k_DateLabel))
                    {
                        Label currentLabel = control as Label;

                        if (currentLabel.Text.Length != k_DateLabel.Length)
                        {
                            currentLabel.Text = k_DateLabel;
                        }
                    }
                }
            }
        }

        private void displayThePicturesInThePictureBoxes(List<Photo> i_TimeLineProfilePictures)
        {
            foreach (Photo photo in i_TimeLineProfilePictures)
            {
                foreach (Control control in this.splitContainer1.Panel1.Controls)
                {
                    if (control is PictureBox)
                    {
                        if ((control as PictureBox).Image == null)
                        {
                            (control as PictureBox).LoadAsync(photo.PictureNormalURL);
                            break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Fetch the dates of the each photo
        /// </summary>
        /// <param name="i_TimeLinePhotos"></param>
        private void fetchPhotosDates(List<Photo> i_TimeLineProfilePictures)
        {
            this.Invoke(new Action(() =>
            {
                foreach (Photo photo in i_TimeLineProfilePictures)
                {
                    foreach (Control control in panelDescription.Controls)
                    {
                        if (control is Label)
                        {
                            if ((control as Label).Text.Contains(k_DateLabel))
                            {
                                Label currentLabel = control as Label;
                                if (currentLabel.Text.Length == k_DateLabel.Length)
                                {
                                    currentLabel.Text += photo.CreatedTime.ToString();
                                    break;
                                }
                            }
                        }
                    }
                }
            }));
        }

        /// <summary>
        /// /// Fetch the description of the each photo 2
        /// </summary>
        /// <param name="i_TimeLinePhotos"></param>
        private void fetchPhotosDescriptions(List<Photo> i_TimeLineProfilePictures)
        {
            this.Invoke(new Action(() =>
            {
                foreach (Photo photo in i_TimeLineProfilePictures)
                {
                    foreach (Control control in panelDescription.Controls)
                    {
                        if (control is TextBox)
                        {
                            if ((control as TextBox).Text == string.Empty)
                            {

                                (control as TextBox).Text = (photo.Name == null) ? k_NoneStr : photo.Name;
                                break;

                            }
                        }
                    }
                }
            }));
        }

        private void resetTheImagesInThePictureBoxes()
        {
            foreach (Control control in this.splitContainer1.Panel1.Controls)
            {
                if (control is PictureBox && control.Name != "pictureBoxTimeLine")
                {
                    if ((control as PictureBox).Image != null)
                    {
                        PictureBox pic = control as PictureBox;
                        pic.Image = null;
                    }
                }
            }
        }

        private void fetchChoosenYearsFromTheHastable()
        {
            if (r_YearsChoosenByUser.Count != 0)
            {
                r_YearsChoosenByUser.Clear();
            }

            foreach (string year in HasTheYearBeenChosen.Keys)
            {
                r_YearsChoosenByUser.Add(int.Parse(year));
            }

            r_YearsChoosenByUser.Sort();
        }

        private bool areTheComboBoxesChecked()
        {
            bool areChecked = true;

            foreach (Control control in this.panelYearChoosing.Controls)
            {
                if (control is ComboBox)
                {
                    ComboBox cmBox = control as ComboBox;

                    if (string.IsNullOrEmpty(cmBox.Text))
                    {
                        areChecked = false;
                        break;
                    }
                }
            }

            return areChecked;
        }

        private void listBoxUsersFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreferredUser = (sender as ListBox).SelectedItem as User;
        }

        private void comboBoxFirstChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmBox = sender as ComboBox;
            reasureAboutTheChosenYearThatItsAUniqeYear(cmBox);
        }

        private void comboBoxSecondChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmBox = sender as ComboBox;
            reasureAboutTheChosenYearThatItsAUniqeYear(cmBox);
        }

        private void comboBoxThirdChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmBox = sender as ComboBox;
            reasureAboutTheChosenYearThatItsAUniqeYear(cmBox);
        }

        private void comboBoxFourthChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmBox = sender as ComboBox;
            reasureAboutTheChosenYearThatItsAUniqeYear(cmBox);
        }

        private void comboBoxFifthChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmBox = sender as ComboBox;
            reasureAboutTheChosenYearThatItsAUniqeYear(cmBox);
        }

        private void reasureAboutTheChosenYearThatItsAUniqeYear(ComboBox i_CmBox)
        {
            if (!HasTheYearBeenChosen.Contains(i_CmBox.SelectedItem.ToString()))
            {
                HasTheYearBeenChosen.Add(i_CmBox.SelectedItem.ToString(), "True");
                i_CmBox.Enabled = false;
            }
            else
            {
                MessageBox.Show(k_FiveDifferentYears);
            }
        }

        private void buttonDifferentYears_Click(object sender, EventArgs e)
        {
            if (PreferredUser == null)
            {
                MessageBox.Show(k_ChooseAUser);
            }
            else if (!areTheComboBoxesChecked())
            {
                MessageBox.Show(k_FiveDifferentYears);
            }
            else
            {
                foreach (Control control in this.panelYearChoosing.Controls)
                {
                    if (control is ComboBox)
                    {
                        ComboBox cmBox = control as ComboBox;

                        if (cmBox.Enabled == false)
                        {
                            cmBox.Enabled = true;
                        }
                    }
                }

                r_YearsChoosenByUser.Clear();
                HasTheYearBeenChosen.Clear();
            }
        }
    }
}
