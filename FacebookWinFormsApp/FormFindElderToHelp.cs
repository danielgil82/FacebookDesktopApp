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
    public partial class FormFindElderToHelp : Form
    {
        private FormFindElderToHelp m_ElderToHelp;

        public FormFindElderToHelp()
        {
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
    }
}
