using System;
using System.Collections.Generic;
using System.Text;

namespace lv4
{
    public class PrimeFilter : IIntegerFilter
    {
        public bool IsValid(int number)
        {
            if (number >= 0)
            {
                int counter = 0;
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0) { counter++; }
                }
                return (counter == 2);
            }
            else { return false; }
        }
    }
}
