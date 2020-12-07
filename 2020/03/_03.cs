using System;
using System.Collections.Generic;

namespace Knowit
{
  public static class _03
  {
    private static string[] _Input = FileHelper.GetInput(@"03/input").Split("\r\n");
    private static int _ColLen = _Input[0].Length;
    private static int _RowLen = _Input.Length;

    private static string[] _Words = FileHelper.GetInput(@"03/words").Split("\r\n");

    private static int[] _Xdir = { -1, -1, 0, +1, +1, +1, 0, -1 };
    private static int[] _Ydir = { 0, -1, -1, -1, 0, +1, +1, +1 };

    public static void Run()
    {
      List<char[]> grid = new List<char[]>();
      foreach (string line in _Input) grid.Add(line.ToCharArray());

      List<string> found = new List<string>();

      foreach (string word in _Words)
      {
        for (int row = 0; row < _RowLen; row++)
        {
          for (int col = 0; col < _ColLen; col++)
          {
            if (Search2D(grid.ToArray(), row, col, word))
            {
              found.Add(word);
            }
          }
        }
      }
      List<string> missing = new List<string>();

      foreach (string word in _Words) if (!found.Contains(word)) missing.Add(word);

      missing.Sort();
      Console.WriteLine($"Luke 3:\t{string.Join(',', missing)}");
    }

    private static bool Search2D(char[][] grid, int row, int col, string word)
    {
      if (grid[row][col] != word[0]) return false;

      int len = word.Length;
      for (int dir = 0; dir < 8; dir++)
      {
        int check, rd = row + _Xdir[dir], cd = col + _Ydir[dir];
        for (check = 1; check < len; check++)
        {
          if (rd >= _RowLen || rd < 0 || cd >= _ColLen || cd < 0)
          {
            break;
          }

          if (grid[rd][cd] != word[check])
          {
            break;
          }

          rd += _Xdir[dir];
          cd += _Ydir[dir];
        }

        if (check == len)
        {
          return true;
        }
      }
      return false;
    }
  }
}