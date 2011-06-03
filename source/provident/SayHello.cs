using System.Windows.Forms;

namespace provident
{
  public class SayHello : IGreetTheUser
  {
    public void run()
    {
      Form.ActiveForm.Text = "Hello";
    }
  }

  public class RepetitiveGreeter : IGreetTheUser
  {
    IGreetTheUser original;

    public RepetitiveGreeter(IGreetTheUser original)
    {
      this.original = original;
    }

    public void run()
    {
      original.run();
      Form.ActiveForm.Text += "Again";
    }
  }
}