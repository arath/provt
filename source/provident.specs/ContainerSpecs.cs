using Machine.Specifications;
using developwithpassion.specifications.rhinomocks;
using developwithpassion.specifications.extensions;
using provident.utility.container;

namespace provident.specs
{
  [Subject(typeof(Container))]
  public class ContainerSpecs
  {
    public abstract class concern : Observes
    {

    }

    public class when_requesting_container_services : concern
    {
      Establish c = () =>
      {
        the_underlying_container = fake.an<IResolveDependencies>();

        ContainerResolver resolver = () => the_underlying_container;

        spec.change(() => Container.container_resolver).to(resolver);
      };

      Because b = () =>
        result = Container.resolve;

      It should_provide_access_to_the_underlying_container = () =>
        result.ShouldEqual(the_underlying_container);


      static IResolveDependencies result;
      static IResolveDependencies the_underlying_container;
    }
  }
}
