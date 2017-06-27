using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactors
{
    public class PrimeFactorsFinder
    {
        public List<int> Find(int number)
        {
            var factors = new List<int>();

            if (number < 2)
                return factors;

            var potentialPrime = 2;

            while (number > 1)
            {
                while (number.IsDivisibleBy(potentialPrime))
                {
                    factors.Add(potentialPrime);
                    number = number / potentialPrime;
                }

                potentialPrime++;
            }

            return factors;
        }

        
    }
}
