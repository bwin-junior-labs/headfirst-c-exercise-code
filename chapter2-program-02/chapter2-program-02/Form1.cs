using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapter2_program_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Loop #1 pg.71 
            // the loop only runs once, and that makes sense because the while loop only runs
            // while count is > 0. The final calculation times count by -1 which came to -15            
            int count = 5;
            int loopCount = 0; // this is my addition to count how many times the while loop is run
            while (count > 0)
            {
                count = count * 3;
                count = count * -1;
                loopCount++; // as is this
            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Loop #2 
            // this loop runs forever because the i variable always equals 0 
            int i = 0;
            int count = 2;
            int loopCount = 0;
            while (i == 0) {
                count = count * 3;
                count = count * -1;
                loopCount++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Loop #5 - loops 8 times
            int p = 2;
            int loopCount = 0;
            for (int q = 2; q < 32;
                q = q * 2)
            {
                while (p < q)
                {
                    p = p * 2;
                }
                q = p - q;
                loopCount++;
            }
            
        }


        private void button4_Click(object sender, EventArgs e)
        {
            // Sharpen Your Pencil Pg. 72
            // makes sense when you step through it
            int result = 0; // this variable will hold the final result
            int x = 6; // declare a variable x and set it to 6
            int loopCount = 0;
            int loopCount2 = 0;
            while (x > 3) {
            // execute these statements as long as x is greater than 3
                result = result + x; // add x to the result variable
                x = x - 1; // subtract 1 from the value of x 
                loopCount++;
            }
            for (int z = 1; z < 3; z = z + 1) {
                // start the loop by declaring a variable z and setting it to 1
                // keep looping as long as z is less than 3
                // after each loop, add 1 to z
                result = result + z; // add the value of z to result
                loopCount2++;
            }
            // The next statement will pop up a message box that says
            // The result is 18
            MessageBox.Show("The result is " + result);                         
        }

        private void button5_Click(object sender, EventArgs e)
        {   // loop #3
            int j = 2;
            int loopCount = 0;
            int loopCount2 = 0; 
            for (int i = 1; i < 100;
                i = i * 2) // it appears that the first time the loop                       
            {              // goes around, i is not * 2, i.e. that part
                j = j - i; // of the statement is not run
                while (j < 25)
                {
                    j = j + 5;
                    loopCount++;
                }
                loopCount2++;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // loop #4
            int loopCount = 0;
            while (true) { int i = 1; loopCount++; }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string Result = "";
            int x = 3;
            if (x == 1) {
                Result = Result + "d";
                x = x - 1;

            while (x > 0)
            {
                x = x - 1;
                Result = Result + "-";
            }

            MessageBox.Show(Result);
        }
    }
}
