using System;
using System.Text;

namespace MoreExtensions.Extensions
{
  public static class ExceptionExtensions
  {
  /// <summary>
  /// message + inner exception + stack trace
  /// </summary>
  /// <param name="e"></param>
  /// <returns></returns>
    public static string FormatAll(this Exception e)
    {
      var sb = new StringBuilder();
      if (e != null)
      {
        GetMessage(sb, e);
        GetInnerException(sb, e);
        GetStackTrace(sb, e);
      }
      return sb.ToString();
    }
    /// <summary>
    /// message + Stack Trace
    /// </summary>
    /// <param name="e"></param>
    /// <returns></returns>
    public static string FormatBasic(this Exception e)
    {
      var sb = new StringBuilder();
      if (e != null)
      {
        GetMessage(sb, e);
        GetStackTrace(sb, e);
      }
      return sb.ToString();
    }

    private static void GetMessage(StringBuilder sb, Exception e)
    {
      AddSeparator(sb);
      sb.AppendLine("Message:");
      sb.AppendLine(e.Message ?? "");
    }
    private static void GetStackTrace(StringBuilder sb, Exception e)
    {
      AddSeparator(sb);
      sb.AppendLine("Stack Trace:");
      sb.AppendLine(e.StackTrace ?? "");
    }
    private static void GetInnerException(StringBuilder sb, Exception e)
    {
      var innerException = e.InnerException;
      while (innerException != null)
      {
        AddSeparator(sb);
        sb.AppendLine("Inner Exception:");
        GetMessage(sb, e.InnerException);
        GetStackTrace(sb, e.InnerException);
        innerException = innerException.InnerException;
      }
    }

    private static void AddSeparator(StringBuilder sb)
    {
      sb.AppendLine("========================");
    }
  }
}
