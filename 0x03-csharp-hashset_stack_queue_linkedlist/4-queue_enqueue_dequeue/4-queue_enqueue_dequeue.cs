using System;
using System.Collections.Generic;

class MyQueue
{
  public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
  {
    Console.WriteLine("Number of items: {0}", aQueue.Count);
    Console.WriteLine(aQueue.Count == 0 ? "Queue is empty" : $"First item: {aQueue.Peek()}");
    aQueue.Enqueue(newItem);
    Console.WriteLine("Queue contains \"{0}\": {1}", search, aQueue.Contains(search));
    while (aQueue.Contains(search)) aQueue.Dequeue();
    return aQueue;
  }
}
