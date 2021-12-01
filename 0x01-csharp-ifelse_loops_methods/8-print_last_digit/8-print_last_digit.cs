using System;

class Number
{
  public static int PrintLastDigit(int number)
  {
    int num = number % 10;
    Console.Write("{0}", num < 0 ? num * -1 : num);
    return num < 0 ? num * -1 : num;
  }
}
