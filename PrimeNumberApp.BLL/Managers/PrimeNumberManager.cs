﻿using System;
using PrimeNumberApp.BLL.Interfaces.Managers;

namespace PrimeNumberApp.BLL.Managers
{
    /// <summary>
    /// Manager class for prime number calculations
    /// </summary>
    public class PrimeNumberManager : IPrimeNumberManager
    {
        /// <summary>
        /// Check number is prime or not
        /// </summary>
        /// <param name="number">number to check</param>
        /// <returns></returns>
        public bool IsPrime(int number)
        {
            int sqrt = (int)Math.Sqrt(number) + 1;
            for (int i = 2; i < sqrt; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Determines the next smallest prime number after a given number. If parameter less than 1 returns 2.
        /// </summary>
        /// <param name="number">number to check the smallest prime number from</param>
        /// <returns></returns>
        public int NextPrimeAfterGivenNumber(int number)
        {
            // Base case
            if (number <= 1)
                return 2;

            var primeNumber = number;
            var isFound = false;

            // Loop till found the smallest prime
            while (!isFound)
            {
                primeNumber++;

                if (IsPrime(primeNumber))
                    isFound = true;
            }

            return primeNumber;
        }
    }
}