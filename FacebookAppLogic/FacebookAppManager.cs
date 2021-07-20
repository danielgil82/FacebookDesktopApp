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

        public FindElders FindElders
        {
            get
            {
                return m_FindElders;
            }

            set
            {
                if(m_FindElders == null)
                {
                    m_FindElders = value;

                }
            }
        }


        public FacebookAppManager(User i_LoggedInUser)
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
