using System;
using System.Collections.Generic;

namespace Async
{
	class Program
	{
    static void Main(string[] args)
    {
      var worker = new Worker();
      Console.WriteLine();
    }
  }
  
  public class Worker
  {
    public Worker()
    {
      Work();
    }
    
    public void Work()
    {
      AsyncClass asyncClass = new AsyncClass();
      asyncClass.Work();
      Console.WriteLine("Im on the main thread");
    }
  }
}  
