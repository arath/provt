using System;
using System.Diagnostics;
using provident.utility.containers;

namespace provident.utility.logging
{
  public class Log
  {
    public static ILogMessages an
    {
      get
      {
        return Container.resolve.an<ICreateLoggers>().create_logger_bound_to(get_the_calling_type());
      }
    }

    static Type get_the_calling_type()
    {
      return new StackFrame(2).GetMethod().DeclaringType;
    }
  }
}