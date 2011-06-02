using System;
using System.Diagnostics;

namespace provident.utility.logging
{
  public class Log
  {
    public static LoggerFactoryResolver logger_factory_resolver = () =>
    {
      throw new NotImplementedException("This needs to be configured at app startup");
    };

    public static ILogMessages an
    {
      get
      {
        return logger_factory_resolver().create_logger_bound_to(get_the_calling_type());
      }
    }

    static Type get_the_calling_type()
    {
      return new StackFrame(2).GetMethod().DeclaringType;
    }
  }
}