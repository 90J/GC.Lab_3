using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare
            string userNumber;
            int testNumber;
            string userName;
            string check;


            while (true)
            {

                //get input
                Console.WriteLine("Please enter your name: ");
                userName = Console.ReadLine();
                Console.WriteLine("Please enter a whole number between 1 and 100: ");
                userNumber = Console.ReadLine();

                testNumber = int.Parse(userNumber);

                //do math things
                if (testNumber % 2 != 0 && testNumber > 2)
                    Console.WriteLine(userName + " You entered " + userNumber + " Odd");

                else if (testNumber % 2 == 0 && testNumber > 1 && testNumber < 25)
                    Console.WriteLine(userName + " you entered " + userNumber + " Even and less that 25.");

                else if (testNumber % 2 == 0 && testNumber > 25 && testNumber < 61)
                    Console.WriteLine("Even");

                else if (testNumber > 60 && testNumber % 2 != 0)
                    Console.WriteLine(userName + " you entered " + userNumber + " Odd");

                //Check
                Console.WriteLine("Continue y/n: ");
                check = Console.ReadLine();
                if (check != "y")
                {
                    Console.WriteLine("Thanks for playing, " + userName + ".");
                    break;
                }
                else
                {
                    Console.WriteLine("Awesome, let's go again!");
                }
            }
        }
    }
}
