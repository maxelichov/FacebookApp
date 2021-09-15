using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace ApplicationLogic
{
    internal class PostByChosenStrategy 
    {


        internal class ConcreteFilter : IPostFilterStrategy
        {
            public bool IsTheCurrentYearChosenMatchesTheFilter(Post i_Post, int i_ChosenYear)
            {

                return i_Post.CreatedTime.Value.Year == i_ChosenYear;
            }
        }

    }
}
