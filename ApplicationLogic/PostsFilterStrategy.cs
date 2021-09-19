using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace ApplicationLogic
{
    internal class PostsFilterStrategy
    {
        private readonly FacebookObjectCollection<Post> r_PostChosenByTheGivenYear = new FacebookObjectCollection<Post>();


        public IPostFilterStrategy SortStrategy { get; set; }

        public FacebookObjectCollection<Post> SortByChosenYear(FacebookObjectCollection<Post> io_PostsCollection, int i_YearChosenYear)
        {
            foreach (var post in io_PostsCollection)
            {
                if(SortStrategy.IsTheCurrentYearChosenMatchesTheFilter(post, i_YearChosenYear)) 
                {
                    r_PostChosenByTheGivenYear.Add(post);
                }
            }

            return r_PostChosenByTheGivenYear;
        }
    }
}
