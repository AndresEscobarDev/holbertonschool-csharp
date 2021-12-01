using System;

namespace _12_fizzbuzz
{
  class Program
  {
    static void Main(string[] args)
    {
      for (int n = 1; n <= 100; n++)
      {
        Console.Write("{0}{1}", n % 3 == 0 && n % 5 == 0 ? "FizzBuzz" : n % 3 == 0 ? "Fizz" : n % 5 == 0 ? "Buzz" : n.ToString(), n < 100 ? " " : "\n");
      }
    }
  }
}
