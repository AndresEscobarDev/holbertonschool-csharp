using System;

namespace _5_print_comb
{
  class Program
  {
    static void Main(string[] args)
    {
      for (int n = 0; n < 100; n++)
      {
        Console.Write("{0:D2}{1}", n, n < 99 ? ", " : "\n");
      }
    }
  }
}
