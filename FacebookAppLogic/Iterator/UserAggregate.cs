using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic.Iterator
{
    public class UserAggregate : IEnumerable<User> //Aggregate
    {
        public ICollection<User> PotentialElderUsers { get; set; }

        public UserAggregate(ICollection<User> i_PotentialElderUsers)
        {
            PotentialElderUsers = i_PotentialElderUsers;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return PotentialElderUsers.GetEnumerator();
        }
      
        public IEnumerator<User> GetEnumerator()
        {
            foreach (var PotentialElder in PotentialElderUsers)
            {
                yield return PotentialElder;
            }

        }

        /// <summary>
        /// If one day in the future i'd to use the enumerator for other purposes , maybe like filtering or
        /// protective Iterator a thing that I can't get via the UserAggergate iterator, so I left this implementation in comments.
        /// </summary>
        /// <returns></returns>


        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return GetEnumerator();
        //}

        //private class UsersIterator : IEnumerator<User> //Iterator
        //{
        //    private int m_CurrentIndex = -1;
        //    private int m_OrigirnalCount;
        //    private UserAggregate m_UserAggregate;

        //    public UsersIterator(UserAggregate i_User)
        //    {
        //        m_UserAggregate = i_User;
        //        m_OrigirnalCount = i_User.PotentialElderUsers.Count;

        //    }

        //    public User Current
        //    {
        //        get { return m_UserAggregate.PotentialElderUsers[m_CurrentIndex]; }
        //    }

        //    object IEnumerator.Current
        //    {
        //        get { return Current; }
        //    }

        //    public void Dispose()
        //    {
        //        Reset();
        //    }

        //    public bool MoveNext()
        //    {
        //        if (m_OrigirnalCount != m_UserAggregate.PotentialElderUsers.Count)
        //        {
        //            throw new Exception("Don't you ever change the collection during a traversal");
        //        }

        //        m_CurrentIndex++;

        //        return m_CurrentIndex < m_UserAggregate.PotentialElderUsers.Count;
        //    }

        //    public void Reset()
        //    {
        //        m_CurrentIndex = -1;
        //    }

        //}
    }
}
