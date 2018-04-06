using System.Text;
using System.Text.RegularExpressions;

namespace MoreExtensions.StringExtensions
{
  public static partial class StringExtensions
  {
    /// <summary>
    /// if string is null, it returns the valIfNull value
    /// </summary>
    /// <param name="input"></param>
    /// <param name="valIfNull"></param>
    /// <returns></returns>
    public static string GetOrElse(this string input, string valIfNull)
    {
      return input.IsNull() ? valIfNull : input;
    }
    public static string Repeat(this char input, int times)
    {
      return new string(input, times);
    }
    public static string Repeat(this string input, int times)
    {
      if (string.IsNullOrEmpty(input)) return input;
      StringBuilder sb = new StringBuilder();
      for (int i = 1; i <= times; i++)
        sb.Append(input);
      return sb.ToString();
    }
    /// <summary>
    /// Capitalizes All Words in a string
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static string CapitalizeWords(this string input)
    {
      if (input.IsNullOrEmptyOrWhiteSpace()) return input;
      StringBuilder sb = new StringBuilder();

      foreach (var word in input.MultipleSpacesToOne().Split(' '))
      {
        sb.Append(word.Capitalize()).Append(' ');
      }
      return sb.ToString().Trim();
    }
    /// <summary>
    /// Capitalizes first letter of the string
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static string Capitalize(this string input)
    {
      if (input.IsNullOrEmptyOrWhiteSpace()) return input;
      return string.Concat(input.Take(1).ToUpper(), input.Skip(1));
    }
    public static string Reverse(this string input)
    {
      if (input == null) return input;
      StringBuilder output = new StringBuilder();
      for (int j = input.Length - 1; j >= 0; j--)
      {
        output.Append(input[j]);
      }
      return output.ToString();
    }
    public static bool IsNull(this string input)
    {
      return input == null;
    }
    public static bool IsEmpty(this string input)
    {
      return input == string.Empty;
    }
    public static bool IsWhiteSpace(this string input)
    {
      return input.MultipleSpacesToOne() == " ";
    }
    public static bool IsNullOrEmpty(this string input)
    {
      return input.IsNull() || input.IsEmpty();
    }
    public static bool IsNullOrWhiteSpace(this string input)
    {
      return input == null || input.IsWhiteSpace();
    }
    public static bool IsNullOrEmptyOrWhiteSpace(this string input)
    {
      return input.IsNull() || input.IsEmpty() || input.IsWhiteSpace();
    }
    public static bool ContainsNonAscii(this string input)
    {
      return new Regex("[^\x00-\x7F]").IsMatch(input ?? "");
    }
  }
}
