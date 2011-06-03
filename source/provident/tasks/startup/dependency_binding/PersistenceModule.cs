using Ninject.Modules;
using provident.tasks.startup.steps;

namespace provident.tasks.startup.dependency_binding
{
  public class PersistenceModule : NinjectModule
  {
    public override void Load()
    {
      Kernel.Bind<ConfigureSomeTracks>().ToSelf().InSingletonScope();
    }
  }
}