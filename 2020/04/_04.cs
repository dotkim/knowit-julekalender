using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Knowit
{
  public static class _04
  {
    private static string[] _Input = Regex.Split(FileHelper.GetInput(@"04\input"), @",\s|\r\n");

    public static void Run()
    {
      Dictionary<string, ulong> units = new Dictionary<string, ulong>
      {
        {"sukker", 0}, {"mel", 0}, {"melk", 0}, {"egg", 0}
      };

      foreach (string line in _Input)
      {
        string[] item = line.Split(": ");
        units[item[0]] += ulong.Parse(item[1]);
      }

      units["sukker"] = units["sukker"] / 2;
      units["mel"] = units["mel"] / 3;
      units["melk"] = units["melk"] / 3;

      Console.WriteLine($"Luke 4:\t{units.Values.Min()}");
    }
  }
}