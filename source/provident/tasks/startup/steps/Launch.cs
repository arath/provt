using System.Windows.Forms;
using provident.utility.containers;

namespace provident.tasks.startup.steps
{
  public class Launch<TMainShell>: IAmTheFinalStepInStartup where TMainShell : Form
  {
    IResolveDependencies container;

    public Launch(IResolveDependencies container)
    {
      this.container = container;
    }

    public void run()
    {
      UIBehaviours.main_loop(container.an<TMainShell>());
    }
  }

}