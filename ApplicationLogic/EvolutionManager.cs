using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Windows.Forms;



namespace ApplicationLogic
{
    internal class EvolutionManager
    {

        
        private readonly List<Photo> r_ChosenFriendProfilePictures;
        
        internal EvolutionManager()
        {

        }

        internal EvolutionManager(User i_ChosenFriend)
        {
            
            ChosenFriend = i_ChosenFriend;
            r_ChosenFriendProfilePictures = PicturesGenerator.fetchProfilePicturesAlbum(ChosenFriend);
            
        }

        internal Album ChosenFriendProfilePicturesAlbum { get; private set; }
        internal User ChosenFriend { get; set; }

        internal List<Photo> ChosenFriendProfilePictures
        {
            get
            {
                return r_ChosenFriendProfilePictures;
            }
        }

        internal Photo RandomProfilePicture()
        {
            int index = RandomIndexGenerator.GetSingleRandomIndex(r_ChosenFriendProfilePictures.Count);

            return r_ChosenFriendProfilePictures[index];
        }

        private void initLoggedInUserFriendList() 
        {

        }

       
    }
}
