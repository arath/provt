using System.Windows.Forms;
using provident.utility.logging;

namespace provident.win.ui
{
  public partial class Shell : Form
  {
    public Shell()
    {
      InitializeComponent();
      Log.an.informational("Hello");
    }
  }
}