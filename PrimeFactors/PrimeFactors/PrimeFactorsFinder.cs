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

            if (number == 2)
                factors.Add(2);
            if (number == 3)
                factors.Add(3);

            return factors;
        }
    }
}
