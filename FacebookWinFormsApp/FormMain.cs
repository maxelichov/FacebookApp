using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using CefSharp.Structs;
using Message = FacebookWrapper.ObjectModel.Message;
using ApplicationFacade = ApplicationLogic.ApplicationFacade;
using System.Threading;



namespace FacebookWinFormsApp
{
    public partial class FormMain : Form
    {
        private const string k_FormName = "FormMain";
        private  static ApplicationFacade m_ApplicationFacade;
        private LoginResult m_LoginResult;
        private bool m_UserIsLoggedIn = false;
        private readonly AppSettings m_LastAppSetting;

        public int YearChosenByTheUserForPosts { get; set; }

        public FormMain()
        {

            
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
            m_LastAppSetting = AppSettings.LoadFromFile(m_ApplicationFacade);
            this.StartPosition = FormStartPosition.Manual;
            

        }

        
        protected override void OnShown(EventArgs e)
        {

            base.OnShown(e);

            if (m_LastAppSetting.RememberUser == true && !(string.IsNullOrEmpty(m_LastAppSetting.LastAccessToken)))
            {
                m_LoginResult = FacebookService.Connect(m_LastAppSetting.LastAccessToken);
                ApplicationFacade.InitFacadeAccordingToLoggedInUser(m_LoginResult.LoggedInUser);
                m_ApplicationFacade = ApplicationFacade.GetFacadeInstance();


                 new Thread(fillTheUiWithTheLoggedInUserData).Start(); 
            }
        }

        

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns.c21ב"); /// the current password for Desig Patter

            m_LoginResult = FacebookService.Login(
                    /// (This is Desig Patter's App ID. replace it with your own)
                    "919176538660617",
                    /// requested permissions:
                    "email",
                    "public_profile",
                    "user_age_range",
                    "user_birthday",
                    "user_events",
                    "user_friends",
                    "user_gender",
                    "user_hometown",
                    "user_likes",
                    "user_link",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_videos"
                    );

            if (string.IsNullOrEmpty(m_LoginResult.AccessToken) == false)
            {

                ApplicationFacade.InitFacadeAccordingToLoggedInUser(m_LoginResult.LoggedInUser);
                m_ApplicationFacade = ApplicationFacade.GetFacadeInstance();
                new Thread(fillTheUiWithTheLoggedInUserData).Start();
            }

            else
            {
                MessageBox.Show("Login Failed");
            }
        }

        private void fillTheUiWithTheLoggedInUserData()
        {
            this.Invoke(new Action((() =>
            {

                this.Text = $"Logged in as {m_ApplicationFacade.LoggedInUser.Name}";
                m_UserIsLoggedIn = true;
                pb_ProfilePicture.Image = m_ApplicationFacade.GetLoggedInUserProfilePicture();
                pb_ProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
                cb_RememberMe.Enabled = true;

            })));


            new Thread(fetchFriends).Start(); 
            new Thread(fetchEvents).Start();
            //new Thread
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e); 
            m_LastAppSetting.LastWindowSize = this.Size;
            m_LastAppSetting.LastWindowLocation = this.Location;
            m_LastAppSetting.RememberUser = cb_RememberMe.Checked;

            if(m_LastAppSetting.RememberUser == true)
            {
                m_LastAppSetting.LastAccessToken = m_LoginResult.AccessToken;
            }

            else
            {
                m_LastAppSetting.LastAccessToken = null;
            }

            m_LastAppSetting.SaveToFile();
        }


        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
        }

        private void linkLabelFriends_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (m_UserIsLoggedIn == true)
            {
                new Thread(fetchFriends).Start(); 
            }

            else
            {
                MessageBox.Show("You need to log in first");
            }
        }


        private void fetchEvents()
        {

            ListBoxEvents.Invoke(
                
                new Action(
                    () =>
                        {
                            eventBindingSource.DataSource = m_ApplicationFacade.GetLoggedInUserEvents();
                            if(ListBoxEvents.Items.Count == 0)
                            {
                                MessageBox.Show("Your event list is currently empty");
                            }
                        }));
        }


    

        private void fetchFriends() 
        {

            List<User> LoggedInUserFriends = m_ApplicationFacade.LoggedInUserFriends;

            try
            {
                if (m_ApplicationFacade.LoggedInUser.Friends.Count > 0)
                {
                    foreach (User user in LoggedInUserFriends)
                    {
                        

                        ListBox_Friends.Invoke(new Action(()=> ListBox_Friends.Items.Add(user)));
                    }
                }

                else
                {
                    
                    MessageBox.Show("Your Friends List Is Empty");
                }

            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
        }

        private void ListBox_Friends_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cb_ShowFriendProfilePictures.Checked == true || cb_FriendTrivia.Checked == true)
            {

                User chosenFriend = ((sender as ListBox).SelectedItem as User);

                try
                {
                    if (cb_ShowFriendProfilePictures.Checked && chosenFriend != null)
                    {

                        FormFriendEvolution FormFriendEvoultion = FormFactory.GenerateForm("FormFriendEvolution", chosenFriend) as FormFriendEvolution;

                        FormFriendEvoultion.ShowDialog();
                    }

                    else if (cb_FriendTrivia.Checked && chosenFriend != null)
                    {
                        FormFriendTrivia triviaForm = FormFactory.GenerateForm("FormFriendTrivia", chosenFriend) as FormFriendTrivia;
                        triviaForm.ShowDialog();

                    }

                    else if (chosenFriend == null)
                    {
                        MessageBox.Show("When choosing an option, you must click on a friend's name");
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    
                }
                
            }

            else
            {
                MessageBox.Show("Choose One Of The Options");
            }
        }

        private void cb_RememberMe_CheckedChanged(object sender, EventArgs e)
        {
            m_LastAppSetting.RememberUser = cb_RememberMe.Checked;
        }

        
        private void button_ShowFriendProfilePictures_Click(object sender, EventArgs e)
        {
            cb_ShowFriendProfilePictures.Checked = true;
            cb_FriendTrivia.Checked = false;
           
        }

        private void button_FriendTrivia_Click(object sender, EventArgs e)
        {
            cb_FriendTrivia.Checked = true;
            cb_ShowFriendProfilePictures.Checked = false;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Label_FriendsList_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cb_ShowFriendProfilePictures_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void cb_FriendTrivia_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        void FormMain_Shown(object sender, EventArgs e)
        {

        }

        private void ListBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox_Posts_SelectedIndexChanged(object sender, EventArgs e)
        {
           YearChosenByTheUserForPosts = Int32.Parse((sender as ComboBox).SelectedItem.ToString());

            new Thread(fetchPostsByChosenYear).Start();

        }

        private void fetchPostsByChosenYear()
        {
            ListBox_Posts.Invoke(
                new Action(
                    () =>
                        {
                            ListBox_Posts.DisplayMember = Name;

                            if (ListBox_Posts.SelectedItems != null)
                            {
                                ListBox_Posts.DataSource = null;
                            }

                            if(ComboBox_Posts.SelectedItem != null)
                            {
                                FacebookObjectCollection<Post> posts =
                                    m_ApplicationFacade.GetPostsByTheChosenYear(YearChosenByTheUserForPosts);

                                if (posts.Count == 0)
                                {
                                    MessageBox.Show("You have not posted any post at the chosen year");
                                    
                                }
                                else
                                {
                                    ListBox_Posts.DataSource = posts;
                                }
                            }

                        }));
        }
    }
}