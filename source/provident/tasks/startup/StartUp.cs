using provident.tasks.startup.steps;

namespace provident.tasks.startup
{
  public class StartUp
  {
    public static void the_application()
    {
      //      Application.EnableVisualStyles();
      //      Application.SetCompatibleTextRenderingDefault(true);

      new ConfigureNinject().run();

      Start.by<ConfiguringCoreServices>()
        .followed_by<ApplyingVisualStyling>()
        .followed_by<HookupGlobalExceptionHandling>()
        .end_with<Launch<Shell>>();

      //      Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
      //      Application.Run(new Shell());
    }
  }
}