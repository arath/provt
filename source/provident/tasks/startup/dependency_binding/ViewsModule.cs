using Ninject.Modules;

namespace provident.tasks.startup.dependency_binding
{
  public class ViewsModule : NinjectModule
  {
    public override void Load()
    {
      Kernel.Bind<Shell>().ToSelf().InSingletonScope();
    }
  }
}