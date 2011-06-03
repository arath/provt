using System;
using System.Collections.Generic;
using provident.utility;
using provident.utility.containers;

namespace provident.tasks.startup
{
  public class Start
  {
    public static StartupPiplineBuilder by<TStartupCommand>() where TStartupCommand : IRunAStartupStep
    {
      return new StartupPiplineBuilder(Container.resolve.an<TStartupCommand>(),
                                       Container.resolve);
    }
  }

  public class StartupPiplineBuilder
  {
    IList<IRunAStartupStep> steps;
    IResolveDependencies container;

    public StartupPiplineBuilder(IRunAStartupStep startup_command, IResolveDependencies container)
    {
      steps = new List<IRunAStartupStep>();
      this.container = container;
    }

    public StartupPiplineBuilder followed_by<TStartupCommand>() where TStartupCommand : IRunAStartupStep
    {
      return chain<TStartupCommand>();
    }

    public void end_with<TStartupCommand>() where TStartupCommand : IRunAStartupStep
    {
      chain<TStartupCommand>();
      steps.for_each(x => x.run());
    }

    StartupPiplineBuilder chain<NextCommand>() where NextCommand : IRunAStartupStep
    {
      steps.Add(container.an<NextCommand>());
      return this;
    }
  }
}