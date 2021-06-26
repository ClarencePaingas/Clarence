using System;
using System.Collections.Generic;
using System.Text;

namespace PAYROLLSYSTEMBL
{
    public class MAINMENU
    {
        public void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("\n------------------------------------------------------------------------------------------");
            Console.WriteLine("                     W E L C O M E   T O   P A Y R O L L   S Y S T E M");
            Console.WriteLine("------------------------------------------------------------------------------------------");
            Console.WriteLine("\n\t\t\tPLEASE INPUT ANY OF THE FOLLOWING OPTIONS.");
            Console.WriteLine("\n\t\t\t\tA - Create Payroll" +
                              "\n\t\t\t\tB - Employee Management" +
                              "\n\t\t\t\tC - Payroll History" +
                              "\n\t\t\t\tD - User Logs");
            Console.WriteLine("\n------------------------------------------------------------------------------------------");
            Console.Write("INPUT: ");
            var input = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (input)
            {
                case 'A' :
                    CREATEPAYROLL goTo = new CREATEPAYROLL();
                    goTo.CreatePayroll();
                    break;

                case 'B':
                    Console.WriteLine("Employee Management to");
                    break;

                case 'C':
                    Console.WriteLine("Payroll History to");
                    break;

                case 'D':
                    Console.WriteLine("User Logs to");
                    break;

                default:
                    Console.WriteLine("\n------------------------------------------------------------------------------------------");
                    Console.WriteLine("                                     E R R O R");
                    Console.WriteLine("------------------------------------------------------------------------------------------");
                    Console.WriteLine("\nINVALID INPUT. PRESS ANY KEY TO GO BACK TO MAIN MENU.");
                    Console.ReadKey();

                    MainMenu();
                    break;
            }
        }

    }
}
