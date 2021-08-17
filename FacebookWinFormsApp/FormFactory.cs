using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.DevTools.CSS;

namespace BasicFacebookFeatures
{
    public static class FormFactory
    {
        private static FormMain s_FormMain = null; 
        
        public enum eTypeOfForm
        {
            FormMain,
            FormFindElderToHelp,
            FormHowSomeoneChanged
        }

        public static Form CreateForm(string i_FormToCreate)
        {
            Form formToCreate;
            eTypeOfForm typeOfForm = (eTypeOfForm)Enum.Parse(typeof(eTypeOfForm), i_FormToCreate);
            
            switch (typeOfForm)
            {
                case eTypeOfForm.FormMain:
                    s_FormMain = new FormMain();
                    formToCreate = s_FormMain;
                    break;
                case eTypeOfForm.FormFindElderToHelp:
                    formToCreate = new FormFindElderToHelp(s_FormMain);
                    break;
                case eTypeOfForm.FormHowSomeoneChanged:
                    formToCreate = new FormHowSomeoneChanged(s_FormMain);
                    break;
                default:
                    throw new Exception("Something went wrong.");
            }

            return formToCreate;
        }
    }
}
