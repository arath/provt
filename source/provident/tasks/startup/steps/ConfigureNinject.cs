using Ninject;
using provident.utility.containers;
using provident.utility.containers.ninject;

namespace provident.tasks.startup.steps
{
  public class ConfigureNinject
  {
    ICreateNinjectItems ninject_factory;

    public ConfigureNinject() : this(new NinjectFactories())
    {
    }

    public ConfigureNinject(ICreateNinjectItems ninject_factory)
    {
      this.ninject_factory = ninject_factory;
    }

    public void run()
    {
      var kernel = ninject_factory.create_kernel();
      var container_adapter = ninject_factory.create_container_adapter(
        kernel);

      kernel.Bind<IKernel>().ToConstant(kernel);
      kernel.Bind<IResolveDependencies>().ToConstant(container_adapter);
      kernel.Load(ninject_factory.all_module_resolution_assemblies());

      Container.container_resolver = () => container_adapter;
    }
  }
}