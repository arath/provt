using System.Collections.Generic;
using System.Reflection;
using developwithpassion.specifications.extensions;
using developwithpassion.specifications.rhinomocks;
using Machine.Specifications;
using Ninject;
using provident.tasks.startup;
using provident.tasks.startup.steps;
using provident.utility.containers;
using provident.utility.containers.ninject;

namespace provident.specs
{
  [Subject(typeof(ConfigureNinject))]
  public class ConfigureNinjectSpecs
  {
    public abstract class concern : Observes<IRunAStartupStep,
                                      ConfigureNinject>
    {
    }

    public class when_run : concern
    {
      Establish c = () =>
      {
        kernel = fake.an<IKernel>();
        the_created_container = fake.an<IResolveDependencies>();
        assemblies = new List<Assembly> {Assembly.GetExecutingAssembly()};

        ninject_factories = depends.on<ICreateNinjectItems>();

        ninject_factories.setup(x => x.create_kernel()).Return(kernel);
        ninject_factories.setup(x => x.create_container_adapter(kernel)).Return(the_created_container);
        ninject_factories.setup(x => x.all_module_resolution_assemblies()).Return(assemblies);
      };

      Because b = () =>
        sut.run();

      It should_configure_the_kernel_to_load_all_ninject_modules_with_the_resolved_assemblies = () =>
        kernel.received(x => x.Load(assemblies));

      It should_configure_the_container_static_gateway_with_a_ninject_container_adapter = () =>
      {
        Container.resolve.ShouldNotBeNull();
        Container.resolve.ShouldEqual(the_created_container);
      };

      static IResolveDependencies the_created_container;
      static IKernel kernel;
      static ICreateNinjectItems ninject_factories;
      static IEnumerable<Assembly> assemblies;
    }
  }
}