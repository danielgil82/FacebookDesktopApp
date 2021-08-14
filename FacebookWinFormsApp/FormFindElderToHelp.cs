using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
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
        private readonly FacebookAppManagerFacade r_FacebookAppManager;
        private readonly List<string> r_AgeRangeList;
        private FacebookObjectCollection<User> m_PotentialEldersList = null;

        internal string PreferredAgeRange { get; private set; }

        internal string PreferredGender { get; private set; }

        internal FormFindElderToHelp(FormMain i_FormMain)
        {
            InitializeComponent();
            r_FacebookAppManager = i_FormMain.FacebookAppManagerFacade;
            r_AgeRangeList = new List<string>();
            initAgeRangeList();
        }

        private void initAgeRangeList()
        {
            // Checking weather me and Sigalit we'll be shown
            r_AgeRangeList.Add("20 - 25");
            for (int i = 65; i < 125; i += 5)
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
            /// in line 70 the call for clear the data source already clearing everything.
            /// 
            //if(PictureBoxImageNormalElder.Image != null)
            //{
            //    PictureBoxImageNormalElder.Image = null;
            //}

            if (listBoxPotentialElders.Items.Count != 0)
            {
                clearTheDataSourceAndEldersList();
            }

            if (!string.IsNullOrEmpty(PreferredGender) && !string.IsNullOrEmpty(PreferredAgeRange))
            {
                new Thread(() =>
                   {
                       try
                       {

                           m_PotentialEldersList = r_FacebookAppManager.GetPotentialElders(PreferredGender, PreferredAgeRange);
                           fetchPotentialElders();
                           //photoBindingSource.DataSource = m_PotentialEldersList;
                           //displaySelectedElderUser();
                           //PreferredGender = string.Empty;
                       }
                       catch (ArgumentException ex)
                       {
                           this.Invoke(new Action((() => MessageBox.Show(ex.Message))));
                       }
                   }).Start();
            }
            else
            {
                MessageBox.Show("You must choose Age Range and Gender preference!");
            }
        }

        private void clearTheDataSourceAndEldersList()
        {
            m_PotentialEldersList.Clear();
            photoBindingSource.ResetBindings(false);
        }

        /// <summary>
        /// using the data source of photoBindingSource 
        /// </summary>
        private void fetchPotentialElders()
        {
            listBoxPotentialElders.Invoke(
            new Action(
               () =>
           photoBindingSource.DataSource = m_PotentialEldersList
                    ));
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

                for (int x = 0; x < count; x++)
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
            if (listBoxPotentialElders.SelectedIndex > -1)
            {
                this.Invoke(new Action(
                    () =>
                    {
                        string name = (sender as ListBox).SelectedItem.ToString();
                        MessageBox.Show("Good luck with the helping this elderly " + name);
                    }));
            }
        }
    }
}
