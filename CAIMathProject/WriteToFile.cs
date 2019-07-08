using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Collections.Generic;
/**
 * @author Sebastian Norén <s.norén@gmail.com>
 * 
 * This Class hold the IO reading and writing to files.
 * 
 */
namespace CAIMathProject
{
    class WriteReadToFile
    {
        private const string FILEPATH = ".\\Results.txt";

        public void WriteToFile(string result)
        {
            StreamWriter sw = File.AppendText(FILEPATH);
            try
            {
                sw.WriteLine(result);
            }
            catch (IOException)
            {

            }
            finally
            {
                sw.Close();
                sw.Dispose();
            }
        }


        public ArrayList ReadFromFile()
        {
            StreamReader sr = new StreamReader(File.OpenRead(FILEPATH));
            ArrayList tempArray = new ArrayList();
            try
            {
                string format2 = "{0, -18}{1,-10}{2,20}";
                string[] lines = File.ReadAllLines(FILEPATH);
                foreach (string line in lines)
                {
                    // Store the line in an array and split it at :
                    string[] attr = line.Split(':');
                    // Save the values
                    string name = attr[0];
                    string result = attr[1];
                    string date = attr[2];
                    string temp = string.Format(format2, name, result + "%", date);
                    tempArray.Add(temp);
                }

            }
            catch (IOException)
            {

            }
            finally
            {
                sr.Close();
                sr.Dispose();
            }
            return tempArray;
        }
    }
}
