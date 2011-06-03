using provident.tasks.startup.steps;

namespace provident.tasks.startup
{
  public class StartUp
  {
    public static void the_application()
    {
      new ConfigureNinject().run();

      Start.by<ConfigureWindowsApplicationBehaviour>()
        .followed_by<HookupGlobalExceptionHandling>()
        .end_with<Launch<Shell>>();
    }
  }
}