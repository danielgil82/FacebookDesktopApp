using FacebookAppLogic;
using FacebookWrapper.ObjectModel;
using System;
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
    public partial class FormTimeLineInfo : Form
    {
        private readonly FacebookAppManager r_FacebookAppManager;
        private readonly FacebookObjectCollection<User> r_UsersFriends = null;
        private readonly List<int> r_YearsChoosenByUser;
        private User m_PreferredUser;
        
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
            fetchListYears();

          //  fetchYearsToChoose();
        }

        private void fetchListYears()
        {
            for (int i = 2012 ; i < 2022 ; i++)
            {
                r_YearsChoosenByUser.Add(i);
            }

            checkedListBoxYears.DataSource = r_YearsChoosenByUser;
        }

        private void fetchYearsToChoose()
        {
            foreach (Control control in this.panelYearChoosing.Controls)
            {
                if (control is ComboBox) // check if control is comboBOx
                {
                    ComboBox cmBox = control as ComboBox;

                    for (int i = 2015; i < 2022; i++)
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
            if (checkedListBoxYears.CheckedItems.Count == 5)
            {
                if (PreferredUser != null)
                {
                    Dictionary<int, UserPhotoInfo> timeLinePhotos;
                    fetchChoosenYearsFromComboBoxes();
                    timeLinePhotos = r_FacebookAppManager.GetTimeLinePictures(PreferredUser, r_YearsChoosenByUser);
                    fetchPhotosIntoThePicturesBoxes(timeLinePhotos);
                }
                else
                {
                    MessageBox.Show(string.Format("You must choose a friend, via Display Friends Button!!", Environment.NewLine));
                }
            }
            else
            {
                MessageBox.Show(string.Format("Oops...{0}Please select 5 options in the years section.", Environment.NewLine));
            }
            //if (areTheComboBoxesChecked())
            //{
            //    if(PreferredUser != null)
            //    {
            //        Dictionary<int, UserPhotoInfo> timeLinePhotos;
            //        fetchChoosenYearsFromComboBoxes();
            //        timeLinePhotos = r_FacebookAppManager.GetTimeLinePictures(PreferredUser, r_YearsChoosenByUser);
            //        fetchPhotosIntoThePicturesBoxes(timeLinePhotos);
            //    }
            //    else
            //    {
            //        MessageBox.Show(string.Format("You must choose a friend, via Display Friends Button!!", Environment.NewLine));
            //    }
            //}
            //else
            //{
            //    MessageBox.Show(string.Format("Oops...{0}Please select 5 options in the years section.", Environment.NewLine));
            //}
        }

        private void fetchPhotosIntoThePicturesBoxes(Dictionary<int, UserPhotoInfo> i_TimeLinePhotos)
        {
            
        }

        private void fetchChoosenYearsFromComboBoxes()
        {
            foreach (Control control in this.panelYearChoosing.Controls)
            {
                if (control is ComboBox)
                {
                    ComboBox cmBox = control as ComboBox;
                    r_YearsChoosenByUser.Add(Int32.Parse(cmBox.SelectedItem.ToString()));
                }
            }
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

        private void checkedListBoxYears_SelectedIndexChanged(object sender, EventArgs e)
        {     
        }
    }
}
