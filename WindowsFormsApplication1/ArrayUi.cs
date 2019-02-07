using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ArrayUi : Form
    {
        public ArrayUi()
        {
            InitializeComponent();
        }

        private void firstArrayButton_Click(object sender, EventArgs e)
        {

            string[] weekDayName = {"SunDay", "MunDay","TueDay","WedDay"};
            richTextBox.Clear();
            for (int a = 0; a < 4; a++)
            {
                richTextBox.Text = richTextBox.Text + weekDayName[a] + "\n";
            }

        }

        private void SecArraybutton_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox.Clear();
            
             string[] weekDayName = new string[7];
              weekDayName[0] = "SunDay";
              weekDayName[1] = "MunDay";
              weekDayName[2] = "TueDay";
              weekDayName[3] = "WedDay";
              weekDayName[4] = "ThaDay";
              weekDayName[5] = "FryDay";
              weekDayName[6] = "SatDay";

              for (int i = 0; i < 7; i++)
              {
                  richTextBox.Text = richTextBox.Text + weekDayName[i] + "\n";
              }

            }
            catch (Exception a)
            {

                MessageBox.Show(a.Message);
            }
        }
        int i = 0;
        string[] weekDayName = new string[7];
        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox.Clear();

              //  string[] weekDayName = new string[7];
              //  int i = 0;
                weekDayName[i] = nameTextBox.Text;
                i++;
                richTextBox.Text = "";

                for (int a = 0; a < 7; a++)
                {
                    richTextBox.Text = richTextBox.Text + a + " " +weekDayName[a] + "\n";
                }

            }
            catch (Exception a)
            {

                MessageBox.Show(a.Message);
            }
        }

        private void CloneDayButton_Click(object sender, EventArgs e)
        {
            try
            {

                richTextBox.Clear();

                 string[] weekDayName = new string[7];
                 weekDayName[0] = "SunDay";
                 weekDayName[1] = "MunDay";
                 weekDayName[2] = "TueDay";
                 weekDayName[3] = "WedDay";
                 weekDayName[4] = "ThaDay";
                 weekDayName[5] = "FryDay";
                 weekDayName[6] = "SatDay";
                // int i = 0;
                //weekDayName[i] = nameTextBox.Text;
               string[] weekDayNameCopy = new string[i];

                //weekDayNameCopy.CopyTo(weekDayName,0);
                weekDayNameCopy = weekDayName.Clone() as string[];
               // weekDayNameCopy = richTextBox.Text.Clone() as string[];
                i++;
                richTextBox.Text = "";

                for (int a = 0; a < 7; a++)
                {
                 //  richTextBox.Text = richTextBox.Text + a + "  " + weekDayName[a] + "\n";   
                    cloneRichTextBox.Text = cloneRichTextBox.Text + a+ "  " + weekDayNameCopy[a] + "\n";
                }

               // cloneRichTextBox.Text = cloneRichTextBox.Text +a+ "  " + weekDayNameCopy[i] + "\n";

            }
            catch (Exception a)
            {

                MessageBox.Show(a.Message);
            }
        }
        int d = 0;
        string[] evenIndex = new string[7];
        private void EvenButton_Click(object sender, EventArgs e)
        {
            try
            {
                evenIndex[d] = richTextBox.Text;
                d++;
                evenLabel.Text = "  ";
                
                for (int i = 0; i < 7; i++)
                {
                    if (i % 2 == 0)
                    {
                        evenLabel.Text = evenLabel.Text + evenIndex[i] + "\n";
                    }
                }
             /*   string a = " 10";
                string b = " 12";
                string c;
                c = a + b;
                evenLabel.Text = c; */



               // richTextBox.Clear();
               // int i, n, even = 0, odd = 0;
               /* string[] weekDayName = new string[7];
                weekDayName[0] = "SunDay";
                weekDayName[1] = "MunDay";
                weekDayName[2] = "TueDay";
                weekDayName[3] = "WedDay";
                weekDayName[4] = "ThaDay";
                weekDayName[5] = "FryDay";
                weekDayName[6] = "SatDay";*/
                // int i = 0;
                //weekDayName[i] = nameTextBox.Text;
                //string[] weekDayNameCopy = new string[0];
                // int weekDayNameC = Convert.ToInt32(richTextBox.Text);
                //weekDayNameCopy.CopyTo(weekDayName,0);
               // weekDayNameCopy = weekDayName.Clone() as string[];
               // int weekDayNameCopyC = Convert.ToInt32(richTextBox.Text);
                // weekDayNameCopy = richTextBox.Text.Clone() as string[];
                //i++;
               // richTextBox.Text = "";

               // for (int a = 0; a < 7; a++)
                {
                   // evenLabel.Text = a + "  " + weekDayNameCopy[a] + "\n".ToString();
                    /* foreach (var result in weekDayName)
                    {
                         if (weekDayNameC % 2 == 0)
                       {
                           evenLabel.Text = a + "  " + weekDayNameCopy[a] + "\n".ToString();
                       }
                       else
                       {
                           evenLabel.Text = "";
                       }*/
                      /*  if (weekDayName[0] % 2 == 0)
                     {
                            even = even;
                            even++;
                        }
                        else
                        {
                            odd = odd;
                            odd++;
                        }  */
                        //  richTextBox.Text = richTextBox.Text + a + "  " + weekDayName[a] + "\n";   
                        //evenLabel.Text = evenLabel.Text + "  " + weekDayNameCopy[a] + "\n";
                    
                   // evenLabel.Text = evenLabel.Text + a + "  " + weekDayNameCopy[a] + "\n".ToString();
                   // cloneRichTextBox.Text = cloneRichTextBox.Text + a + "  " + weekDayNameCopy[i] + "\n";
                }
               // evenLabel.Text = "  " + weekDayNameCopy[1] + "\n".ToString();
            }
            catch (Exception a)
            {

                MessageBox.Show(a.Message);
            }
        }
        int c = 0;
        string[] oddIndex = new string[7];
        private void button2_Click(object sender, EventArgs e)
        {
            try
            { 

            //int c = 0;
            //string[] evenIndex = new string[7];
                oddIndex[c] = richTextBox.Text;
            c++;
            evenLabel.Text = "  ";

            for (int i = 0; i < 7; i++)
            {
                if (i % 2 == 1)
                {
                    oddLabel.Text = oddLabel.Text + oddIndex[i] + "\n";
                }
            }

        }

            catch (Exception a)
            {

                MessageBox.Show(a.Message);
            }
        }
    

    }
}
