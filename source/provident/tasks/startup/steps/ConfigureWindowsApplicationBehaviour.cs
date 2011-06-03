using System.Windows.Forms;

namespace provident.tasks.startup.steps
{
  public class ConfigureWindowsApplicationBehaviour : IRunAStartupStep
  {
    public void run()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(true);
    }
  }
}