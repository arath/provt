using System;
using System.Linq;

namespace provident.utility.contracts
{
  public class Check
  {
    public static void true_for_all<T>(Func<T,bool> condition,params T[] values)
    {
      if (values.All(condition)) return;
      throw new ArgumentException("Not all the values match the condition");
    }

    public static void ensure_not_null<T>(T value) where T : class
    {
      if (value != null) return;
      throw new ArgumentException("This should not be null");
    }
  }
}