using System.Collections.Generic;
using System.Windows.Forms;
using Ninject.Modules;
using provident.utility;

namespace provident.tasks.startup.dependency_binding
{
  public class ViewsModule : NinjectModule
  {
    public override void Load()
    {
      Kernel.Bind<Shell>().ToSelf().InSingletonScope();
      Kernel.Bind<IGreetTheUser>().ToMethod(c => new RepetitiveGreeter(new SayHello()));
      Kernel.Bind<ITweakUI>().ToMethod(c => new ChainedUITweaker(
                                           new AppendMainMenu(), new AlterColors()));
    }
  }

  public class ChainedUITweaker : ITweakUI
  {
    IEnumerable<ITweakUI> all_ui_visitors;

    public ChainedUITweaker(params ITweakUI[] all_ui_visitors)
    {
      this.all_ui_visitors = all_ui_visitors;
    }

    public void visit(Control form)
    {
      all_ui_visitors.for_each(x => x.visit(form));
    }
  }
}