// https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-nunit?source=recommendations
using System;

namespace Prime.Services
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate <= 1) 
            {
                return false;
            }
            else if (candidate == 2 || candidate == 3)
            {
                return true;
            }
            else if (candidate % 2 == 0 || candidate % 3 == 0)
            {
                return false;
            }
            else if (candidate >= 5)
            {
                // 6K +/- 1
                for (int i = 5; i * i <= candidate; i += 6)
                    {
                        if (candidate % i == 0 || candidate % (i + 2) == 0)
                        {
                            return false;
                        }
                    }
            }

            return true;
        }

        public string PrimeStatement(int number) 
        {
            if (IsPrime(number) == true)
            {
                return($"{number} is, in fact, a prime number.");
            }

            return($"{number} is not a prime number.");
        }
    }
}