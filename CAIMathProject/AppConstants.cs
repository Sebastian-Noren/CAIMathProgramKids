using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 * @author Sebastian Norén <s.norén@gmail.com>
 * 
 * Appconstant are a Class to store sometime Public variables that are used all over the program and quickly want to change,
 * small methods in smaller program. Typical in some gamedevelopment to quickly change stats that have overall effects.
 * 
 */
namespace CAIMathProject
{
    class AppConstants
    {
        private string[] positiveResponse = new string[] { "Very good!", "Excellent!", "Nice Work!", "Well Done!", "Great!", "Keep up the good work!"};
        private string[] NegativeResponse = new string[] { "No. Please try Again!", "Wrong! try once again!", "Do not give up!", "No. Keep trying!"};
        Random rand = new Random();

        //varible to quickly change the ammount a question a round take.
        public static int QUESTIONS = 10;

        public void ReadName(string name, User user)
        {

            if (string.IsNullOrEmpty(name))
            {
                user.SetUserName("NoName"); 
            }
            else
            {
                user.SetUserName(name);
            }
        }

        //When the user answer right a good response are used.
        public string GoodResponse()
        {
            int temp = rand.Next(0,positiveResponse.Length);
            string reply = positiveResponse[temp];
            return reply;
        }
        //same as above but negative responses.
        public string BadResponse()
        {
            int temp = rand.Next(0, NegativeResponse.Length);
            string reply = NegativeResponse[temp];
            return reply;
        }

    }
}
