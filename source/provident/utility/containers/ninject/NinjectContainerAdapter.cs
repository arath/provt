using Ninject;

namespace provident.utility.containers.ninject
{
  public class NinjectContainerAdapter : IResolveDependencies
  {
    IKernel kernel;

    public NinjectContainerAdapter(IKernel kernel)
    {
      this.kernel = kernel;
    }

    public TDependency an<TDependency>()
    {
      return kernel.Get<TDependency>();
    }
  }
}