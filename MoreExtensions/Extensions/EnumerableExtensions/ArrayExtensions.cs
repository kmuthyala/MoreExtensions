using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreExtensions.Extensions.EnumerableExtensions
{
  public static class ArrayExtensions
  {
  /// <summary>
  /// instance of type T needs to implement IEquality
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="array"></param>
  /// <param name="value"></param>
  /// <returns></returns>
    public static bool Contains<T>(this T[] array, T value) where T : struct
    {
      foreach (T t in array)
        if (value.Equals(t)) return true;
      return false;
    }
  }
}
