using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using FacebookAppLogic;
using FacebookAppLogic.Iterator;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal partial class FormFindElderToHelp : Form 
    {
        private readonly FacebookAppManagerFacade r_FacebookAppManager;
        private readonly List<string> r_AgeRangeList;
        private FacebookObjectCollection<User> m_PotentialEldersList = null;
        //private UserAggregate m_UsersAggregate;

        //public IEnumerator<User> UserToAdd { get; set; }

        public ColorfulBackableVisitor ColorfulBackableVisitor { get; set; }

        internal string PreferredAgeRange { get; private set; }

        internal string PreferredGender { get; private set; }

        internal FormFindElderToHelp(FormMain i_FormMain)
        {
            InitializeComponent();
            r_FacebookAppManager = i_FormMain.FacebookAppManagerFacade;
            r_AgeRangeList = new List<string>();
            initAgeRangeList();
            ColorfulBackableVisitor = new ColorfulBackableVisitor();
            ColorfulBackableVisitor.BackButton = buttonBack;
        }

        private void initAgeRangeList()
        {
            // Added this age manually just to test.
            r_AgeRangeList.Add("20 - 25");
            for (int i = 65; i < 125; i += 5)
            {
                r_AgeRangeList.Add(string.Format("{0} - {1}", i + 1, i + 5));
            }

            checkedListBoxAgeRange.DataSource = r_AgeRangeList;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ColorfulBackableVisitor.Back(this);
           // Back();
        }

        private void Back()
        {
            this.Close();
        }

        private void buttonFindElderToHelp_Click(object sender, EventArgs e)
        {
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
