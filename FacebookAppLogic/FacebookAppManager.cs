using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookAppLogic
{
    public class FacebookAppManager
    {
        private readonly User r_LoggedInUser;
        private FindElders m_FindElders;
        private TimeLineInfo m_TimeLineInfo;

        public FacebookAppManager(User i_LoggedInUser)
        {
            r_LoggedInUser = i_LoggedInUser;
        }

        public string UsersBirthday
        {

            get
            {
                string Birthday = string.Empty;

                try
                {
                    Birthday = LoggedInUser.Birthday;
                }
                catch (Exception)
                {
                    throw new Exception("Couldn't retrieve users birthday ");
                }

                return Birthday;
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

        public FacebookObjectCollection<User> FindEldersThatMatchUsersConditions(string i_PreferredGender, string i_PreferredAgeRange)
        {
            if (m_FindElders == null)
            {
                m_FindElders = new FindElders(r_LoggedInUser);
            }

            return m_FindElders.FindEldersThatMatchUsersConditions(i_PreferredGender, i_PreferredAgeRange);
        }


        public User LoggedInUser
        {
            get
            {
                return r_LoggedInUser;
            }
        }

        public FacebookObjectCollection<Photo> TimeLinePhotos()
        {


            if (m_TimeLineInfo == null)
            {
                m_TimeLineInfo = new TimeLineInfo();
            }

            m_TimeLineInfo.FetchTimeLinePhotos();
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
    }
}
