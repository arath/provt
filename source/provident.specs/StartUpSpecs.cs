using developwithpassion.specifications.rhinomocks;
using Machine.Specifications;
using provident.tasks.startup;
using provident.utility.containers;
using provident.utility.logging;

namespace provident.specs
{
  [Subject(typeof(StartUp))]
  public class StartUpSpecs
  {
    public abstract class concern : Observes
    {
    }

    public class when_it_has_finished_running : concern
    {
      Because b = () =>
        StartUp.the_application();

      It should_be_able_to_access_key_application_services = () =>
        Container.resolve.an<ICreateLoggers>().ShouldNotBeNull();
    }
  }
}