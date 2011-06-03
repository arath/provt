using System;
using System.Collections.Generic;
using System.Reflection;
using Ninject;

namespace provident.utility.containers.ninject
{
  public interface ICreateNinjectItems
  {
    IKernel create_kernel();
    IResolveDependencies create_container_adapter(IKernel kernel);
    IEnumerable<Assembly> all_module_resolution_assemblies();
  }

  public class NinjectFactories : ICreateNinjectItems
  {
    public IKernel create_kernel()
    {
      return new StandardKernel();
    }

    public IEnumerable<Assembly> all_module_resolution_assemblies()
    {
      return AppDomain.CurrentDomain.GetAssemblies();
    }

    public IResolveDependencies create_container_adapter(IKernel kernel)
    {
      return new NinjectContainerAdapter(kernel);
    }
  }
}