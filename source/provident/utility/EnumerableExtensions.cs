using System.Collections.Generic;

namespace provident.utility
{
  public static class EnumerableExtensions
  {
    public static IEnumerable<T> one_at_a_time<T>(this IEnumerable<T> items)
    {
      foreach (var item in items) yield return item;
    }

    public static IEnumerable<TItemToSort> sort_using<TItemToSort>(this IEnumerable<TItemToSort> items,
                                                                   IComparer<TItemToSort> comparer)
    {
      var sorted = new List<TItemToSort>(items);
      sorted.Sort(comparer);
      return sorted;
    }
  }
}