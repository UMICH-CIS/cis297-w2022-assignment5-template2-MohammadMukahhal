using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculatorGUI
{
    /// <summary>
    /// Main GUI class to control the form
    /// </summary>
   public partial class CalculatorGUIForm : Form
   {
        /// <summary>
        /// Initizalization 
        /// </summary>
        public CalculatorGUIForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Method called when no white space button is clicked, removed the white space
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void noWhiteSpace_Click(object sender, EventArgs e)
        {
            String text = input.Text.Replace(" ", "");
            result.Text = text;
            input.Text = "";
        }
        /// <summary>
        /// Called when reverse string button is clicked, reverses the string
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reverseString_Click(object sender, EventArgs e)
        {
            char[] charArray = input.Text.ToCharArray();
            Array.Reverse(charArray);
            result.Text = String.Concat(charArray);
            input.Text = "";
        }
        /// <summary>
        /// Called when the quotient button is clicked, finds the quotient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quotient_Click(object sender, EventArgs e)
        {
            String[] array = input.Text.Split(' ');
            int divident = int.Parse(array.ElementAt(0));
            int divisor = int.Parse(array.ElementAt(1));
            int rem = 0;
            double quotient = Math.DivRem(divident, divisor, out rem);
            result.Text = quotient.ToString();
            input.Text = "";
        }
        /// <summary>
        /// Called when log 10 button is clicked, solves log 10 of a single number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void log10_Click(object sender, EventArgs e)
        {
            double number = double.Parse(input.Text);
            result.Text = Math.Log10(number).ToString();
            input.Text = "";
        }
        /// <summary>
        /// Called when log x button is cliked, solves for log of x
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logX_Click(object sender, EventArgs e)
        {
            String[] array = input.Text.Split(' ');
            int number = int.Parse(array.ElementAt(0));
            int baseNum = int.Parse(array.ElementAt(1));
            result.Text = Math.Log(number, baseNum).ToString();
            input.Text = "";
        }
        /// <summary>
        /// Called when min max button is cliked, finds the min max
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void minMax_Click(object sender, EventArgs e)
        {
            String[] array = input.Text.Split(' ');
            int firstNum = int.Parse(array.ElementAt(0));
            int secondNum = int.Parse(array.ElementAt(1));
            result.Text = (" Min: " + Math.Min(firstNum, secondNum) + "\n Max:" + Math.Max(firstNum, secondNum));
            input.Text = "";
        }
        /// <summary>
        /// Called when the power button is cliked, solves for the power
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void power_Click(object sender, EventArgs e)
        {
            String[] array = input.Text.Split(' ');
            int number = int.Parse(array.ElementAt(0));
            int power = int.Parse(array.ElementAt(1));
            result.Text = Math.Pow(number, power).ToString();
            input.Text = "";
        }
        /// <summary>
        /// Called when the quadtratic roots button is cicked, solves for the quadratic roots
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quad_Click(object sender, EventArgs e)
        {
            String[] array = input.Text.Split(' ');
            int a = int.Parse(array.ElementAt(0));
            int b = int.Parse(array.ElementAt(1));
            int c = int.Parse(array.ElementAt(2));
            QuadraticEquation1 qe1 = new QuadraticEquation1(a, b, c);
            qe1.ComputeDisc();
            qe1.ComputeSolution();
            result.Text = qe1.DisplaySolution();
            input.Text = "";
        }
        /// <summary>
        /// Called when the sqRoot button is cliked, solves for the square root
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sqRoot_Click(object sender, EventArgs e)
        {
            double num = int.Parse(input.Text);
            result.Text = Math.Sqrt(num).ToString();
        }
        /// <summary>
        /// Called when the exit button is clicked, terminates the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

/**************************************************************************
 * (C) Copyright 1992-2017 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/