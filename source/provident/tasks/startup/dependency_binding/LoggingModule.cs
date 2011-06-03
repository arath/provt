using System;
using Ninject.Modules;
using provident.utility.logging;
using provident.utility.logging.basic;

namespace provident.tasks.startup.dependency_binding
{
  public class LoggingModule : NinjectModule
  {
    public override void Load()
    {
      Kernel.Bind<TextWriterLoggingWriterProvider>().ToConstant(() => Console.Out);
      Kernel.Bind<ICreateLoggers>().To<TextWriterLoggerFactory>().InSingletonScope();
    }
  }
}