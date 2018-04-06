using System.Text.RegularExpressions;
using System.Linq;
using System;

namespace MoreExtensions.StringExtensions
{
  public static partial class StringManipulation
  {
  /// <summary>
  /// Trims a string from the end
  /// </summary>
  /// <param name="input"></param>
  /// <param name="strToRemove"></param>
  /// <returns></returns>
    public static string TrimEnd(this string input, string strToRemove)
    {
      if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(strToRemove))
        return input;
      if (!input.EndsWith(strToRemove))
        return input;

      return input.Substring(0, input.Length - strToRemove.Length);
    }
    /// <summary>
    /// Trims a string from the start
    /// </summary>
    /// <param name="input"></param>
    /// <param name="strToRemove"></param>
    /// <returns></returns>
    public static string TrimStart(this string input, string strToRemove)
    {
      if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(strToRemove))
        return input;
      if (!input.StartsWith(strToRemove))
        return input;

      return input.Substring(strToRemove.Length, input.Length - strToRemove.Length);
    }
    /// <summary>
    /// Replaces multiple spaces with a single space
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static string MultipleSpacesToOne(this string input)
    {
      return input.IsNull() ? input : Regex.Replace(input, "\\s+", " ");
    }
    public static string Take(this string input, int length)
    {
      if (input.IsNullOrEmpty() || length <= 0 || input.Length < length) return input;
      return input.Substring(0, length);
    }
    public static string TakeRight(this string input, int length)
    {
      if (input.IsNullOrEmpty() || length <= 0 || input.Length < length) return input;
      return input.Substring(input.Length - length);
    }
    public static string Skip(this string input, int length)
    {
      return TakeRight(input, length);// just syntactic sugar for anyone who prefers this
    }
    public static string SkipRight(this string input, int length)
    {
      return Take(input, length); // just syntactic sugar for anyone who prefers this
    }
  }
}
