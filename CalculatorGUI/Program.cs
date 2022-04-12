using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CalculatorGUI
{
   static class Program
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main()
      {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault( false );
            try
            {
                Application.Run(new CalculatorGUIForm());
            }
            catch(Exception e)
            {
                string message = "Please make sure to enter correct data, if more than one number is to be entered THEN PLACE A SPACE IN BETWEEN EACH NUMBER! Example: 21 2";
                MessageBox.Show(message);
                Application.Run(new CalculatorGUIForm());
            }
      }
   }
}
