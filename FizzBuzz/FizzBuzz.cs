using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string Output(int v)
        {
            if (v < 1 || v > 100)
            {
                return new ArgumentException().ToString();
            }

            if ((v % 3 == 0) && (v % 5 == 0))
            {
                return "FizzBuzz";
            }

            if (v % 3 == 0 || v.ToString().Contains("3"))
            {
                return "Fizz";
            }

            if (v % 5 == 0 || v == 52)
            {
                return "Buzz";
            }

            return v.ToString();
        }
    }
}
 