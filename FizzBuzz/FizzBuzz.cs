using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string Fizz(int v)
        {
            return (v % 3) == 0 ? "Fizz" : (v == 5) ? "Buzz" : "";
        }
    }
}
