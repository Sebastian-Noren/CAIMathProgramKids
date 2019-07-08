using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

/**
 * @author Sebastian Norén <s.norén@gmail.com>
 */
namespace CAIMathProject
{
    public partial class MainForm : Form
    {
        private User user;
        private MathFunctions math;
        private AppConstants appCons;
        private Input input;
        private WriteReadToFile writeRead;
        private int add, subtract, multi, sum, count = 1, rightTestAnswer;
        private int svar, index = 1;
        private int addSubRatio;
        private int multiRatio;
        private string tempQuestion;
        private bool isTest = false;
        private bool isPractice = false;

        public MainForm()
        {
            InitializeComponent();
            //My code from here
            InitializeGUI();
        }
        //Initialize the key component of the program
        private void InitializeGUI()
        {
            this.Text = "CAI Math program - Kids";
            math = new MathFunctions();
            appCons = new AppConstants();
            user = new User();
            input = new Input();
            writeRead = new WriteReadToFile();
            Reset();
            string format = "{0,-18}{1,10}{2,15}";
            listBox1.Items.Add(string.Format(format, "USER:", "RESULT:", "DATE:"));
            listBox1.Items.Add("");
            listBox2.Items.Add(string.Format(format, "Question:", "Correct Answer:", "Your Answer:"));
            listBox2.Items.Add("");
            PrintResultFromFile();
           
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        //Starts the practice.
        private void practiceBtn_Click(object sender, EventArgs e)
        {

            if (isTest == false)
            {
                if (sum == 100 && !string.IsNullOrEmpty(AddSubRatio.Text.Trim().ToString()) && !string.IsNullOrEmpty(MultiRatioTextbox.Text.Trim().ToString()))
                {
                    startQuestions();
                    isPractice = true;
                }
                else
                {
                    MessageBox.Show("Settings must be 100%. And ratios need to have a number.");
                }
            }
            else
            {
                MessageBox.Show("Complete the test first!");
            }
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            if (isTest == true)
            {
                CorrectOrWrong(tempQuestion);
            }
            AnswerQuestion();

        }

        //Live update the percent label.
        private void SetPercent()
        {
            sum = add + subtract + multi;
            if (sum > 100)
            {
                MessageBox.Show("Can´t be over 100%.");
                Reset();
            }
            string sumPercent = sum.ToString();
            labelMaxPercent.Text = sumPercent + "%";
        }

        private void additionTextBox_KeyUp(object sender, KeyEventArgs e)
        {

            string strValue = additionTextBox.Text.Trim().ToString();
            add = input.ReadIntegerValue(strValue);
            if (add < -0.1)
            {
                Reset();
            }
            if (strValue.Length > 3)
            {
                MessageBox.Show("Max 100%");
                additionTextBox.Clear();
            }
            SetPercent();

        }

        private void subtractionTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            string strValue = subtractionTextBox.Text.Trim().ToString();
            subtract = input.ReadIntegerValue(strValue);
            if (subtract <-0.1)
            {
                Reset();
            }
            if (strValue.Length > 3)
            {
                MessageBox.Show("Max 100%");
                subtractionTextBox.Clear();
            }
            SetPercent();

        }

        private void MultiTextBox_KeyUp(object sender, KeyEventArgs e)
        {

            string strValue = MultiTextBox.Text.Trim().ToString();
            multi = input.ReadIntegerValue(strValue);
            if (multi < -0.1)
            {
                Reset();
            }
            if (strValue.Length > 3)
            {
                MessageBox.Show("Max 100%");
                MultiTextBox.Clear();
            }
            SetPercent();

        }

        //Starting the test
        private void testBtn_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            string format = "{0,-18}{1,10}{2,15}";
            listBox2.Items.Add(string.Format(format, "Question:", "Correct Answer:", "Your Answer:"));
            listBox2.Items.Add("");
            if (isPractice == false)
            {
                math.ResetNumbers();
                if (sum == 100 && !string.IsNullOrEmpty(AddSubRatio.Text.Trim().ToString()) && !string.IsNullOrEmpty(MultiRatioTextbox.Text.Trim().ToString()))
                {
                    if (!string.IsNullOrEmpty(nameTextBox.Text.Trim().ToString()))
                    {
                        startQuestions();
                        isTest = true;
                    }
                    else
                    {
                        MessageBox.Show("Must type in name when doing a test!");
                    }
                }
                else
                {
                    MessageBox.Show("Settings must be 100%.");
                }
            }
            else
            {
                MessageBox.Show("Complete the 10 practice questions first!");
            }

        }

        private void AnswerQuestion()
        {
            string strValue = answerTextBox.Text.Trim().ToString();
            if (!string.IsNullOrEmpty(strValue))
            {
                svar = input.ReadIntegerValue(strValue);
                if (math.CheckAnswer(svar) || isTest == true && count == AppConstants.QUESTIONS-1)
                {
                    if (count == AppConstants.QUESTIONS-1)
                    {
                        // Test Completed
                        if (isTest == true)
                        {
                            TestCompleted();
                        }
                        //practice Done!
                        else
                        {
                            MessageBox.Show("Ten questions done");
                            isPractice = false;
                        }
                        Reset();
                        math.ResetNumbers();
                        EnableTextboxes();
                    }
                    else
                    {
                        labelResponse.Text = appCons.GoodResponse();
                        FetchQuestion(addSubRatio, multiRatio);

                        if (isTest == true)
                        {
                            rightTestAnswer++;
                            Console.WriteLine(rightTestAnswer);
                        }
                    }
                    count++;
                }
                else
                {
                    if (isTest == true)
                    {
                        labelResponse.Text = "No Wrong";
                        FetchQuestion(addSubRatio, multiRatio);
                        count++;
                    }
                    else
                    {
                        labelResponse.Text = appCons.BadResponse();
                    }
                }
            }
            else
            {
                MessageBox.Show("Needs a answer");
            }
        }
        // If the user pres enter instead of the button
        private void answerTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (isTest == true)
                {
                    CorrectOrWrong(tempQuestion);
                }
                AnswerQuestion();
            }
        }

        private void DividePercent()
        {
            add = add / 10;
            subtract = subtract / 10;
            multi = multi / 10;
        }

        //Reset values
        private void Reset()
        {
            subtractionTextBox.Clear();
            MultiTextBox.Clear();
            additionTextBox.Clear();
            answerTextBox.Clear();
            MultiRatioTextbox.Clear();
            AddSubRatio.Clear();
            add = 0;
            subtract = 0;
            multi = 0;
            sum = 0;
            labelMaxPercent.Text = "0%";
            labelQuestion.Text = "";
            count = 0;
            rightTestAnswer = 0;

        }

        //Store the questions during test, and displays it.
        private void CorrectOrWrong(string tempQuestion)
        {
            string format2 = "{0,-18}{1,10}{2,20}";
            listBox2.Items.Add(string.Format(format2, index + ". " + tempQuestion, math.CorrectAnswer(), answerTextBox.Text.Trim().ToString()));
            index++;
        }

        //Fetch new generated questions
        private void FetchQuestion(int addSubRatio, int multiRatio)
        {

            tempQuestion = math.GenerateQuestion(add, subtract, multi, addSubRatio, multiRatio);
            labelQuestion.Text = tempQuestion + " =";
            answerTextBox.Clear();
            answerTextBox.Focus();
        }

        private void DisableTextboxes()
        {
            additionTextBox.Enabled = false;
            subtractionTextBox.Enabled = false;
            MultiTextBox.Enabled = false;
            nameTextBox.Enabled = false;
            AddSubRatio.Enabled = false;
            MultiRatioTextbox.Enabled = false;
        }

        private void EnableTextboxes()
        {
            additionTextBox.Enabled = true;
            subtractionTextBox.Enabled = true;
            MultiTextBox.Enabled = true;
            nameTextBox.Enabled = true;
            MultiRatioTextbox.Enabled = true;
            AddSubRatio.Enabled = true;
        }

        //Initialising the start of a practice or test.
        private void startQuestions()
        {
            string strValue1 = AddSubRatio.Text.Trim().ToString();
            addSubRatio = input.ReadIntegerValue(strValue1);
            string strValue2 = MultiRatioTextbox.Text.Trim().ToString();
            multiRatio = input.ReadIntegerValue(strValue2);
            DisableTextboxes();
            DividePercent();
            appCons.ReadName(nameTextBox.Text.Trim().ToString(), user);
            FetchQuestion(addSubRatio, multiRatio);
        }

        //Get all the early result and print it in the listbox.
        private void PrintResultFromFile()
        {
            ArrayList readResult = new ArrayList();
            readResult = writeRead.ReadFromFile();

            foreach (string line in readResult)
            {
                listBox1.Items.Add(line);
            }
        }

        private void TestCompleted()
        {
            MessageBox.Show("Test is done!");
            labelTestComplete.Text = string.Format("Test Completed you had {0}% right {1}.", math.TestResult(rightTestAnswer), user.GetUserName());
            labelInfo.Text = "Detailed questions and answers from your test.";
            string format2 = "{0,-18}{1,10}{2,20}";
            string result = string.Format(format2, user.GetUserName(), math.TestResult(rightTestAnswer) + "%", DateTime.Now.ToString("dd/MM/yyyy"));
            listBox1.Items.Add(result);
            //Write result to a file.
            writeRead.WriteToFile(string.Format("{0}:{1}:{2}", user.GetUserName(), math.TestResult(rightTestAnswer), DateTime.Now.ToString("dd/MM/yyyy")));
            isTest = false;
           
        }
    }
}
