using System;
using System.Windows.Forms;
using provident.utility.logging;
using provident.utility.logging.basic;

namespace provident.win.ui
{
  static class Program
  {
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(true);
      Log.logger_factory_resolver = () => new TextWriterLoggerFactory(() => Console.Out);
      Application.Run(new Shell());
    }
  }
}