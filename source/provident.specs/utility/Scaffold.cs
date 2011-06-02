using developwithpassion.specifications.core;
using developwithpassion.specifications.extensions;
using provident.utility.containers;

namespace provident.specs.utility
{
  public class Scaffold
  {
    public static void container_returned<TDependency>(TDependency dependency, IConfigureSetupPairs pipeline,
                                                       ICreateFakes fake)
    {
      var container = fake.an<IResolveDependencies>();
      var original = Container.container_resolver;
      ContainerResolver resolver = () => container;
      container.setup(x => x.an<TDependency>()).Return(dependency);
      pipeline.add_setup_teardown_pair(() =>
      {
        Container.container_resolver = resolver;
      },
                                       () =>
                                       {
                                         Container.container_resolver = original;
                                       });
    }
  }
}