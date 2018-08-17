using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenKata
{
    public static class Number
    {
        public static bool IsPrime(int i)
        {
            if (i == 2 || i == 3)
            {
                return true;
            }

            if (i % 2 == 0 || i % 3 == 0)
            {
                return false;
            }

            if (i < 2)
            {
                return false;
            }

            var ceiling = Math.Sqrt(i);
            for (int j = 3; j <= ceiling; j += 2)
            {
                if (i % j == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsEven(int i)
        {
            if (i % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public static bool IsOdd(int i)
        {
            if (i % 2 == 1)
            {
                return true;
            }
            return false;
        }
        
        public static string NumberToWord(int i)
        {

                 if (IsPrime(i))
                {
                    return "Prime";
                }
                else if (IsEven(i))
                {
                    return "Even";
                }
                else if (IsOdd(i))
                {
                    return "Odd";
                }

            return null;
        }

    }
}
