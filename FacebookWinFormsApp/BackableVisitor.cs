using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    internal class BackableVisitor
    {
        public void Back(Form i_CurrentForm)
        {
            i_CurrentForm.Close();
        }
    }
}
