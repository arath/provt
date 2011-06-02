using System;
using provident.utility.filtering;

namespace provident.utility.ranges
{
  public static class RangeExtensions
  {
    public static IMatchAn<T> as_specification<T>(this IRange<T> range) where T : IComparable<T>
    {
      return new FallsInRange<T>(range);
    }
  }
}