using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.DevTools.LayerTree;
using FacebookAppLogic;
using FacebookWrapper.ObjectModel;
using Microsoft.Win32;

namespace BasicFacebookFeatures
{
    internal partial class FormFindElderToHelp : Form
    {
        private readonly FacebookAppManager r_FacebookAppManager;
        private readonly List<string> r_AgeRangeList;
        private FacebookObjectCollection<User> m_PotentialEldersList = null;

        internal string PreferredAgeRange { get; private set; }

        internal string PreferredGender { get; private set; }

        internal FormFindElderToHelp(FormMain i_FormMain)
        {
            InitializeComponent();
            r_FacebookAppManager = i_FormMain.FacebookAppManager;
            r_AgeRangeList = new List<string>();
            initAgeRangeList();
        }

        private void initAgeRangeList()
        {
            for (int i = 65 ; i < 125 ; i += 5)
            {
                r_AgeRangeList.Add(string.Format("{0} - {1}", i + 1, i + 5));
            }
            
            checkedListBoxAgeRange.DataSource = r_AgeRangeList;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void Back()
        {
            this.Close();
        }

        private void buttonFindElderToHelp_Click(object sender, EventArgs e)
        {
            if(pictureBoxElderPicture.Image != null)
            {
                pictureBoxElderPicture.Image = null;
            }

            if (listBoxPotentialElders.Items.Count > 0)
            {
                listBoxPotentialElders.Items.Clear();
            }

            if (!string.IsNullOrEmpty(PreferredGender) && !string.IsNullOrEmpty(PreferredAgeRange))
            {
                try
                {
                    m_PotentialEldersList = r_FacebookAppManager.GetPotentialElders(PreferredGender, PreferredAgeRange);
                    fetchPotentialElders();
                    displaySelectedElderUser();
                    PreferredGender = string.Empty;
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("You must choose Age Range and Gender prefrence!");
            }
        }

        private void displaySelectedElderUser()
        {
            if (listBoxPotentialElders.SelectedItems.Count == 1)
            {
                User SelectedUser = listBoxPotentialElders.SelectedItem as User;

                if (SelectedUser.PictureNormalURL != null)
                {
                    pictureBoxElderPicture.LoadAsync(SelectedUser.PictureNormalURL);
                }
                else
                {
                    pictureBoxElderPicture.Image = pictureBoxElderPicture.ErrorImage;
                }
            }
        }

        private void fetchPotentialElders()
        {
            listBoxPotentialElders.Items.Clear();
            listBoxPotentialElders.DisplayMember = "Name";

            foreach (User user in m_PotentialEldersList)
            {
                listBoxPotentialElders.Items.Add(user);
            }

            if (listBoxPotentialElders.Items.Count == 0)
            {
                MessageBox.Show("No potential elders to retrieve");
            }
        }

        private void checkedListBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreferredGender = (sender as CheckedListBox).SelectedItem.ToString().ToLower();
            makeTheOtherListBoxOptionsDisabled(sender);
        }

        private void checkedListBoxAgeRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreferredAgeRange = (sender as CheckedListBox).SelectedItem.ToString();
            makeTheOtherListBoxOptionsDisabled(sender);
        }

        private void makeTheOtherListBoxOptionsDisabled(object i_Sender)
        {
            CheckedListBox currentCheckedListBox = i_Sender as CheckedListBox;

            if (currentCheckedListBox != null)
            {
                int index = currentCheckedListBox.SelectedIndex;
                int count = currentCheckedListBox.Items.Count;

                for (int x = 0 ; x < count ; x++)
                {
                    if (index != x)
                    {
                        currentCheckedListBox.SetItemChecked(x, false);
                    }
                }
            }
        }

        private void listBoxPotentialElders_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedElderUser();
            string name = (sender as ListBox).SelectedItem.ToString();
            MessageBox.Show("Good luck with the helping this elderly " + name);
        }
    }
}
