using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public FormFindElderToHelp(FormMain i_FormMain)
        {
            r_FacebookAppManager = i_FormMain.FacebookAppManager;
            InitializeComponent();
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
            try
            {
                r_FacebookAppManager.PotentialElders = new PotentialElders(r_FacebookAppManager.LoggedInUser, "female",
                    "20-25");
                fetchPotentialElders();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fetchPotentialElders()
        {
            listBoxPotentialElders.Items.Clear();
            listBoxPotentialElders.DisplayMember = "Name";

            try
            {
                foreach (User user in r_FacebookAppManager.PotentialElders.PotentialElderToHelp)
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
