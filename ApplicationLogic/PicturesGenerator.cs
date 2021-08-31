using System;
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
   internal static class PicturesGenerator
   {

       private static List<Photo> r_ChosenFriendProfilePictures;


        internal static List<Photo> fetchProfilePicturesAlbum(User i_GenerateChosenUserProfilePicturesInList)
        {

            List<Photo> r_ChosenFriendProfilePictures = new List<Photo>();


            foreach (Album album in i_GenerateChosenUserProfilePicturesInList.Albums)
            {

                try
                {
                    if (album.Name == "Profile Pictures")
                    {
                        putProfilePicturesInTheList(album, r_ChosenFriendProfilePictures);
                        break;
                    }
                }
                catch (Exception ex)
                {

                    throw new Exception("Some thing went wrong with accesing your facebook albums");
                }


            }

            return r_ChosenFriendProfilePictures;

        }


        internal static Photo GetSinleProfilePicture(int i_IndexOfThePhoto)
        {
            return r_ChosenFriendProfilePictures[i_IndexOfThePhoto];
        }

        private static void putProfilePicturesInTheList(Album i_ChosenUserProfilePicturesAlbum, List<Photo> i_ListOfProfilePicturesToInit)
        {
            foreach(Photo photo in i_ChosenUserProfilePicturesAlbum.Photos)
            {
                i_ListOfProfilePicturesToInit.Add(photo);
            }
        }

    }
}
