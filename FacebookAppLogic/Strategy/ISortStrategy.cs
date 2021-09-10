using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public interface ISortStrategy
    {
        bool ShouldAdd(Post i_Post);
    }
}
