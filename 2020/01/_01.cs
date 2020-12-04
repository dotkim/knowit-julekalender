using System;
using System.Linq;

namespace Knowit
{
  public static class _01
  {
    private static int[] _Input = Array.ConvertAll(FileHelper.GetInput("01/input").Split(","), int.Parse);
    public static void Run()
    {
      ulong range = Enumerable.Range(1, 100000)
        .Select(i => (ulong)i)
        .Aggregate((a, b) => a + b);

      ulong misRange = _Input
        .Select(i => (ulong)i)
        .Aggregate((a, b) => a + b);

      ulong missing = range - misRange;
      Console.WriteLine($"Luke 1:\t{missing}");
    }
  }
}