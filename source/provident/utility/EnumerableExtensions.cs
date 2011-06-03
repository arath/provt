using System;
using System.Collections.Generic;

namespace provident.utility
{
  public static class EnumerableExtensions
  {
    public static void for_each<T>(this IEnumerable<T> items,Action<T> visitor)
    {
      foreach (var item in items) visitor(item);
    }
  }
}