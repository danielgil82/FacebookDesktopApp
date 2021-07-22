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
        private List<string> m_YearsToChoose;

        public FacebookObjectCollection<User> UsersFriends { get; private set; }


        public FormTimeLineInfo(FormMain i_MainForm)
        {
            InitializeComponent();
            r_FacebookAppManager = i_MainForm.FacebookAppManager;
            UsersFriends = r_FacebookAppManager.GetFriends;
            m_YearsToChoose = new List<string>();
         //   fetchYearsToChoose();

        }

        private void fetchYearsToChoose()
        {

            foreach(Control control in this.splitContainer1.Panel1.Controls)
            {
                if (control is ComboBox) // check if control is comboBOx
                {
                    ComboBox comboBox = control as ComboBox;
                    
                    if(comboBox.Name.StartsWith("combo"))
                    {
                        for (int i = 2015; i < 2022; i++)
                        {
                            comboBox.Items.Add(i);
                        }
                    }

                    
                }
            }

           // fetchYearsToComboBoxes();
        }

        private void fetchYearsToComboBoxes()
        {
            foreach (Control control in this.Controls) // you can change cntrls.Controls to your container or if its the form that holds the combobox then use this.Controls
            {
                if (control is ComboBox) // check if control is checkbox
                {
                    (control as ComboBox).DataSource = m_YearsToChoose.ToString();
                }

            }

            //foreach (ComboBox currentComboBox in this.Controls.OfType<ComboBox>())
            //{
            //    currentComboBox.DataSource = m_YearsToChoose;
            //    currentComboBox.DisplayMember = "Name";

            //}
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
    }
}
