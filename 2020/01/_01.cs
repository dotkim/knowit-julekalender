using System;
using System.Linq;

namespace Knowit
{
  public static class _01
  {
    private static ulong[] _Input = Array.ConvertAll(FileHelper.GetInput("01/input").Split(","), ulong.Parse);
    public static void Run()
    {
      ulong misRange = _Input.Aggregate((a, b) => a + b);
      ulong missing = (((ulong) 100000 * (100000 + 1))/2) - misRange;
      Console.WriteLine($"Luke 1:\t{missing}");
    }
    }
  }
}