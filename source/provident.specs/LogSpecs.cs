using developwithpassion.specifications.extensions;
using developwithpassion.specifications.rhinomocks;
using Machine.Specifications;
using provident.utility.logging;

namespace provident.specs
{
  [Subject(typeof(Log))]
  public class LogSpecs
  {
    public abstract class concern : Observes
    {
    }

    public class when_accessing_logging_services : concern
    {
      Establish c = () =>
      {
        the_logger = fake.an<ILogMessages>();
        logger_factory = fake.an<ICreateLoggers>();

        LoggerFactoryResolver resolver = () => logger_factory;

        spec.change(() => Log.logger_factory_resolver).to(resolver);

        logger_factory.setup(x => x.create_logger_bound_to(typeof(when_accessing_logging_services)))
          .Return(the_logger);
      };

      Because b = () =>
        result = Log.an;

      It should_provide_access_to_the_underlying_logger = () =>
        result.ShouldEqual(the_logger);

      static ILogMessages result;
      static ILogMessages the_logger;
      static ICreateLoggers logger_factory;
    }
  }
}