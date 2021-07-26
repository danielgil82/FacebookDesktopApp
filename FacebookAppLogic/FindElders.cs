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
    internal class FindElders
    {
        private readonly FacebookObjectCollection<ElderUser> r_PotentialElderToHelp;
        private readonly User r_User;
        private City m_UsersCurrentCity;
        private byte m_UpperAgeRange;
        private byte m_LowerAgeRange;
        private eGender m_PreferredGender;

        internal enum eGender
        {
            female,
            male,
            both
        }

        internal FindElders(User i_User)
        {
            r_User = i_User;
            UsersCurrentCity = r_User.Hometown;
            r_PotentialElderToHelp = new FacebookObjectCollection<ElderUser>();
        }

        internal FacebookObjectCollection<ElderUser> PotentialElderToHelp
        {
            get
            {
                return r_PotentialElderToHelp;
            }
        }

        internal City UsersCurrentCity
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

        internal FacebookObjectCollection<User> FindPotentialEldershUsersConditions(string i_PreferredGender, string i_PreferredAgeRange)
        {
            FacebookObjectCollection<User> PotentialElders = new FacebookObjectCollection<User>();

            if (r_PotentialElderToHelp.Count > 0)
            {
                r_PotentialElderToHelp.Clear();
            }

            ageConversionFromString(i_PreferredAgeRange);
            eldersThatMatchUsersPreferredGender(i_PreferredGender);
            addPotentialUsers(PotentialElders);

            return PotentialElders;
        }

        private void addPotentialUsers(FacebookObjectCollection<User> io_PotentialEldersList)
        {
            foreach (ElderUser CurrenUserToAdd in r_PotentialElderToHelp)
            {
                io_PotentialEldersList.Add(CurrenUserToAdd.CurrentElderUser);
            }

            if (io_PotentialEldersList.Count == 0)
            {
                throw new ArgumentException("No potential elders we're found");
            }
        }

        internal class ElderUser
        {
            internal string Name { get; set; }

            internal User CurrentElderUser { get; }

            internal ElderUser(User i_User)
            {
                CurrentElderUser = i_User;
                Name = CurrentElderUser.Name;
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

        private void eldersThatMatchUsersPreferredGender(string i_PreferredGender)
        {
            m_PreferredGender = (eGender)Enum.Parse(typeof(eGender), i_PreferredGender);
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
                checkPotentialEldersConditionsByAgeAndCity(user);
            }
        }

        private void eldersBySpecificGender()
        {
            foreach (User CurrentUser in r_User.Friends)
            {
                if ((CurrentUser.Gender == User.eGender.female && m_PreferredGender == eGender.female)
                    || (CurrentUser.Gender == User.eGender.male && m_PreferredGender == eGender.male))
                {
                    checkPotentialEldersConditionsByAgeAndCity(CurrentUser);
                }
            }
        }

        private void checkPotentialEldersConditionsByAgeAndCity(User i_CurrentUser)
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

            if (int.TryParse(usersBirthYear[2], out yearToParse))
            {
                elderAge = currentYear - yearToParse;
            }
            else
            {
                throw new ArgumentException("Couldn't calculate the users age.");
            }

            return elderAge;
        }
    }
}
