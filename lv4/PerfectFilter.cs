using System;
using System.Collections.Generic;
using System.Text;

namespace lv4
{
    public class PerfectFilter : IIntegerFilter
    {
        public bool IsValid(int number)
        {
            if (number >= 0)
            {
                int sum = 1;
                for (int i = 2; i * i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        if (i * i != number) { sum = sum + i + number / i; }
                        else { sum = sum + i; }
                    }
                }
                if (sum == number && number != 1) { return true; }
                return false;
            }
            else { return false; }
        }
    }
}
