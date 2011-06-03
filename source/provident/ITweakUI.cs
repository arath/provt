using System.Drawing;
using System.Windows.Forms;

namespace provident
{
  public interface ITweakUI
  {
    void visit(Control form);
  }

  public class AppendMainMenu : ITweakUI
  {
    public void visit(Control form)
    {
    }
  }

  public class AlterColors : ITweakUI
  {
    public void visit(Control form)
    {
      form.BackColor = Color.Yellow;
    }
  }
}