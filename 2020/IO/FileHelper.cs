using System.IO;

namespace Knowit
{
  public static class FileHelper
  {
    public static string GetInput(string file)
    {
      return File.ReadAllText(file);
    }
  }
}