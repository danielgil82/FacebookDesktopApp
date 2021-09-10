using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class PostsConcreteSorter
    {
        public bool ShouldAddPostsWrittenAfter2018(Post i_Post)
        {
            return i_Post.CreatedTime.Value.Year >= 2018;
        }
   
        public bool ShouldAddPostsWrittenBefore2018(Post i_Post)
        {
            return i_Post.CreatedTime.Value.Year < 2018;
        }
    }
}
