using System.Collections.Generic;
using Ninject;

namespace provident.utility.containers.ninject
{
  public class NinjectContainerAdapter : IResolveDependencies
  {
    public IKernel kernel;

    public NinjectContainerAdapter(IKernel kernel)
    {
      this.kernel = kernel;
    }

    public TDependency an<TDependency>()
    {
      return kernel.Get<TDependency>();
    }

    public IEnumerable<TDependency> all<TDependency>()
    {
      return kernel.GetAll<TDependency>();
    }
  }
}