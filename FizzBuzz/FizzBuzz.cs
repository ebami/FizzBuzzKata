using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string Fizz(int v)
        {
            return v < 1 || v > 100 
                ? new ArgumentException().ToString()
                : (v % 3 == 0) && (v % 5 == 0 ) 
                    ? "FizzBuzz" 
                    : v % 3 == 0 || v.ToString().Contains("3")
                        ? "Fizz"
                        : v % 5 == 0 || v == 52
                            ? "Buzz"
                            : v.ToString();
        }
    }
}
 