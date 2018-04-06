namespace MoreExtensions.StringExtensions
{
  public static partial class StringExtensions
  {
    /// <summary>
    /// Checks if string is an integer
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool IsInteger(this string input)
    {
      return ToNullableInt(input).HasValue;
    }

    /// <summary>
    /// Converts string to INT. Throws exception if not in right format
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static int ToInt(this string input)
    {
      return int.Parse(input);
    }
    /// <summary>
    /// Tries to resolve string to int else returns null.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static int? ToNullableInt(this string input)
    {
      int output = 0;
      if (int.TryParse(input, out output))
        return output;
      return null;
    }
    /// <summary>
    /// Checks if string is a float
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool IsFloat(this string input)
    {
      return ToNullableFloat(input).HasValue;
    }

    /// <summary>
    /// Converts string to float. Throws exception if not in right format
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static float ToFloat(this string input)
    {
      return float.Parse(input);
    }
    /// <summary>
    /// Tries to resolve string to float else returns null.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static float? ToNullableFloat(this string input)
    {
      float output = 0;
      if (float.TryParse(input, out output))
        return output;
      return null;
    }

    /// <summary>
    /// Checks if string is a double
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool IsDouble(this string input)
    {
      return ToNullableDouble(input).HasValue;
    }

    /// <summary>
    /// Converts string to double. Throws exception if not in right format
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static double ToDouble(this string input)
    {
      return double.Parse(input);
    }
    /// <summary>
    /// Tries to resolve string to double else returns null.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static double? ToNullableDouble(this string input)
    {
      double output = 0;
      if (double.TryParse(input, out output))
        return output;
      return null;
    }

    /// <summary>
    /// Checks if string is a decimal
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool IsDecimal(this string input)
    {
      return ToNullableDouble(input).HasValue;
    }

    /// <summary>
    /// Converts string to decimal. Throws exception if not in right format
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static decimal ToDecimal(this string input)
    {
      return decimal.Parse(input);
    }
    /// <summary>
    /// Tries to resolve string to decimal else returns null.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static decimal? ToNullableDecimal(this string input)
    {
      decimal output = 0;
      if (decimal.TryParse(input, out output))
        return output;
      return null;
    }
  }
}
