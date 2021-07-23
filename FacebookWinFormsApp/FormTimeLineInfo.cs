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

namespace BasicFacebookFeatures
{
    public partial class FormTimeLineInfo : Form
    {
        private readonly FacebookAppManager r_FacebookAppManager;
        private readonly FacebookObjectCollection<User> r_UsersFriends = null;
        private User m_PreferredUser;

        public User PreferredUser { get; private set; }


        public FacebookObjectCollection<User> UsersFriends { get; private set; }


        public FormTimeLineInfo(FormMain i_MainForm)
        {
            InitializeComponent();
            r_FacebookAppManager = i_MainForm.FacebookAppManager;
            UsersFriends = r_FacebookAppManager.GetFriends;
            fetchYearsToChoose();
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
                        cmBox.Items.Add(i.ToString());
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
            if (areTheComboBoxesChecked() && PreferredUser != null)
            {
                Photo photo = new Photo();
            //    photo.
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
    }
}
