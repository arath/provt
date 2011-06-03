using System.Collections.Generic;
using provident.tasks.startup.steps;
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

    public static void by_running_all_registered_startup_steps()
    {
      new ConfigureNinject().run();
      Container.resolve.all<IRunAStartupStep>().for_each(x => x.run());

      Container.resolve.an<IAmTheFinalStepInStartup>().run();
      Container.resolve.an<ConfigureSomeTracks>().run();
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