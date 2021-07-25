using FacebookAppLogic;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FacebookAppLogic.TimeLineChange;

namespace BasicFacebookFeatures
{
    internal partial class FormHowYouChanged : Form
    {
        private const string k_ChooseAUser = "You must choose a friend, via Display Friends Button!!";
        private const string k_FiveDifferentYears = "Oops you must select 5 different options in the years section";
        private const string k_NoneStr = "None";
        private const string k_DateLabel = "Creation Date:";
        private readonly FacebookAppManager r_FacebookAppManager;
        private readonly FacebookObjectCollection<User> r_UsersFriends = null;
        private readonly Hashtable r_HasTheYearBeenChosen = new Hashtable();
        private readonly Dictionary<int, UserPhotoInfo> r_TimeLinePhotos = new Dictionary<int, UserPhotoInfo>();
        private readonly List<int> r_YearsChoosenByUser;
        private User m_PreferredUser;

        internal Dictionary<int, UserPhotoInfo> TimeLinePhotos
        {
            get
            {
                return r_TimeLinePhotos;
            }
        }

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

        internal FormHowYouChanged(FormMain i_MainForm)
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
                if (control is ComboBox) // check if control is comboBOx
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
            fetchUserFriends();
        }

        private void fetchUserFriends()
        {
            listBoxUsersFriends.DisplayMember = "Name";
            listBoxUsersFriends.DataSource = UsersFriends;
            if (listBoxUsersFriends.Items.Count == 0)
            {
                MessageBox.Show("No friends to retrieve");
            }
        }

        private void buttonFetchPictures_Click(object sender, EventArgs e)
        {
            ///areTheComboBoxesChecked())

            if (HasTheYearBeenChosen.Count == 5)
            {
                if (PreferredUser != null)
                {
                    Dictionary<int, UserPhotoInfo> TempTimeLinePhotos;

                    fetchChoosenYearsFromTheHastable();
                    TempTimeLinePhotos = r_FacebookAppManager.GetTimeLinePictures(PreferredUser, r_YearsChoosenByUser);
                    fetchPhotosFromTempDictionaryToTimeLinePhotosDictionary(TempTimeLinePhotos);
                    resetDataAboutPhotosAndPicturBoxes();
                    fetchPhotosAndDataAboutThem(TimeLinePhotos);
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

        private void fetchPhotosAndDataAboutThem(Dictionary<int, UserPhotoInfo> i_TimeLinePhotos)
        {
            displayThePicturesInThePictureBoxes(TimeLinePhotos);
            fetchPhotosDescriptions(TimeLinePhotos);
            fetchPhotosDates(TimeLinePhotos);
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

        private void fetchPhotosFromTempDictionaryToTimeLinePhotosDictionary(Dictionary<int, UserPhotoInfo> i_TimeLinePhotos)
        {
            if (r_TimeLinePhotos.Count != 0)
            {
                r_TimeLinePhotos.Clear();
            }

            foreach (KeyValuePair<int, UserPhotoInfo> element in i_TimeLinePhotos)
            {
                r_TimeLinePhotos.Add(element.Key, element.Value);
            }
        }

        private void displayThePicturesInThePictureBoxes(Dictionary<int, UserPhotoInfo> i_TimeLinePhotos)
        {
            int length = r_YearsChoosenByUser.Count;
            int dictionaryLength = i_TimeLinePhotos.Keys.Count;

            foreach (KeyValuePair<int, UserPhotoInfo> elementInfo in i_TimeLinePhotos)
            {
                foreach (Control control in this.splitContainer1.Panel1.Controls)
                {
                    if (control is PictureBox)
                    {
                        if ((control as PictureBox).Image == null)
                        {
                            (control as PictureBox).LoadAsync(elementInfo.Value.ChoosenPhoto.PictureNormalURL);
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
        private void fetchPhotosDates(Dictionary<int, UserPhotoInfo> i_TimeLinePhotos)
        {
            foreach (KeyValuePair<int, UserPhotoInfo> elementInfo in i_TimeLinePhotos)
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
                                currentLabel.Text += elementInfo.Value.PhotosCreationDate;
                                break;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// /// Fetch the description of the each photo 
        /// </summary>
        /// <param name="i_TimeLinePhotos"></param>
        private void fetchPhotosDescriptions(Dictionary<int, UserPhotoInfo> i_TimeLinePhotos)
        {
            foreach (KeyValuePair<int, UserPhotoInfo> elementInfo in i_TimeLinePhotos)
            {
                foreach (Control control in panelDescription.Controls)
                {
                    if (control is TextBox)
                    {
                        if ((control as TextBox).Text == string.Empty)
                        {
                            (control as TextBox).Text = (elementInfo.Value.PhotoDescription == null) ? k_NoneStr
                                : elementInfo.Value.PhotoDescription;
                            break;
                        }
                    }
                }
            }
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
                r_YearsChoosenByUser.Add(Int32.Parse(year));
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
            PreferredUser = ((sender as ListBox).SelectedItem) as User;
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
