using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Drawing;
using System.Windows.Forms;

namespace ApplicationLogic
{
    public class FriendsAggregate : IEnumerable<User>
    {

        private readonly FacebookObjectCollection<User> r_Friends;

        internal FriendsAggregate(FacebookObjectCollection<User> i_Friends)
        {
            r_Friends = i_Friends;
        }

        public IEnumerator<User> GetEnumerator()
        {
            foreach (User friend in r_Friends)
            {
                yield return friend;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}

