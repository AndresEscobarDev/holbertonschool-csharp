using System;
using System.Collections.Generic;
using System.Reflection;

/// <summary>
/// Obj class
/// </summary>
class Obj
{
  /// <summary>
  /// Prints the names of the available properties and methods of an object.
  /// </summary>
  /// <param name="myObj">Object</param>
  public static void Print(object myObj)
  {
    var objInfo = myObj.GetType().GetTypeInfo();
    Console.WriteLine("{0} Properties:", objInfo.Name);
    foreach (PropertyInfo property in objInfo.GetProperties())
    {
      Console.WriteLine(property.Name);
    }
    Console.WriteLine("{0} Methods:", objInfo.Name);
    foreach (MethodInfo method in objInfo.GetMethods())
    {
      Console.WriteLine(method.Name);
    }
  }
}
