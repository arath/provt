using System.Windows.Forms;

namespace provident.tasks.startup.steps
{
  public class HookupGlobalExceptionHandling : IRunAStartupStep
  {
    public void run()
    {
      Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
    }
  }
}