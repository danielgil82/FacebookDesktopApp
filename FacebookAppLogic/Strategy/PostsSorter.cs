using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    internal class PostsSorter //Mechanism
    {
        private readonly FacebookObjectCollection<Post> r_FilteredPosts = new FacebookObjectCollection<Post>();
        /// <summary>
        /// maybe in the future i'd to make a sort strategy via interface
        /// 
        /// </summary>
        //public ISortStrategy SortStrategy { get; set; }

        public Func<Post, bool> SortStrategyMethod { get; set; }

        public FacebookObjectCollection<Post> Sort(FacebookObjectCollection<Post> i_PostsCollection)
        {
            foreach (var post in i_PostsCollection)
            {
                if (SortStrategyMethod.Invoke(post))
                {
                    r_FilteredPosts.Add(post);
                }
            }

            return r_FilteredPosts;
        }
    }
}
