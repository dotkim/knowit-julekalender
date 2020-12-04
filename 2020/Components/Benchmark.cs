using System;
using System.Diagnostics;

namespace Knowit
{
  public static class Benchmark
  {
    public static void Method(Action action)
    {
      Stopwatch stopwatch = Stopwatch.StartNew();
      action();
      stopwatch.Stop();
      Console.WriteLine($"TTR {action.Method.DeclaringType}\t{stopwatch.Elapsed}");
    }
  }
}