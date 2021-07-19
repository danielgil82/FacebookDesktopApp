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
     //   private readonly User r_CurrentUser; 
       // private readonly FacebookObjectCollection<User> r_ListOfElders;

        public FormFindElderToHelp(FormMain i_FormMain)
        {
            r_FacebookAppManager = i_FormMain.FacebookAppManager;
        //    r_CurrentUser = i_FormMain.FacebookAppManager.LoggedInUser;
         //   r_CurrentUser = r_FacebookAppManager.LoggedInUser;
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
            r_FacebookAppManager.PotentialElders = new PotentialElders(r_FacebookAppManager.LoggedInUser, checkedListBoxGenderPrefrence.CheckedItems.ToString(), 
                                                    checkedListBoxAgeRange.CheckedItems.ToString()); 
            
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
