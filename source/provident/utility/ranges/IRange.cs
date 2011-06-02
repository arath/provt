using System;

namespace provident.utility.ranges
{
  public interface IRange<in T> where T : IComparable<T>
  {
    bool contains(T item);
  }
}