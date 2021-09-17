using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    internal class PostsConcreteMethodSorter
    {
        internal bool IsThePostMatchTheYear(Post i_Post, int i_ChosenYearByTheUser)
        {
            return i_Post.CreatedTime.Value.Year == i_ChosenYearByTheUser;
        }

        internal bool ShouldAddPostsWrittenAfter2018(Post i_Post)
        {
            return i_Post.CreatedTime.Value.Year >= 2018;
        }
   
        internal bool ShouldAddPostsWrittenBefore2018(Post i_Post)
        {
            return i_Post.CreatedTime.Value.Year < 2018;
        }
    }
}
