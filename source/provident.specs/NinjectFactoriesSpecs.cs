using System;
using System.Collections.Generic;
using System.Reflection;
using Machine.Specifications;
using developwithpassion.specifications.rhinomocks;
using developwithpassion.specifications.extensions;
using Ninject;
using provident.utility.containers;
using provident.utility.containers.ninject;

namespace provident.specs
{
  [Subject(typeof(NinjectFactories))]
  public class NinjectFactoriesSpecs
  {
    public abstract class concern : Observes<ICreateNinjectItems,NinjectFactories>
    {

    }

    public class when_creating_a_kernel : concern
    {
      Because b = () =>
        result = sut.create_kernel();

      It should_be_able_to_create_a_standard_kernel = () =>
        result.ShouldBeAn<StandardKernel>();

      static IKernel result;
  
    }

    public class when_creating_a_container_adapter : concern
    {
      Establish c = () =>
      {
        kernel = fake.an<IKernel>();
      };

      Because b = () =>
        result = sut.create_container_adapter(kernel);

      It should_create_the_adapter_with_access_to_the_original_kernel = () =>
        result.ShouldBeAn<NinjectContainerAdapter>().kernel.ShouldEqual(kernel);

      static IKernel kernel;
      static IResolveDependencies result;
    }


    public class when_accessing_module_assembiles : concern
    {
      Because b = () =>
        result = sut.all_module_resolution_assemblies();

      It should_access_all_assemblies_in_the_current_app_domain = () =>
        result.ShouldEqual(AppDomain.CurrentDomain.GetAssemblies());

      static IEnumerable<Assembly> result;
   
    }

  }
}
