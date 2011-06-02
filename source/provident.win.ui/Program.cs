using System;
using provident.tasks.startup;

namespace provident.win.ui
{
  static class Program
  {
    [STAThread]
    static void Main()
    {
      StartUp.the_application();
    }
  }
}