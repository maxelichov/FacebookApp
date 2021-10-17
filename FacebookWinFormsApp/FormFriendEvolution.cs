using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using AppFacade = ApplicationLogic.ApplicationFacade;

namespace FacebookWinFormsApp
{
    public partial class FormFriendEvolution : Form
    {
        private  AppFacade m_ApplicatioFacade;
        private User m_ChosenFriend;
        private readonly List<Photo> m_FriendProfilePictures;

        public FormFriendEvolution(User i_ChosenFriend)
        {
            m_ApplicatioFacade = AppFacade.GetFacadeInstance();
            InitializeComponent();
            m_ChosenFriend = i_ChosenFriend;
            m_FriendProfilePictures = new List<Photo>();
            initForm(i_ChosenFriend);
            
        }

        private void initForm(User i_ChosenFriend)
        {
           
            label_FriendProfilePicturesDisplay.Text =
                string.Format(
                    $"This is how {i_ChosenFriend.FirstName} {i_ChosenFriend.LastName} changed over the years");

            new Thread(fetchProfilePicturesAlbum).Start();
        }

        private void fetchProfilePicturesAlbum()
        {
            this.Invoke(
                new Action(
                    () =>
                        {
                            
                            fillTheFormWithTheProfilePictures(m_ApplicatioFacade.GetChosenFriendProfilePictures(m_ChosenFriend));
                        }));

           
        }

        private void fillTheFormWithTheProfilePictures(List<Photo> i_AllProfilePictures)
        {


            foreach (Photo profilePic in i_AllProfilePictures)
            {

                putPicturesInTheContainer(profilePic);
            }

            this.panel_ProfilePictures.AutoScroll = true;
        }
         

        

        private void putPicturesDateInTheContainer(Photo i_ProfilePicture, PictureBox i_PictureBox)
        {


            this.Invoke(new Action((() =>
                                           {
                                               PictureBox yearOfThePhoto = new PictureBox();
                                               yearOfThePhoto.Text = i_ProfilePicture.CreatedTime.Value.Year.ToString();
                                               panel_ProfilePictures.Controls.Add(yearOfThePhoto);
                                               yearOfThePhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                                               yearOfThePhoto.Height = 110;
                                               yearOfThePhoto.Width = 280;
                                               yearOfThePhoto.BorderStyle = BorderStyle.FixedSingle;
                                               yearOfThePhoto.BackColor = Color.LightSkyBlue;
                                               yearOfThePhoto.Top = yearOfThePhoto.Height * panel_ProfilePictures.Controls.Count;
                                               putDateInThePictureBox(i_ProfilePicture, yearOfThePhoto);
                                           })));


        }

        private void putDateInThePictureBox(Photo i_ProfilePic,PictureBox i_PictureBoxToPutIn)
        {

            this.Invoke(new Action((() =>
                                           {
                                           var image = new Bitmap(i_PictureBoxToPutIn.Width, i_PictureBoxToPutIn.Height);
                                           var font = new Font("TimesNewRoman", 50, FontStyle.Bold, GraphicsUnit.Pixel);
                                           var graphics = Graphics.FromImage(image);
                                           graphics.DrawString(i_ProfilePic.CreatedTime.Value.Year.ToString(), font, Brushes.Red, new Point(70, 20));
                                           i_PictureBoxToPutIn.Image = image;
                                           })));


        }

        private void putPicturesInTheContainer(Photo i_ProfilePic)
        {

            this.Invoke(new Action((() =>
                                           {
                                               PictureBox picBox = new PictureBox();
                                               picBox.Load(i_ProfilePic.PictureNormalURL);
                                               panel_ProfilePictures.Controls.Add(picBox);
                                               picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                                               picBox.Height = 110;
                                               picBox.Width = 280;
                                               picBox.BorderStyle = BorderStyle.FixedSingle;
                                               picBox.BackColor = Color.White;
                                               picBox.Top = picBox.Height * panel_ProfilePictures.Controls.Count;
                                               putPicturesDateInTheContainer(i_ProfilePic, picBox);
                                               m_FriendProfilePictures.Add(i_ProfilePic);
                                           })));

        }


        private void label_FriendProfilePicturesDisplay_Click(object sender, EventArgs e)
        {

        }

        private void FormProfilePictures_Load(object sender, EventArgs e)
        {

        }

        private void panel_ProfilePictures_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
