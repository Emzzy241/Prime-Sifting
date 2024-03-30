using System;

namespace PrimeSifting.Models
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the Prime Sifting Application");
            Console.WriteLine();
            Console.WriteLine("made by Dynasty");
            Console.WriteLine("A big thanks to the sieve of Eratosthenis");
            Console.WriteLine();

            try
            {
                Console.WriteLine("Enter a Number and I will return all of the prime numbers less than that number");
                Console.WriteLine();
                string userNumStr = Console.ReadLine();
                double userNumDouble = double.Parse(userNumStr);
                
                Console.WriteLine("To go again, Enter 1,  to quit or exit enter 0 ");
                string userContinue = Console.ReadLine();
                int userContinueInt = int.Parse(userContinue);
                 switch (userContinueInt)
                {
                    case 1:
                        Main();
                        break;
                    case 2:
                        Console.WriteLine("Goodbye :(");
                        break;
                    default:
                        Console.WriteLine("Oops! I didn't get that, let's try again");
                        Main();
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Oops! Please ensure you enter a number(e.g: 1,2,3,4) next time");
                Console.WriteLine();
                Console.WriteLine("Let's give it another try");
                Main();
            }
            }

        }        
    }    
}