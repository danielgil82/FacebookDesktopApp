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
        private readonly User r_LoginUser;

        public FacebookAppManager(User i_LoggedInUser)
        {
            r_LoginUser = i_LoggedInUser;
        }

        public User LoginUser
        {
            get
            {
                return r_LoginUser;
            }
        }

        public FacebookObjectCollection<User> GetFriends
        {
            get
            {
                FacebookObjectCollection<User> userFriends;

                try
                {
                    userFriends = r_LoginUser.Friends;
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
