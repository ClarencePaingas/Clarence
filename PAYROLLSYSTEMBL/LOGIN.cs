using System;
using System.Collections.Generic;
using System.Text;
using PAYROLLSYSTEMCommon;

namespace PAYROLLSYSTEMBL
{
   public class LOGIN
    {

        string usernameInput;
        string passwordInput;
        int attempts = 0;

        public void Login()
        {
            USER user = new USER();
            user.Username = "admin";
            user.Password = "password";

            LoginDetails();

            if (usernameInput == user.Username &&
                passwordInput == user.Password)
            {
                MAINMENU mainMenu = new MAINMENU();
                mainMenu.MainMenu();
            }

            else
            {
                do
                {
                    Console.WriteLine("\nINVALID USERNAME OR PASSWORD PLEASE TRY AGAIN.");
                    LoginDetails();
                    attempts++;

                } while (usernameInput != user.Username ||
                         passwordInput != user.Password &&
                         attempts !=4);

                if (usernameInput == user.Username &&
                    passwordInput == user.Password)
                {
                    MAINMENU mainMenu = new MAINMENU();
                    mainMenu.MainMenu();
                }

                
                else
                {
                    Console.WriteLine("\n------------------------------------------------------------------------------------------");
                    Console.WriteLine("                              P R O G R A M   E X I T I N G");
                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                    Console.WriteLine("\nYOU HAVE EITHER REACHED THE MAXIMUM RETRIES POSSIBLE.");
                    Console.WriteLine("\nPLEASE TRY AGAIN LATER.2");
                    System.Environment.Exit(0);
                }
            }
        }

        public void LoginDetails()
        {
            

            Console.WriteLine("\n------------------------------------------------------------------------------------------");
            Console.WriteLine("                                         L O G I N");
            Console.WriteLine("------------------------------------------------------------------------------------------");
            Console.Write("\n\t\t\t\t     Username: ");
            usernameInput = Console.ReadLine();
            Console.Write("\t\t\t\t     Password: ");
            passwordInput = Console.ReadLine();
            Console.Clear();

            
        }

       
      


    }
}
