using System;

namespace Knowit
{
  public static class _02
  {
    private static bool IsPrime(int number)
    {
      if (number <= 1) return false;
      if (number == 2) return true;
      if (number % 2 == 0) return false;

      var boundary = (int)Math.Floor(Math.Sqrt(number));

      for (int i = 3; i <= boundary; i += 2)
        if (number % i == 0)
          return false;

      return true;
    }

    public static void Run()
    {
      int pop = 5433000;
      int packages = 0;

      for (int i = 0; i <= pop; i++)
      {
        if (i.ToString().Contains('7'))
        {
          int prime = i;
          while (!IsPrime(prime)) prime--;
          i += prime;
          continue;
        }  
        packages++;
      }
      Console.WriteLine($"Luke 2:\t{packages}");
    }
  }
}
