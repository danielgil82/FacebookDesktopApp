using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    internal class Sorter //Mechanism
    {
        private readonly FacebookObjectCollection<Post> m_FilteredPosts = new FacebookObjectCollection<Post>();

     //   public ISortStrategy SortStrategy { get; set; }
        public Func<Post, bool> SortStrategyMethod { get; set; }

        public FacebookObjectCollection<Post> Sort(FacebookObjectCollection<Post> i_PostsCollection)
        {
            foreach (var post in i_PostsCollection)
            {
                if (SortStrategyMethod.Invoke(post))
                {
                    m_FilteredPosts.Add(post);
                }
            }

            return m_FilteredPosts;
        }


        //internal class PostWrittenAfter2018 : ISortStrategy
        //{
        //private bool ShouldAddPostsWrittenAfter2018(Post i_Post)
        //{
        //    return i_Post.CreatedTime.Value.Year >= 2018;
        //}
        ////}

        ////internal class PostWrittenBefore2018 : ISortStrategy
        ////{
        //    private bool ShouldAddPostsWrittenBefore2018(Post i_Post)
        //    {
        //        return i_Post.CreatedTime.Value.Year < 2018;
        //    }
        //}
    }
}
