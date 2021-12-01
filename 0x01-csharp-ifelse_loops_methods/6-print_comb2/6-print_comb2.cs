using System;

namespace _6_print_comb2
{
  class Program
  {
    static void Main(string[] args)
    {
      for (int n1 = 0; n1 <= 8; n1++)
      {
        for (int n2 = n1 + 1; n2 <= 9; n2++)
        {
          Console.Write("{0}{1}{2}", n1, n2, n1 == 8 && n2 == 9 ? "\n" : ", ");
        }
      }
    }
  }
}
