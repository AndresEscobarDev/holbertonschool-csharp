using System;
using System.Collections.Generic;

class MyStack
{
  public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
  {
    Console.WriteLine("Number of items: {0}", aStack.Count);
    Console.WriteLine(aStack.Count == 0 ? "Stack is empty" : $"Top item: {aStack.Peek()}");
    Console.WriteLine("Stack contains \"{0}\": {1}", search, aStack.Contains(search));
    while (aStack.Contains(search)) aStack.Pop();
    aStack.Push(newItem);
    return aStack;
  }
}
