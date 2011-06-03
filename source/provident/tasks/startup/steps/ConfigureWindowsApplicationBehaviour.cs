using System.Windows.Forms;
using provident.ui;

namespace provident.tasks.startup.steps
{
  public class UIBehaviours
  {
    public static ProgramLoop main_loop = Application.Run;
  }

  public class ConfigureWindowsApplicationBehaviour : IRunAStartupStep
  {
    public void run()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(true);
    }
  }
}