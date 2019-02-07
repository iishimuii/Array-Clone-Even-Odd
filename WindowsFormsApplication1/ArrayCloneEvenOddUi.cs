using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ArrayCloneEvenOddUi : Form
    {
        public ArrayCloneEvenOddUi()
        {
            InitializeComponent();
        }
        int i = 0;
        string[] weekDaysName = new string[7];

        private void AddDaysButton_Click(object sender, EventArgs e)
        {
            try
            {

                weekDaysName[i] = addTextBox.Text;
                i++;
                firstRichTextBox.Text = "";

                for (int a = 0; a < i; a++)
                {
                    firstRichTextBox.Text = firstRichTextBox.Text + weekDaysName[a] + "\n";
                }

            }
            catch (Exception a)
            {

                MessageBox.Show(a.Message);
            }
        }
        string[] weekDaysNameClone = new string[7];
        private void dayClonebutton_Click(object sender, EventArgs e)
        {
            try
            {
                for (int m = 0; m < 7; m++)
                { weekDaysNameClone[m] = weekDaysName[m];}
               
                cloneRichTextBox.Text = "";

                for (int a = 0; a < i; a++)
                {
                    cloneRichTextBox.Text = cloneRichTextBox.Text + weekDaysNameClone[a] + "\n";
                }

            }
            catch (Exception a)
            {

                MessageBox.Show(a.Message);
            }
        }
       // int c = 0;
       // string[] evenArray = new string[7];
        private void EvenDaysButton_Click(object sender, EventArgs e)
        {
            /* evenArray[c] = firstRichTextBox.Text;
            c++;
            evenDaysLabel.Text = " ";
            for (int i = 0; i < 7; i++)
            {
                if (i % 2 == 0)
                {
                    evenDaysLabel.Text = evenDaysLabel.Text + evenArray[i] + "\n";
                }
            } */
            string[] evenArray = new string[7];
            try
            {
              // int x;
               for (int y = 0; y < 7; y = y + 1)
               {
                   evenArray[y] = weekDaysNameClone[y];
                  // evenDaysLabel.Text = " ";
                   if (y % 2 != 0)
                  // for (int a = 1; a < y; a++)
                   {
                       evenDaysLabel.Text = evenDaysLabel.Text + evenArray[y] + "\n";
                   }
               }
            }
            catch (Exception a)
            {

                MessageBox.Show(a.Message);
            } 
        }
       // int d = 0;
       // string[] oddArray = new string[7];
        private void OddDaysButton_Click(object sender, EventArgs e)
        {
           /* oddArray[d] = firstRichTextBox.Text;
            d++;
            oddDayslabel.Text = " ";
            for ( int i = 0; i < 7; i++)
            {
                if (i % 2 == 1)
                {
                    oddDayslabel.Text = oddDayslabel.Text + oddArray [i]+"\n";
                }
            }*/
            string[] oddArray = new string[7];
            try
            {
               // int x;
                for (int y = 0; y < 7; y = y + 2)
                {
                    oddArray[y] = weekDaysNameClone[y];

                     if (y % 2 == 0)
                    //for (int a = 0; a < y - 1; a++)
                    {
                        oddDayslabel.Text = oddDayslabel.Text + oddArray[y] + "\n";
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
