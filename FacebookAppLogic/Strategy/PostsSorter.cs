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
        /// </summary>
        //public ISortStrategy SortStrategy { get; set; }

        /// <summary>
        /// The new implementation more user friendly because, now the user has more options.
        /// </summary>
        public Func<Post, int, bool> SortStrategyFunc { get; set; }
      
        /// <summary>
        /// First implementation not friendly because I gave only two options as a Filter
        /// </summary>
        // public Func<Post,bool> SortStrategyMethod { get; set; }

        public FacebookObjectCollection<Post> Filter(FacebookObjectCollection<Post> i_PostsCollection, int i_ChosenYearByUserAsPostsFilter)
        {
            foreach (var post in i_PostsCollection)
            {
                if (SortStrategyFunc.Invoke(post, i_ChosenYearByUserAsPostsFilter))
                {
                    r_FilteredPosts.Add(post);
                }

                
                //if (SortStrategyMethod.Invoke(post))
                //{
                //    r_FilteredPosts.Add(post);
                //}
            }

            return r_FilteredPosts;
        }
    }
}
