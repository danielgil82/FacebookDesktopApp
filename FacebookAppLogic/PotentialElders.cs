using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class PotentialElders
    {
        private readonly FacebookObjectCollection<User> r_PotentialElderToHelp;
        private readonly User r_User;
        private City m_UsersCurrentCity;
        private eGender m_PreferredGender;
        private byte m_UpperAgeRange;
        private byte m_LowerAgeRange;
       
        
        public City UsersCurrentCity
        {
            get
            {
                return m_UsersCurrentCity;
            }
            set
            {
                m_UsersCurrentCity = value;
            }
        }

        public FacebookObjectCollection<User> PotentialElderToHelp{ get;}

        public PotentialElders(User i_User, string i_Gender, string i_AgeRange)
        {
            r_User = i_User;
            r_PotentialElderToHelp = new FacebookObjectCollection<User>();
            UsersCurrentCity = r_User.Hometown;
            ageConversion(i_AgeRange);
            eldersThatMatchUsersPreferredGender(i_Gender);
        }

        private void ageConversion(string i_AgeRange)
        {
            
        }


        private void eldersThatMatchUsersPreferredGender(string i_Gender)
        {

            m_PreferredGender = (eGender)Enum.Parse(typeof(eGender), i_Gender);

            switch (m_PreferredGender)
            {
                case eGender.Male:
                case eGender.Female:
                    eldersBySpecificGender();
                    break;
                case eGender.Both:
                    eldersWithoutSpecificGender();
                    break;
            }
        }

        private void eldersWithoutSpecificGender()
        {
        }

        private void eldersBySpecificGender()
        {
            foreach (User user in r_User.Friends)///////continue from here
            {
               
            }
        }


        //public class ElderUsers
        //{
        //    private User i_User;


        //}
    }
}
