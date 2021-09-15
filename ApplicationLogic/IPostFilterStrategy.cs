using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace ApplicationLogic
{
    interface IPostFilterStrategy
    {
        bool IsTheCurrentYearChosenMatchesTheFilter(Post i_Post, int i_ChosenYear);

    }
}
