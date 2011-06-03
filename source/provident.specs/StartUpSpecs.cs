using System.Windows.Forms;
using developwithpassion.specifications.rhinomocks;
using Machine.Specifications;
using provident.tasks.startup;
using provident.tasks.startup.steps;
using provident.ui;
using provident.utility.containers;

namespace provident.specs
{
  [Subject(typeof(StartUp))]
  public class StartUpSpecs
  {
    public abstract class concern : Observes
    {
    }

    public class when_it_has_finished_running : concern
    {
      Establish c = () =>
      {
        var original = UIBehaviours.main_loop;

        ProgramLoop main_loop = form =>
        {
          main_shell = form;
          form.Show();
        };

        spec.change(() => UIBehaviours.main_loop).to(main_loop);
      };

      Because b = () =>
        StartUp.the_application();

      It should_be_running_the_main_shell = () =>
      {
        main_shell.Visible.ShouldBeTrue();
        main_shell.ShouldEqual(Container.resolve.an<Shell>());
      };

      static Form main_shell;
    }
  }
}