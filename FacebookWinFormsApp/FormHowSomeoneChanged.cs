using System;
using System.Collections;
using System.Collections.Generic;
using System.Speech.Synthesis;
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
        private readonly FacebookAppManagerFacade r_FacebookAppManager;
        private readonly Hashtable r_HasTheYearBeenChosen = new Hashtable();
        private readonly List<int> r_YearsChosenByUser = new List<int>();

        public List<Photo> UserProfilePictures { get; private set; }

        internal FacebookObjectCollection<User> UsersFriends { get; private set; }

        internal User PreferredUser { get; private set; }

        internal Hashtable HasTheYearBeenChosen
        {
            get
            {
                return r_HasTheYearBeenChosen;
            }
        }

        internal FormHowSomeoneChanged(FormMain i_MainForm)
        {
            InitializeComponent();
            r_FacebookAppManager = i_MainForm.FacebookAppManagerFacade;
            UsersFriends = r_FacebookAppManager.GetFriends;
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
            //fetchUserFriends();
        }

        private void fetchUserFriends()
        {
            listBoxUsersFriends.Invoke(new Action((() =>
             {
                 if (listBoxUsersFriends.Items.Count != 0)
                 {
                     listBoxUsersFriends.Items.Clear();
                 }

                 foreach (User friend in UsersFriends)
                 {
                     listBoxUsersFriends.Items.Add(new UserAdapter { User = friend });
                 }

                 if (listBoxUsersFriends.Items.Count == 0)
                 {
                     MessageBox.Show("No friends to retrieve");
                 }
             })));
        }


        private void listBoxUsersFriends_DoubleClick(object sender, EventArgs e)
        {
            ((sender as ListBox).SelectedItem as UserAdapter).Speak();
        }

        // todo: think if eventually implement the new thread this way, or maybe with the join line
        // todo: in the end of this method..
        private void buttonFetchPictures_Click(object sender, EventArgs e)
        {
            if (HasTheYearBeenChosen.Count == 5)
            {
                if (PreferredUser != null)
                {
                    fetchChosenYearsFromTheHashtable();
                    new Thread((() =>
                    {
                        UserProfilePictures =
                            r_FacebookAppManager.GetChosenFriendProfilePictures(PreferredUser, r_YearsChosenByUser);
                        resetDataAboutPhotosAndPictureBoxes();
                        fetchProfilePicturesAndDataAboutThem(UserProfilePictures);
                    })).Start();
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

        private void resetDataAboutPhotosAndPictureBoxes()
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
            this.Invoke(new Action((() =>
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
            })));
        }

        private void resetDatesInTheLables()
        {
            this.Invoke(new Action((() =>
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
            })));
        }

        private void displayThePicturesInThePictureBoxes(List<Photo> i_TimeLineProfilePictures)
        {
            this.Invoke(new Action((() =>
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
            })));
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
            this.Invoke(new Action((() =>
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
            })));
        }

        private void fetchChosenYearsFromTheHashtable()
        {
            if (r_YearsChosenByUser.Count != 0)
            {
                r_YearsChosenByUser.Clear();
            }

            foreach (string year in HasTheYearBeenChosen.Keys)
            {
                r_YearsChosenByUser.Add(int.Parse(year));
            }

            r_YearsChosenByUser.Sort();
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
            PreferredUser = ((sender as ListBox).SelectedItem as UserAdapter).User;
        }

        private void comboBoxFirstChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmBox = sender as ComboBox;
            reasureAboutTheChosenYearThatItsAUniqueYear(cmBox);
        }

        private void comboBoxSecondChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmBox = sender as ComboBox;
            reasureAboutTheChosenYearThatItsAUniqueYear(cmBox);
        }

        private void comboBoxThirdChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmBox = sender as ComboBox;
            reasureAboutTheChosenYearThatItsAUniqueYear(cmBox);
        }

        private void comboBoxFourthChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmBox = sender as ComboBox;
            reasureAboutTheChosenYearThatItsAUniqueYear(cmBox);
        }

        private void comboBoxFifthChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmBox = sender as ComboBox;
            reasureAboutTheChosenYearThatItsAUniqueYear(cmBox);
        }

        private void reasureAboutTheChosenYearThatItsAUniqueYear(ComboBox i_CmBox)
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

                r_YearsChosenByUser.Clear();
                HasTheYearBeenChosen.Clear();
            }
        }
    }
}
