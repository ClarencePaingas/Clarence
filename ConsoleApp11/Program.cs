using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            String user = "Group5";
            String pw = "CE2102";
            String uinput, pwinput;
            int attempts = 0;
            do
            {
                Console.WriteLine("USE ONLY CAPITAL LETTERS");
                Console.WriteLine("Username: ");
                uinput = Console.ReadLine();

                Console.WriteLine("Password: ");
                pwinput = Console.ReadLine();

                attempts++;
            } while (!uinput.Equals(user) && !pwinput.Equals(pw) && attempts != 5);
            if (uinput.Equals(user) && pwinput.Equals(pw))
            {
                Console.WriteLine("Log In Successfully");
            }
            else if (uinput.Equals(user))
            {
                do
                {
                    Console.WriteLine("Invalid password");
                    Console.WriteLine("correct pw: ");
                    pwinput = Console.ReadLine();

                    attempts++;
                } while (!pwinput.Equals(pw) && attempts != 5);
                if (pwinput.Equals(pw))
                {
                    Console.WriteLine("Log In Successfully");
                }
                else if (attempts == 5)
                {
                    Console.WriteLine("Log In INCORRECT");
                }
            }
            else if (pwinput.Equals(pw))
            {
                do
                {
                    Console.WriteLine("INvalid usernname");
                    Console.WriteLine("username: ");
                    uinput = Console.ReadLine();

                    attempts++;
                } while (!uinput.Equals(user) && attempts != 5);
                if (uinput.Equals(user))
                {
                    Console.WriteLine("Log in successfully");
                }
                else if (attempts == 5)
                {
                    Console.WriteLine("Log in INCORRECT");
                }
            }
            else if (attempts == 5)
            {
                Console.WriteLine("Log In Incorrect");
            }
        }
    }
}
