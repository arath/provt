using developwithpassion.specifications.extensions;
using developwithpassion.specifications.rhinomocks;
using Machine.Specifications;
using Ninject;
using provident.utility.containers;
using provident.utility.containers.ninject;

namespace provident.specs
{
  [Subject(typeof(NinjectContainerAdapter))]
  public class NinjectContainerAdapterSpecs
  {
    public abstract class concern : Observes<IResolveDependencies,
                                      NinjectContainerAdapter>
    {
    }

    public class when_resolving_a_dependency : concern
    {
      Establish c = () =>
      {
        the_kernel = new StandardKernel();
        the_kernel.Bind<IAmAContract>().To<SomeType>();
        depends.on(the_kernel);
      };

      Because b = () =>
        result = sut.an<IAmAContract>();

      It should_return_the_dependency_from_ninject = () =>
        result.ShouldBeAn<SomeType>();

      static IAmAContract result;
      static IKernel the_kernel;
    }
  }

  public interface IAmAContract
  {
  }

  public class SomeType : IAmAContract
  {
  }
}