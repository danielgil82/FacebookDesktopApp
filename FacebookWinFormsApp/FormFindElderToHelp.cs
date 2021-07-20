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

namespace BasicFacebookFeatures
{
    public partial class FormFindElderToHelp : Form
    {
        private readonly FacebookAppManager r_FacebookAppManager;
        private StringBuilder m_GenderStringBuilder = new StringBuilder();
        public FormFindElderToHelp(FormMain i_FormMain)
        {
            r_FacebookAppManager = i_FormMain.FacebookAppManager;
            fetchCheckedListBoxGenderData();
            //fetchCheckedListBoxAgeRangeData();
            InitializeComponent();
        }

        private void fetchCheckedListBoxGenderData()
        {
            if (checkedListBoxAgeRange.Items.Count > 0)
            {
                MessageBox.Show("Yo what's going on ");
            }
            //checkedListBoxGender.Items.Clear();
            m_GenderStringBuilder.Clear();
            foreach (string gender in Enum.GetNames(typeof(eGender)))
            {
                m_GenderStringBuilder.AppendLine(gender);
            }

            checkedListBoxGender.Text = m_GenderStringBuilder.ToString();
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
            if (checkedListBoxGender.SelectedItem != null && checkedListBoxAgeRange.SelectedItem != null)
            {
                try
                {
                    r_FacebookAppManager.FindElders = new FindElders(r_FacebookAppManager.LoggedInUser, checkedListBoxGender.SelectedItem.ToString().ToLower(),
                        checkedListBoxAgeRange.SelectedItem.ToString().ToLower());
                    fetchPotentialElders();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void fetchPotentialElders()
        {
            listBoxPotentialElders.Items.Clear();
            listBoxPotentialElders.DisplayMember = "Name";

            try
            {
                foreach (FindElders.ElderUser user in r_FacebookAppManager.FindElders.PotentialElderToHelp)
                {
                    listBoxPotentialElders.Items.Add(user.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBoxPotentialElders.Items.Count == 0)
            {
                MessageBox.Show("No potential elders to retrieve");
            }
        }

        private void checkedListBoxGenderPreference_SelectedIndexChanged(object sender, EventArgs e)
        {
            makeTheOtherListBoxOptionsDisabled(sender);
        }

        private void checkedListBoxAgeRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            makeTheOtherListBoxOptionsDisabled(sender);
        }

        private void makeTheOtherListBoxOptionsDisabled(object i_Sender)
        {
            CheckedListBox currentCheckedListBox = i_Sender as CheckedListBox;

            if (currentCheckedListBox != null)
            {
                int index = currentCheckedListBox.SelectedIndex;
                int count = currentCheckedListBox.Items.Count;

                for (int x = 0; x < count; x++)
                {
                    if (index != x)
                    {
                        currentCheckedListBox.SetItemChecked(x, false);
                    }
                }
            }
        }
    }
}
