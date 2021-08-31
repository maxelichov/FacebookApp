using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using AppFacade = ApplicationLogic.ApplicationFacade;
using eKeyQuestion = ApplicationLogic.ApplicationFacade.eKeyQuestion;
using eMonths = ApplicationLogic.ApplicationFacade.eMonths;
using eHometowns = ApplicationLogic.ApplicationFacade.eHometowns;




namespace FacebookWinFormsApp
{
    public partial class FormFriendTrivia : Form
    {
        private readonly AppFacade m_ApplicationFacade;
        private readonly User m_ChosenFriend;
        private readonly Dictionary<string, string> r_TriviaQuestionsAndAnswers;
        private const int k_NumOfQuestions = 4;
        private int m_NumOfRightAnswers;
        private int m_NumOfWrongAnswers;
        private int m_NumOfQuestionsAsked;
        private readonly List<string> r_TriviaMonths;
        private eKeyQuestion m_CurrentQuestion;
        private readonly List<eKeyQuestion> r_KeyQuestions;

        private const string k_EndOfTriviaPhrase = "End of trivia";
        private const string k_AnotherGameQuestion = "Play Again?";

        
        

        public FormFriendTrivia(User i_ChosenFriend)
        {
            m_ApplicationFacade = AppFacade.GetFacadeInstance();
            InitializeComponent();
            m_ChosenFriend = i_ChosenFriend;
            r_TriviaQuestionsAndAnswers = new Dictionary<string, string>();
            r_TriviaMonths = new List<string>();
            r_KeyQuestions = new List<eKeyQuestion>();
            initTriviaQuestions(i_ChosenFriend);
        }


        private void initTriviaQuestions(User i_ChosenFriend)
        {
            
            Dictionary<string, string> questionAndAnswersAboutTheChosenFriend = m_ApplicationFacade.InitTriviaQuestions(i_ChosenFriend);
            startTriviaGame();
        }

        private void startTriviaGame()
        {
            var keys = Enum.GetValues(typeof(eKeyQuestion));
            
            foreach (eKeyQuestion key in keys)
            {
                r_KeyQuestions.Add(key);
            }

            askAQuestion(r_KeyQuestions[m_NumOfQuestionsAsked % k_NumOfQuestions]);
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



        private void initBirthDayButtonsAnswers()
        {

            List<string> monthsToDisplayOnTheButtons = m_ApplicationFacade.GetTriviaMonths(m_ChosenFriend);

            pictureBox_TriviaPicture.Image = Properties.Resources.months;

            button_FirstAnswer.Text = monthsToDisplayOnTheButtons[0];
            button_SecondAnswer.Text = monthsToDisplayOnTheButtons[1];
            button_FourthAnswer.Text = monthsToDisplayOnTheButtons[2];
            button_ThirdAnswer.Text = monthsToDisplayOnTheButtons[3];
            m_CurrentQuestion = eKeyQuestion.BirthDay;
        }


        private void initAgeInThePictureButtonsAnswers()    
        {   

            pictureBox_TriviaPicture.Load(m_ApplicationFacade.GetRandomProfilePicture().PictureNormalURL);
            int age = Int32.Parse(m_ApplicationFacade.GetAgeInTheChosenFriendProfilePicture()); 
            button_FirstAnswer.Text = age.ToString();
            button_SecondAnswer.Text = (age + 1).ToString();
            button_ThirdAnswer.Text = (age + 2).ToString();
            button_FourthAnswer.Text = (age + 3).ToString();
            m_CurrentQuestion = eKeyQuestion.AgeInThePicture;
        }

        private void initCountryButtonsAnswers() 
        {
            List<string> CitiesToDisplayOnTheButtons = m_ApplicationFacade.GetCitiesButtonsAnswrs(m_ChosenFriend);

            pictureBox_TriviaPicture.Image = Properties.Resources.hometown;

            button_FirstAnswer.Text = CitiesToDisplayOnTheButtons[0];
            button_SecondAnswer.Text = CitiesToDisplayOnTheButtons[1];
            button_FourthAnswer.Text = CitiesToDisplayOnTheButtons[2];
            button_ThirdAnswer.Text = CitiesToDisplayOnTheButtons[3];

            m_CurrentQuestion = eKeyQuestion.HomeTown;
        }   


        private void initNumOfLanguagesButtonsAnswers()
        {
            pictureBox_TriviaPicture.Image = Properties.Resources.languages;


            try
            {
                List<int> LanguagesOptions = m_ApplicationFacade.GetNumberOfLanguages(m_ChosenFriend);
                button_FirstAnswer.Text = LanguagesOptions[0].ToString();
                button_SecondAnswer.Text = LanguagesOptions[1].ToString();
                button_ThirdAnswer.Text = LanguagesOptions[2].ToString();
                button_FourthAnswer.Text = LanguagesOptions[3].ToString();
                m_CurrentQuestion = eKeyQuestion.NumOfLanguages;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); 
                button_FirstAnswer.Text = "test 1";
                button_SecondAnswer.Text = "test2";
                button_ThirdAnswer.Text = "test3;";
                button_FourthAnswer.Text = "test4";
            }
            
        }

        private void askAQuestion(eKeyQuestion i_QuestionType) 
        {

            if (m_NumOfQuestionsAsked == k_NumOfQuestions)
            {
                endTriviaGameAndDisplayResult();
            }

            switch (i_QuestionType)
            {
                case eKeyQuestion.HomeTown:

                    label_Question.Text = string.Format($"Whats {m_ChosenFriend.Name}'s Home Town?");
                    initCountryButtonsAnswers();
                    break;

                case eKeyQuestion.BirthDay:

                    label_Question.Text = string.Format($"On which month was {m_ChosenFriend.Name} born?");
                    initBirthDayButtonsAnswers();
                    break;

                case eKeyQuestion.NumOfLanguages:

                    label_Question.Text = string.Format($"How Many Languages Does {m_ChosenFriend.Name} Speak?");
                    initNumOfLanguagesButtonsAnswers();
                    break;

                case eKeyQuestion.AgeInThePicture:

                    label_Question.Text = string.Format($"How Old Is {m_ChosenFriend.Name} In This Picture?");
                    initAgeInThePictureButtonsAnswers();
                    break;
            }
        }


        private void endTriviaGameAndDisplayResult() 
        {
            

            DialogResult messageBoxResult;
            messageBoxResult = MessageBox.Show((string.Format("You answered {0} correct answers{1}{2}{3}",
                                               m_NumOfRightAnswers, System.Environment.NewLine, m_ApplicationFacade.GetEndOfTriviaPhraseToDisplay(m_NumOfRightAnswers), System.Environment.NewLine)),
                                               k_EndOfTriviaPhrase, MessageBoxButtons.OK);

            this.Close();
        }


        

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            Button answer = sender as Button;

            if (m_ApplicationFacade.CheckAnswer(answer.Text, m_CurrentQuestion))
            {
                m_NumOfRightAnswers++;
            }

            m_NumOfQuestionsAsked++;
            askAQuestion(r_KeyQuestions[m_NumOfQuestionsAsked % k_NumOfQuestions]);
        }

        private void FormFriendTrivia_Load(object sender, EventArgs e)
        {

        }
    }


   

}