using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;

namespace Knowit
{
  public static class _05
  {
    private static string _Input = FileHelper.GetInput(@"05\input");

    public static void Run()
    {
      int minY = 0;
      int maxY = 0;
      int minX = 0;
      int maxX = 0;

      Point loc = new Point(0, 0);
      List<Point> cords = new List<Point>();
      cords.Add(loc);

      foreach (char dir in _Input)
      {
        switch (dir)
        {
          case 'O': loc.Y++; maxY = Math.Max(maxY, loc.Y); break;
          case 'N': loc.Y--; minY = Math.Min(minY, loc.Y); break;
          case 'H': loc.X++; maxX = Math.Max(maxX, loc.X); break;
          case 'V': loc.X--; minX = Math.Min(minX, loc.X); break;
        }
        cords.Add(loc);
      }

      var area = Math.Abs(cords.Take(cords.Count - 1)
        .Select((p, i) => (cords[i + 1].X - p.X) * (cords[i + 1].Y + p.Y))
        .Sum() / 2);

      Console.WriteLine($"Luke 5:\t{area}");
    }
  }
}