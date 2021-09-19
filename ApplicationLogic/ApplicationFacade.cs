﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Drawing;
using System.Windows.Forms;
using eKeyQuestion = ApplicationLogic.ApplicationFacade.eKeyQuestion;



namespace ApplicationLogic
{
    public sealed class ApplicationFacade
    {


        private EvolutionManager m_EvolutionManager;
        private TriviaManager m_TriviaManager;
        private static User s_LoggedInUser;
        private readonly List<User> r_LoggedInUserFriends;
        private readonly LoginResult r_LogginResult;
        private static ApplicationFacade s_Instance = null;
        private static readonly object r_lockMember = new object();
        private readonly FacebookObjectCollection<Post> r_LoogedInUserPosts;



        public static void InitFacadeAccordingToLoggedInUser(User i_LoggedInUser)
        {
            s_LoggedInUser = i_LoggedInUser;
        }

        private ApplicationFacade(User i_LoggedInUser)
        {

            s_LoggedInUser = i_LoggedInUser;
            r_LoggedInUserFriends = new List<User>();
            r_LoogedInUserPosts = new FacebookObjectCollection<Post>();
            
            //r_LoggedInUserPosts = i_LoggedInUser.Posts;// todo

            initFriendList();

        }


        public List<int> GetNumberOfLanguages(User i_ChosenFriend)
        {
            return m_TriviaManager.GetNumOfLanguages(i_ChosenFriend);
        }

        public static ApplicationFacade GetFacadeInstance()
        {


            if (s_Instance == null)
            {

                lock (r_lockMember)
                {
                    if (s_Instance == null)
                    {
                        s_Instance = new ApplicationFacade(s_LoggedInUser);
                    }
                }


            }

            return s_Instance;
        }

        public string GetAgeInTheChosenFriendProfilePicture()
        {
            return m_TriviaManager.GetAgeInTheChosenFriendProfilePicture();
        }

        public Photo GetRandomProfilePicture()
        {

            return m_TriviaManager.FriendProfilePicture;
        }


        internal PostsFilterStrategy PostFileFilterStrategy { get; set; }

        private void initFriendList()
        {
            foreach (User friend in s_LoggedInUser.Friends)
            {
                r_LoggedInUserFriends.Add(friend);
            }
        }


        public List<Photo> GetChosenFriendProfilePictures(User i_ChosenFriend)
        {


            m_EvolutionManager = new EvolutionManager(i_ChosenFriend);
            return m_EvolutionManager.ChosenFriendProfilePictures;

        }


        public object GetDataByDataType(eDataType i_DataType) // todo:check if this works.
        {

            object dataToReturn = null;

            switch (i_DataType)
            {
                case eDataType.Events:

                    dataToReturn = s_LoggedInUser.Events;

                    break;

                case
                    
                    eDataType.Posts:

                    dataToReturn = s_LoggedInUser.Posts;

                    break;

                case eDataType.Albums:

                    dataToReturn = s_LoggedInUser.Albums;

                    break;

                case eDataType.Friends:

                    dataToReturn = s_LoggedInUser.Friends;

                    break;
            }

            return dataToReturn;
        }

        public enum eDataType
        {
            Events = 0,
            Posts,
            Albums,
            Friends
        }

        public FacebookObjectCollection<Event> GetLoggedInUserEvents()
        {
            FacebookObjectCollection<Event> LoggedInUserEvents;

            try
            {
                LoggedInUserEvents = s_LoggedInUser.Events;
            }

            catch (Exception)
            {
                throw new Exception("Some thing went wrong when trying to access events");
            }

            return LoggedInUserEvents;
        }

        public FacebookObjectCollection<Post> GetLoggedInUserPosts()
        {
            FacebookObjectCollection<Post> LoggedInUserPosts;

            try
            {
                LoggedInUserPosts = s_LoggedInUser.Posts;
            }

            catch (Exception)
            {
                throw new Exception("Some thing went wrong when trying to access posts");
            }

            

            return LoggedInUserPosts;
        }


        public User LoggedInUser
        {
            get
            {
                return s_LoggedInUser;
            }
        }

        public List<User> LoggedInUserFriends
        {
            get
            {
                return r_LoggedInUserFriends;
            }
        }

        public Image GetLoggedInUserProfilePicture()
        {
            return s_LoggedInUser.ImageSquare;
        }

        public string GetLoggedInUserName()
        {
            return s_LoggedInUser.Name;
        }

        public Dictionary<string, string> InitTriviaQuestions(User i_ChosenFriend)
        {

            m_TriviaManager = new TriviaManager(i_ChosenFriend);
            return m_TriviaManager.InitTriviaQuestionsAndAnswers();

        }

        public List<eKeyQuestion> GetKeyQuestions()
        {
            List<eKeyQuestion> listToReturn = new List<eKeyQuestion>();

            var values = Enum.GetValues(typeof(eKeyQuestion));

            foreach (eKeyQuestion key in values)
            {
                listToReturn.Add(key);

            }

            return listToReturn;
        }

        public List<string> GetCitiesButtonsAnswrs(User i_ChosenFriend)
        {
            return m_TriviaManager.GetCitiesButtonsAnswrs(i_ChosenFriend);
        }

        public bool CheckAnswer(string i_Answer, eKeyQuestion i_Question)
        {
            return m_TriviaManager.CheckAnswer(i_Answer, i_Question);
        }


        public string GetEndOfTriviaPhraseToDisplay(int i_NumOfCorrectAnswers)
        {
            return m_TriviaManager.GetEndOfTriviaPhraseToDisplay(i_NumOfCorrectAnswers);
        }

        public List<string> GetTriviaMonths(User i_ChosenFriend)
        {
            return m_TriviaManager.GetBirthDayButtonsAnswrs(i_ChosenFriend);
        }




        public enum eKeyQuestion
        {
            HomeTown = 0,
            NumOfLanguages,
            BirthDay,
            AgeInThePicture
        }

        public enum eMonths
        {
            January = 0,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        public enum eHometowns
        {
            Jerusalem = 0,
            TelAviv,
            Haifa,
            RishonLezion,
            PetahTikva,
            Ashdod,
            Netanya,
            BneiBrak,
            Beersheba,
            Holon,
            RamatGan,
            Ashkelon,
            Rehovot,
            BeitShemesh,
            BatYam,
        }



        public FacebookObjectCollection<Post> GetPostsByTheChosenYear(int i_YearChosenByTheUserForPosts)
        {

            PostFileFilterStrategy = new PostsFilterStrategy();
            PostFileFilterStrategy.SortStrategy = new PostByChosenStrategy.ConcreteFilter();
            //todo:chnage GetLoggedInUserPosts() to s_LoggedInUser.Posts();
            FacebookObjectCollection<Post> filteredPosts = PostFileFilterStrategy.SortByChosenYear(GetLoggedInUserPosts(), i_YearChosenByTheUserForPosts);

            return filteredPosts;
        }
    }
}
