using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookAppLogic
{
    public class FacebookAppManagerFacade
    {
        private readonly User r_LoggedInUser;
        private FindEldersLogic m_FindEldersLogic;
        private LookHowSomeoneChangeLogic m_LookHowSomeoneChangedLogic;

        public FacebookAppManagerFacade(User i_LoggedInUser)
        {
            r_LoggedInUser = i_LoggedInUser;
        }

        public User LoggedInUser
        {
            get
            {
                return r_LoggedInUser;
            }
        }

        public void Logout()
        {
            try
            {
                FacebookService.LogoutWithUI();
            }
            catch (Exception)
            {
                throw new Exception("Couldn't log out successfully.");
            }
        }

        public string GetBirthday
        {
            get
            {
                string birthday = string.Empty;

                try
                {
                    birthday = LoggedInUser.Birthday;
                }
                catch (Exception)
                {
                    throw new Exception("Couldn't retrieve users birthday.");
                }

                return birthday;
            }
        }

        public FacebookObjectCollection<User> GetFriends
        {
            get
            {
                FacebookObjectCollection<User> userFriends;

                try
                {
                    userFriends = r_LoggedInUser.Friends;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return userFriends;
            }
        }

        public FacebookObjectCollection<Event> GetEvents
        {
            get
            {
                FacebookObjectCollection<Event> userEvents;

                try
                {
                    userEvents = r_LoggedInUser.Events;
                }
                catch (Exception)
                {
                    throw new ArgumentException("Couldn't fetch user's events");
                }

                return userEvents;
            }
        }

        public FacebookObjectCollection<Group> GetGroups
        {
            get
            {
                FacebookObjectCollection<Group> userGroups;

                try
                {
                    userGroups = r_LoggedInUser.Groups;
                }
                catch (Exception)
                {
                    throw new ArgumentException("Couldn't fetch user's groups");
                }

                return userGroups;
            }
        }

        public FacebookObjectCollection<User> GetPotentialElders(string i_PreferredGender, string i_PreferredAgeRange)
        {
            if (m_FindEldersLogic == null)
            {
                m_FindEldersLogic = new FindEldersLogic(r_LoggedInUser);
            }

            return m_FindEldersLogic.FindPotentialEldersUsersConditions(i_PreferredGender, i_PreferredAgeRange);
        }

        public List<Photo> GetChosenFriendProfilePictures(User i_ChosenUser, List<int> i_YearsChosen)
        {
            if (m_LookHowSomeoneChangedLogic == null)
            {
                m_LookHowSomeoneChangedLogic = new LookHowSomeoneChangeLogic();
            }

            m_LookHowSomeoneChangedLogic.FetchFriendTimeLinePictures(i_ChosenUser, i_YearsChosen);

            return m_LookHowSomeoneChangedLogic.FriendProfilePictures;
        }
    }
}