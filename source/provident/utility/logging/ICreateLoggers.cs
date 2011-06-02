using System;

namespace provident.utility.logging
{
  public interface ICreateLoggers
  {
    ILogMessages create_logger_bound_to(Type type_that_requested_logging_services);
  }
}