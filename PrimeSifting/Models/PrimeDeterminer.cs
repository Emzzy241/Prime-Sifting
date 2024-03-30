using System;
using System.Collections.Generic;

namespace PrimeSifting.Models
{
    public class PrimeDeterminer
    {
        public double Number { get; set; }
        
        public PrimeDeterminer(double myNumber)
        {
            Number = myNumber;
        }

        public List<double> PrimeNumbersDeterminerMethod(double num)
        {
            List<double> allPrimeNums = new List<double>(){};

            // Start the looping from 2 till the number...
            // A Prime number is a number greater than 1 that can only be divisible by 1 and itself
            // Using the sieve of eratosthenis
            for (double i = 2; i < num; i++)
            {
                // Determining PrimeNumbers below 10
                if((i == 2) || (i == 3) || (i == 5) || (i == 7))
                {
                    allPrimeNums.Add(i);
                }
                // Determining primeNumbers above 10 till infinit; all thanks to the sieve of Eratosthenis
                else if ((i % 7 != 0 ) && (i % 5 != 0) && (i % 3 != 0) &&( i % 2 != 0))
                {
                    allPrimeNums.Add(i);
                }
            }
            return allPrimeNums;
            // Thanks to sieve of eratosthenis, once the prime numbers less than 10 have been determined, then prime numbers till infinty can be determined.

        }

    }    
}