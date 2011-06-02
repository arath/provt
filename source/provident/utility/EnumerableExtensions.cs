using System.Collections.Generic;
using provident.utility.filtering;

namespace provident.utility
{
  public static class EnumerableExtensions
  {
    public static IEnumerable<T> one_at_a_time<T>(this IEnumerable<T> items)
    {
      foreach (var item in items) yield return item;
    }

    public static IEnumerable<ItemToMatch> all_items_matching<ItemToMatch>(this IEnumerable<ItemToMatch> items,
                                                       IMatchAn<ItemToMatch> criteria)
    {
      return items.all_items_matching(criteria.matches);
    }

    public static IEnumerable<ItemToMatch> all_items_matching<ItemToMatch>(this IEnumerable<ItemToMatch> items,
                                                       Condition<ItemToMatch> condition)
    {
      foreach (var item_to_match in items)
      {
        if (condition(item_to_match)) yield return item_to_match;
      }
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