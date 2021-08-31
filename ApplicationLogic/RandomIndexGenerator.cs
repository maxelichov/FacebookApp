using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationLogic
{
    internal static class RandomIndexGenerator
    {




        internal static int[] GenerateRandomIndex(int i_Range, int i_indexOfTheCorrectAnswer)
        {

            int[] indexArr = new int[i_Range];
            Random rnd = new Random();
            int firstIndex;
            int secondIndex;
            int thirdIndex;

            do
            {
                firstIndex = rnd.Next(i_Range);
                secondIndex = rnd.Next(i_Range);
                thirdIndex = rnd.Next(i_Range);

            } while ((firstIndex == secondIndex) || (firstIndex == thirdIndex) ||
                     (secondIndex == thirdIndex) ||
                     (i_indexOfTheCorrectAnswer == firstIndex) || (i_indexOfTheCorrectAnswer == secondIndex) || (i_indexOfTheCorrectAnswer == thirdIndex));

            indexArr[0] = firstIndex;
            indexArr[1] = secondIndex;
            indexArr[2] = thirdIndex;
            indexArr[3] = i_indexOfTheCorrectAnswer;


            return indexArr;
        }


        internal static int GetSingleRandomIndex(int i_Range)
        {
            Random rnd = new Random();

            return rnd.Next(i_Range);
        }

    }
}
