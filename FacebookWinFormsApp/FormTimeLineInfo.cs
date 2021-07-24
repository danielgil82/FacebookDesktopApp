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
using static FacebookAppLogic.TimeLineInfo;

namespace BasicFacebookFeatures
{
    internal partial class FormTimeLineInfo : Form
    {
        private readonly FacebookAppManager r_FacebookAppManager;
        private readonly FacebookObjectCollection<User> r_UsersFriends = null;
        private readonly List<int> r_YearsChoosenByUser;
        private readonly Hashtable r_HasTheYearBeenChosen = new Hashtable();
        private const string k_ChooseAUser = "You must choose a friend, via Display Friends Button!!";
        private const string k_FiveDifferentYears = "Oops you must select 5 different options in the years section";
        // private readonly List<PictureBox> r_PictureBoxesNames = new List<PictureBox>();
        private User m_PreferredUser;
        //private ePictureBoxes m_PictureBoxName;

        //internal enum ePictureBoxes
        //{
        //    pictureBoxPicture1,
        //    pictureBoxPicture2,
        //    pictureBoxPicture3,
        //    pictureBoxPicture4,
        //    pictureBoxPicture5
        //}

        public Hashtable HasTheYearBeenChosen
        {
            get
            {
                return r_HasTheYearBeenChosen;
            }
        }


        public FacebookObjectCollection<User> UsersFriends
        {
            get
            {
                return r_UsersFriends;
            }
        }

        public User PreferredUser
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

        public FormTimeLineInfo(FormMain i_MainForm)
        {
            InitializeComponent();
            r_FacebookAppManager = i_MainForm.FacebookAppManager;
            r_UsersFriends = r_FacebookAppManager.GetFriends;
            r_YearsChoosenByUser = new List<int>();
            //fetchListYears();

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
            if (HasTheYearBeenChosen.Count == 5)//areTheComboBoxesChecked())
            {
                if (PreferredUser != null)
                {
                    Dictionary<int, UserPhotoInfo> timeLinePhotos;
                    fetchChoosenYearsFromTheHastable();
                    timeLinePhotos = r_FacebookAppManager.GetTimeLinePictures(PreferredUser, r_YearsChoosenByUser);
                    displayThePicturesInThePictureBoxes(timeLinePhotos);

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


        //private void displayThePicturesInThePictureBoxes2(Dictionary<int, UserPhotoInfo> i_TimeLinePhotos)
        //{
        //    int length = i_TimeLinePhotos.Keys.Count;

        //    foreach (int year in i_TimeLinePhotos.Keys)
        //    {

        //    }
        //}


        private void displayThePicturesInThePictureBoxes(Dictionary<int, UserPhotoInfo> i_TimeLinePhotos)
        {
            resetTheImagesInThePictureBoxes();
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
            // sortThePictureBoxList(r_PictureBoxesNames);
            // attachYearsToPictureBoxesNames(r_PictureBoxesNames);
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

        private void attachYearsToPictureBoxesNames(List<PictureBox> i_PictureBoxesNames)
        {
            int length = r_YearsChoosenByUser.Count;
            int x = 0;

            foreach (PictureBox picBox in i_PictureBoxesNames)
            {
                if (x < length)
                {
                    picBox.Name += r_YearsChoosenByUser[x];
                    x++;
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
                MessageBox.Show(string.Format("This year has already been chosen!{0}Make Sure you choose another one", Environment.NewLine));
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
