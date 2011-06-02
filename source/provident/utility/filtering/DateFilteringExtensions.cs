using System;
using provident.utility.ranges;

namespace provident.utility.filtering
{
  public static class DateFilteringExtensions
  {
    public static IMatchAn<TItemToMatch> greater_than<TItemToMatch>(this FilteringExtensionPoint<TItemToMatch,DateTime> extension_point, int year)
    {
      return extension_point.create_criteria_using(new YearIsGreaterThan(year));
    }
  }

  public class YearIsGreaterThan : IMatchAn<DateTime>
  {
    IRange<int> range;

    public YearIsGreaterThan(int year_value)
    {
      this.range = new ExclusiveRangeWithNoUpperBound<int>(year_value);
    }

    public bool matches(DateTime item)
    {
      return range.contains(item.Year);
    }
  }
}