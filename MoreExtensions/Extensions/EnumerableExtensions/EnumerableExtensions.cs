using System;
using System.Collections.Generic;
using System.Linq;

namespace MoreExtensions.EnumerableExtensions
{
  public static partial class EnumerableExtensions
  {
    public static IEnumerable<TInput> GetOrElse<TInput>(this IEnumerable<TInput> input, IEnumerable<TInput> nullIf)
    {
      return input ?? nullIf;
    }
    public static bool IsEmpty<T>(this IEnumerable<T> input)
    {
      if (input == null) throw new ArgumentNullException(nameof(input));
      return input.Count() == 0;
    }
    public static bool NonEmpty<T>(this IEnumerable<T> input)
    {
      if (input == null) throw new ArgumentNullException(nameof(input));
      return input.Count() > 0;
    }
    public static string ToDelimitedString<T>(this IEnumerable<T> input, string delimiter)
    {
      if (input == null) throw new ArgumentNullException(nameof(input));
      if (delimiter == null) throw new ArgumentNullException(nameof(delimiter));

      return string.Join(delimiter, input);
    }
    
    /// <summary>
    /// Builds a new list by applying a function to all elements of this list. 
    /// </summary>
    /// <typeparam name="TInput"></typeparam>
    /// <typeparam name="TOutput"></typeparam>
    /// <param name="input"></param>
    /// <param name="func"></param>
    /// <returns></returns>
    public static IEnumerable<TOutput> Apply<TInput, TOutput>(this IEnumerable<TInput> input, Func<TInput, TOutput> func)
    {
      if (input == null) throw new ArgumentNullException(nameof(input));
      if (func == null) throw new ArgumentNullException(nameof(func));

      foreach (var el in input)
      {
        yield return func(el);
      }
    }

    /// <summary>
    /// Builds a new list by applying a function to all elements of this list and then collecting in reverse direction. 
    /// </summary>
    /// <typeparam name="TInput"></typeparam>
    /// <typeparam name="TOutput"></typeparam>
    /// <param name="input"></param>
    /// <param name="func"></param>
    /// <returns></returns>
    public static IEnumerable<TOutput> ReverseApply<TInput, TOutput>(this IEnumerable<TInput> input, Func<TInput, TOutput> func)
    {
      return input.Apply(func).Reverse();
    }

    /// <summary>
    /// Builds a new sub list by using start and end params.
    /// </summary>
    /// <typeparam name="TInput"></typeparam>
    /// <param name="input"></param>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <returns></returns>
    public static IEnumerable<TInput> Slice<TInput>(this IEnumerable<TInput> input, int start, int end)
    {
      if (input == null) throw new ArgumentNullException(nameof(input));
      int length = input.Count();
      if (start < 0) throw new IndexOutOfRangeException();
      if (end > length - 1) throw new IndexOutOfRangeException();

      var list = input.ToList();
      for (int i = start; i <= end; i++)
      {
        yield return list[i];
      }
    }
  }
}
