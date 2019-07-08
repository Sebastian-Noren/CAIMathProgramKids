using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 * @author Sebastian Norén <s.norén@gmail.com>
 * 
 * Read inputs and parse it. Typecast to int to have it easy for Kids.
 * 
 */
namespace CAIMathProject
{
    class Input
    {
        public int ReadIntegerValue(string value)
        {
            int temp;
            double tempDouble;
            if (!string.IsNullOrEmpty(value))
            {
                if (double.TryParse(value, out tempDouble) && tempDouble >= 0)
                {
                    return (int)tempDouble;
                }
                else
                {

                    MessageBox.Show("Number must be a number above -0.");
                    return 0;
                }
            }
            return 0;
        }
    }
}
