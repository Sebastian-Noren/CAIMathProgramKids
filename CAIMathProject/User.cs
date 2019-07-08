using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * @author Sebastian Norén <s.norén@gmail.com>
 */
namespace CAIMathProject
{
    class User
    {
        private string userName;

       public User()
        {
            this.userName = "";
        }

        public string GetUserName()
        {
            return userName;
        }

        public void SetUserName(string value)
        {
            userName = value;
        }
    }
}
