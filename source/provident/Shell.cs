using System;
using System.Windows.Forms;

namespace provident
{
  public partial class Shell : Form
  {
    IGreetTheUser greeter;
    ITweakUI ui_tweaker;

    public Shell()
    {
      InitializeComponent();
    }

    public Shell(IGreetTheUser greeter,ITweakUI ui_tweaker) : this()
    {
      this.greeter = greeter;
      this.ui_tweaker = ui_tweaker;
      this.Activated += new EventHandler(run_the_greeters());
    }

    EventHandler run_the_greeters()
    {
      throw new NotImplementedException();
    }
  }
}