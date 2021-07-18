using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class ElderToHelp
    {
        private readonly FacebookObjectCollection<ElderUsers> r_PotentialElderToHelp = 
                                            new FacebookObjectCollection<ElderUsers>();



        public ElderToHelp()
        {
        }


        private class ElderUsers
        {
            private string m_City;
            private string m_Gender;

            public string city
            {
                get
                {
                    return m_City;

                }
                set
                {
                    m_City = value;
                }
            }

            public string gender
            {
                get;
                set;
            }
        }
    }
}
