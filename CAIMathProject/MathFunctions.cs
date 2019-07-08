using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * @author Sebastian Norén <s.norén@gmail.com>
 * 
 * Class that holds calculation, numbers etc. This should need more work with Threads in a later stage.
 * While loop in the UI thread can create problem, But was discovered late in the process.
 */
namespace CAIMathProject
{
    class MathFunctions
    {
        private static Random random = new Random();
        private int a, b;
        private string c = "";
        private int ran;
        private int Correct;
        string strTemp;

        int addCount = 0, subCount = 0, multiCount = 0;

        //Generate random question for the user to answer. A New thread or some other thing I don´t know to protect the while loop.
        //Searching for a random question depending of what the user put in the settings.
        public string GenerateQuestion(int add, int subtract, int multi, int addSubRatio, int multiRatio)
        {
                a = random.Next(1, addSubRatio + 1);
                b = random.Next(1, addSubRatio + 1);

            while (true)
            {

                ran = random.Next(0, 3);
                if (ran == 0 && (addCount <= add))
                {
                    c = "+";
                    addCount++;
                    Correct = a + b;
                    break;
                }
                if (ran == 1 && (multiCount <= multi))
                {
                    c = "*";
                    a = random.Next(1, multiRatio + 1);
                    b = random.Next(1, multiRatio + 1);
                    multiCount++;
                    Correct = a * b;
                    break;
                }
                if (ran == 2 && (subCount <= subtract))
                {
                    if (b > a)
                    {
                        ReverseNegativeSubtraction();
                    }
                    c = "-";
                    subCount++;
                    Correct = a - b;
                    break;
                }
            };
            strTemp = string.Format("{0} {1} {2}", a, c, b);

            return strTemp;

        }

        //Controll the anser of the users input.
        public bool CheckAnswer(int svar)
        {
            if (ran == 2 && svar == Correct || ran == 0 && svar == Correct || ran == 1 && svar == Correct)
            {
                return true;
            }
            return false;
        }

        public int CorrectAnswer()
        {
            return Correct;
        }

        //Because there should be no negative answers this method use to reverse a and b.
        private void ReverseNegativeSubtraction()
        {
            int temp = a;
            a = b;
            b = temp;
        }

        //Calculate the user score afte a test is done.
        public string TestResult(int rightTestAnswer)
        {
            Console.WriteLine(rightTestAnswer);
            double resultPercent = (double)rightTestAnswer / (double)AppConstants.QUESTIONS;
            Console.WriteLine(resultPercent);
            resultPercent = resultPercent * 100;
            return resultPercent.ToString();
        }

        public void ResetNumbers()
        {
            addCount = 0;
            subCount = 0;
            multiCount = 0;
        }
    }



}
