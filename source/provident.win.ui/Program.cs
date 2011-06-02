using System;
using System.Windows.Forms;

namespace provident.win.ui
{
  static class Program
  {
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(true);
      Application.Run(new Shell());
    }
  }
}