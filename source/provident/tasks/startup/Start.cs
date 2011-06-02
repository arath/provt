using System;

namespace provident.tasks.startup
{
  public class Start
  {
    public static StartupPiplineBuilder by<TStartupCommand>()
    {
      throw new NotImplementedException();
    }
  }

  public class StartupPiplineBuilder
  {
    public StartupPiplineBuilder followed_by<TStartupCommand>()
    {
      throw new NotImplementedException();
    }

    public void end_with<TStartupCommand>()
    {
      throw new NotImplementedException();
    }
  }
}