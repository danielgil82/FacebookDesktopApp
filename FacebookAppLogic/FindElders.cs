using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class FindElders
    {
        private readonly FacebookObjectCollection<ElderUser> r_PotentialElderToHelp;
        private readonly User r_User;
        private City m_UsersCurrentCity;
        private eGender m_PreferredGender;
        private byte m_UpperAgeRange;
        private byte m_LowerAgeRange;

        public FindElders(User i_User, string i_PreferredGender, string i_PreferredAgeRange)
        {
            r_User = i_User;
            UsersCurrentCity = r_User.Hometown;
            r_PotentialElderToHelp = new FacebookObjectCollection<ElderUser>();
            ageConversionFromString(i_PreferredAgeRange);
            eldersThatMatchUsersPreferredGender(i_PreferredGender);
        }

        public class ElderUser 
        {
            public string Name { get; set; }

            public User CurrentElderUser { get; }

            public ElderUser(User i_User)
            {
                CurrentElderUser = i_User;
                Name = CurrentElderUser.Name;
            }
        }

        public FacebookObjectCollection<ElderUser> PotentialElderToHelp
        {
            get
            {
                return r_PotentialElderToHelp;
            }
        }

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
        

        private void ageConversionFromString(string i_AgeRange)
        {
            string[] ageRange = i_AgeRange.Split('-');
         
            if (!(byte.TryParse(ageRange[0], out m_LowerAgeRange) && byte.TryParse(ageRange[1], out m_UpperAgeRange)))
            {
                throw new ArgumentException("Couldn't convert the age !");
            }
        }


        private void eldersThatMatchUsersPreferredGender(string i_Gender)
        {
            m_PreferredGender = (eGender)Enum.Parse(typeof(eGender), i_Gender);

            switch (m_PreferredGender)
            {
                case eGender.female:
                case eGender.male:
                    eldersBySpecificGender();
                    break;
                case eGender.both:
                    eldersWithoutSpecificGender();
                    break;
            }
        }

        private void eldersWithoutSpecificGender()
        {
            foreach (User user in r_User.Friends)
            {
                checkPotentialEldersConditions(user);
            }
        }

        private void eldersBySpecificGender()
        {
            foreach (User user in r_User.Friends)
            {
                if ((user.Gender == User.eGender.female && m_PreferredGender == eGender.female)
                    || user.Gender == User.eGender.male && m_PreferredGender == eGender.male)
                {
                    checkPotentialEldersConditions(user);
                }
            }
        }

        private void checkPotentialEldersConditions(User i_CurrentUser)
        {
            int usersAge = calculateUsersAge(i_CurrentUser);

            if (i_CurrentUser.Location == UsersCurrentCity && usersAge >= m_LowerAgeRange && usersAge <= m_UpperAgeRange)
            {
                PotentialElderToHelp.Add(new ElderUser(i_CurrentUser));
            }
        }

        

        private int calculateUsersAge(User i_CurrentUser)
        {
            int currentYear = DateTime.Now.Year;
            int yearToParse;
            int elderAge = 0;

            string[] usersBirthYear = i_CurrentUser.Birthday.Split('/');

            try
            {
                if (Int32.TryParse(usersBirthYear[2], out yearToParse))
                {
                    elderAge = currentYear - yearToParse;
                }

            }
            catch (Exception ex)
            {

                throw new ArgumentException("Couldn't calculate the users age.");
            }

            return elderAge;
        }
    }
}
