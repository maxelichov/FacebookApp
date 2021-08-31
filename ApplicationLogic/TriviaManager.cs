using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Windows.Forms;
using System.Drawing;
using eKeyQuestion = ApplicationLogic.ApplicationFacade.eKeyQuestion;
using eMonths = ApplicationLogic.ApplicationFacade.eMonths;
using eHometowns = ApplicationLogic.ApplicationFacade.eHometowns;




namespace ApplicationLogic
{
    internal class TriviaManager
    {

        
        private User m_ChosenFriend;
        private readonly Dictionary<string, string> r_TriviaQuestionsAndAnswers;
        private readonly List<Photo> r_FriendProfilePictures;
        private Photo m_TriviaPhoto;
        private readonly List<string> r_TriviaMonths;
        private eKeyQuestion m_CurrentQuestion;
        private readonly List<eKeyQuestion> r_KeyQuestions;
        private static readonly string[] k_TriviaResults = {"Hurry! , track down your friend and catch up with him",
            "Looks like its been a long time since the two of you spoke",
            "Try and get to know your friend a little bit better",
            "Seems like the both of you are good friends",  "Looks like the both of you are soul mates!"};
        private const string k_EndOfTriviaPhrase = "End of trivia";
        private const string k_AnotherGameQuestion = "Play Again?";

        private readonly string[] r_TriviaCities = 
        {
            "Jerusalem",
            "Tel Aviv",
            "Haifa",
            "Rishon Lezion",
            "Petah Tikva",
            "Ashdod",
            "Netanya",
            "Bnei Brak",
            "Beer sheba",
            "Holon",
            "RamatGan",
            "Ashkelon",
            "Rehovot",
            "Beit Shemesh",
            "Bat Yam"

        };

        internal TriviaManager(User i_ChosenFriend)
        {
            ChosenFriend = i_ChosenFriend;
            r_FriendProfilePictures = PicturesGenerator.fetchProfilePicturesAlbum(ChosenFriend);
            r_TriviaQuestionsAndAnswers = new Dictionary<string, string>();
            r_TriviaMonths = new List<string>();
            r_KeyQuestions = new List<eKeyQuestion>();
        }

        internal User ChosenFriend { get; set; }

        internal List<eKeyQuestion> KeyQuestion
        {
            get
            {
                return r_KeyQuestions;
            }
        }


        internal Photo FriendProfilePicture
        {
            get
            {
                return m_TriviaPhoto;
            }
        }


        internal string GetEndOfTriviaPhraseToDisplay(int  i_NumOfCorrectAnswers)
        {
            return k_TriviaResults[i_NumOfCorrectAnswers];
        }


        internal Dictionary<string, string> InitTriviaQuestionsAndAnswers()
        {
            var values = Enum.GetValues(typeof(eKeyQuestion));
            string[] keyQuestions = Enum.GetNames(typeof(eKeyQuestion));

            foreach (eKeyQuestion key in values)
            {
                r_KeyQuestions.Add(key);
                r_TriviaQuestionsAndAnswers.Add(key.ToString(), null);
                initFriendAnswers(key);
            }

            return r_TriviaQuestionsAndAnswers;
        }

        private string parseLocation(string i_HomeTownToPaese)
        {

            string parsedStr = "";

            foreach (char letter in i_HomeTownToPaese)
            {
                if (letter == ',')
                {
                    break;
                }

                else if (letter == '(')
                {
                    break;
                }

                parsedStr += letter;
            }

            return parsedStr;
        }


        private void initFriendAnswers(eKeyQuestion i_QuestionType)
        {
            switch (i_QuestionType)
            {
                case eKeyQuestion.HomeTown:

                    r_TriviaQuestionsAndAnswers[i_QuestionType.ToString()] = parseLocation(ChosenFriend.Location.ToString());
                    break;

                case eKeyQuestion.BirthDay:

                    string monthOfBirthDay = parseBirthDay(ChosenFriend.Birthday);
                    string[] strMonths = Enum.GetNames(typeof(eMonths));
                    int monthInIntRepresntaion = Int32.Parse(monthOfBirthDay);
                    r_TriviaQuestionsAndAnswers[i_QuestionType.ToString()] = strMonths[monthInIntRepresntaion - 1];
                    break;


                case eKeyQuestion.NumOfLanguages:

                    if (ChosenFriend.Languages != null)
                    {
                        r_TriviaQuestionsAndAnswers[i_QuestionType.ToString()] = ChosenFriend.Languages.Count().ToString();
                    }
                    break;

                case eKeyQuestion.AgeInThePicture:

                    string ageInThePhoto = calcAgeInAPhoto();
                    r_TriviaQuestionsAndAnswers[i_QuestionType.ToString()] = ageInThePhoto;
                    break;
            }
        }


        internal string GetAgeInTheChosenFriendProfilePicture()
        {
           return  r_TriviaQuestionsAndAnswers[eKeyQuestion.AgeInThePicture.ToString()];
        }

        private string calcAgeInAPhoto() 
        {
            DateTime dateOfBirth = Convert.ToDateTime(ChosenFriend.Birthday);
            var todayTime = DateTime.Today;
            Random randomNumberGenerator = new Random();
            int randomNumber = randomNumberGenerator.Next(0, r_FriendProfilePictures.Count());
            Photo photo = r_FriendProfilePictures[randomNumber];
            m_TriviaPhoto = photo;
            int yearsPassed = new DateTime((DateTime.Now - photo.CreatedTime.Value).Ticks).Year - 1;
            int age = new DateTime((DateTime.Now).Ticks).Year - 1 - yearsPassed;
            int currentAge = todayTime.Year - dateOfBirth.Year - 1;
            int ageInThePicture = currentAge - yearsPassed;

            return ageInThePicture.ToString();
        }

        internal List<string> GetCitiesButtonsAnswrs(User i_ChosenFriend)
        {

            Random rnd = new Random(); 
            string friendHometown = r_TriviaQuestionsAndAnswers[eKeyQuestion.HomeTown.ToString()];
            int IndexOfFirstHometown;
            int IndexOfSecondHometown;
            int IndexOfThirdHometown;

            do
            {
                IndexOfFirstHometown = rnd.Next(r_TriviaCities.Length);
                IndexOfSecondHometown = rnd.Next(r_TriviaCities.Length);
                IndexOfThirdHometown = rnd.Next(r_TriviaCities.Length);

            } while ((r_TriviaCities[IndexOfFirstHometown] == r_TriviaCities[IndexOfSecondHometown]) || (r_TriviaCities[IndexOfFirstHometown] == r_TriviaCities[IndexOfThirdHometown]) ||
            (r_TriviaCities[IndexOfSecondHometown] == r_TriviaCities[IndexOfThirdHometown]) ||
            (friendHometown == r_TriviaCities[IndexOfFirstHometown]) || (friendHometown == r_TriviaCities[IndexOfSecondHometown]) || (friendHometown == r_TriviaCities[IndexOfThirdHometown]));

            m_CurrentQuestion = eKeyQuestion.HomeTown; 

            List<string> calculatedCities = new List<string>()
            {
                 r_TriviaCities[IndexOfFirstHometown],
                 r_TriviaCities[IndexOfSecondHometown],
                 r_TriviaCities[IndexOfThirdHometown],
                 friendHometown

            };

            return calculatedCities;
        }

        internal List<string> GetBirthDayButtonsAnswrs(User i_ChosenFriend)
        {

            Random rnd = new Random();
            string monthOfBirthDay = parseBirthDay(i_ChosenFriend.Birthday);
            string[] strMonths = Enum.GetNames(typeof(eMonths));
            int monthInIntRepresntaion = Int32.Parse(monthOfBirthDay);

            initMonthsTrivia(monthOfBirthDay, monthInIntRepresntaion);
            int firstMonth;
            int secondMonth;
            int thirdMonth;

            do
            {
                firstMonth = rnd.Next(0, 11);
                secondMonth = rnd.Next(0, 11);
                thirdMonth = rnd.Next(0, 11);

            } while ((firstMonth == secondMonth) || (firstMonth == thirdMonth) || (secondMonth == thirdMonth));

            List<string> calculatedMonthsToReturn = new List<string>()
            {
                r_TriviaMonths[firstMonth],
                r_TriviaMonths[secondMonth],
                 r_TriviaMonths[thirdMonth],
                 strMonths[monthInIntRepresntaion - 1]
            };

            return calculatedMonthsToReturn;
        }

        internal List<int> GetNumOfLanguages(User i_ChosenFriend)
        {
            List<int> numOfLanguagesOptions;

                if (i_ChosenFriend.Languages != null)
                {
                     numOfLanguagesOptions = new List<int>
                    {
                        i_ChosenFriend.Languages.Count(),
                        i_ChosenFriend.Languages.Count() + 1,
                        i_ChosenFriend.Languages.Count() + 2,
                        i_ChosenFriend.Languages.Count() + 3,

                    };
                }

                else
                {
                    throw new Exception("Your friend did not mentioned how many languages he speaks on facebook page");
                }
            
            return numOfLanguagesOptions;
        }


        private void initMonthsTrivia(string i_MonthOfBirthDay, int i_MonthInInt)
        {
            string[] months = Enum.GetNames(typeof(eMonths));
            i_MonthOfBirthDay = months[i_MonthInInt - 1];

            foreach (string strMonth in months)
            {
                if (strMonth != i_MonthOfBirthDay)
                {
                    r_TriviaMonths.Add(strMonth);
                }
            }
        }

        private string parseBirthDay(string i_BirthDay)
        {
            string month = i_BirthDay.Substring(0, 2);
            return month;
        }


        internal bool CheckAnswer(string i_Answer, eKeyQuestion i_Question)
        {

            bool answer = false;

            switch (i_Question)
            {
                case eKeyQuestion.HomeTown:

                    if (i_Answer == r_TriviaQuestionsAndAnswers[i_Question.ToString()]) 
                    {
                        answer = true;
                    }

                    break;

                case eKeyQuestion.BirthDay:

                    if (i_Answer == r_TriviaQuestionsAndAnswers[i_Question.ToString()])
                    {
                        answer = true;

                    }

                    break;

                case eKeyQuestion.NumOfLanguages:

                    if (i_Answer == r_TriviaQuestionsAndAnswers[i_Question.ToString()])
                    {
                        answer = true;

                    }

                    break;

                case eKeyQuestion.AgeInThePicture:

                    if (i_Answer == r_TriviaQuestionsAndAnswers[i_Question.ToString()])
                    {
                        answer = true;

                    }

                    break;
            }

            return answer;
        }

        private void FormFriendTrivia_Load(object sender, EventArgs e)
        {

        }

    }       
}
    

 
