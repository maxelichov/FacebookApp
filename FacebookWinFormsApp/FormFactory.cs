using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using System.Windows.Forms;

namespace FacebookWinFormsApp
{
     internal static  class FormFactory
    {

        internal static Form GenerateForm(string i_FormType, User i_ChosenUser)
        {
            Form formToCraete = null;

            eFormType formType = (eFormType)Enum.Parse(typeof(eFormType), i_FormType);

            switch (formType)
            {
                case eFormType.FormMain:

                    formToCraete = new FormMain();

                    break;


                case eFormType.FormFriendEvolution:


                    formToCraete =  new FormFriendEvolution(i_ChosenUser);
                    
                    break;


                case eFormType.FormFriendTrivia:


                    formToCraete  = new FormFriendTrivia(i_ChosenUser);

                    break;

                default:

                    throw new Exception("Some thing went wrong. Check the type of form you asked to create");
            }

            return formToCraete;

        }

        internal enum eFormType
        {

            FormMain = 0,
            FormFriendEvolution,
            FormFriendTrivia

        }

    }
}
