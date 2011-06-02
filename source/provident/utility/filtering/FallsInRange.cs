using System;
using provident.utility.ranges;

namespace provident.utility.filtering
{
  public class FallsInRange<T> : IMatchAn<T> where T : IComparable<T>
  {
    IRange<T> range;

    public FallsInRange(IRange<T> range)
    {
      this.range = range;
    }

    public bool matches(T item)
    {
      return range.contains(item);
    }
  }
}