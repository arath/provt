namespace provident.tasks.startup
{
  public class StartUp
  {
    public static void the_application()
    {
      Start.by_running_all_registered_startup_steps();
    }
  }
}