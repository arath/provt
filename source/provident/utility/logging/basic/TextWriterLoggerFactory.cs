using System;

namespace provident.utility.logging.basic
{
  public class TextWriterLoggerFactory : ICreateLoggers
  {
    TextWriterLoggingWriterProvider writer_provider;

    public TextWriterLoggerFactory(TextWriterLoggingWriterProvider writer_provider)
    {
      this.writer_provider = writer_provider;
    }

    public ILogMessages create_logger_bound_to(Type type_that_requested_logging_services)
    {
      return new TextWriterLogger(writer_provider()); 
    }
  }
}