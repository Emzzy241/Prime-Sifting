using System;
using System.Collections.Generic;
using PrimeSifting.Models;

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

                PrimeDeterminer newDeterminer = new PrimeDeterminer(userNumDouble);
                List<double> allPrimeNums = newDeterminer.PrimeNumbersDeterminerMethod(userNumDouble);
                
                // Using a foreach to loop through the list and display all prime numbers below the number enterred
                Console.WriteLine();
                Console.WriteLine($"The Prime Numbers before {userNumDouble} are: ");
                foreach (double num in allPrimeNums)
                {
                    Console.WriteLine(num);
                }

                Console.WriteLine("To go again, Enter 1,  to quit or exit enter 2 ");
                string userContinue = Console.ReadLine();
                int userContinueInt = int.Parse(userContinue);
                 switch (userContinueInt)
                {
                    case 1:
                        Console.WriteLine();
                        Main();
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("Goodbye :(");
                        break;
                    default:
                        Console.WriteLine("Oops! I didn't get that, let's try again");
                        Console.WriteLine();
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
