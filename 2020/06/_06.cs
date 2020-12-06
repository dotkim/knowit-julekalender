using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;

namespace Knowit
{
  public static class _06
  {
    private static string _Input = FileHelper.GetInput(@"06\input");

    public static void Run()
    {
      int sum = 0;
      foreach (int pack in Array.ConvertAll(_Input.Split(","), int.Parse))
      {
        sum += pack;
      }

      Console.WriteLine($"Luke 6:\t{sum / 127.0}");
    }
  }
}