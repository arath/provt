using System.IO;

namespace provident.utility.logging.basic
{
  public class TextWriterLogger : ILogMessages
  {
    public TextWriter writer;

    public TextWriterLogger(TextWriter writer)
    {
      this.writer = writer;
    }

    public void informational(string message)
    {
      writer.WriteLine(message);
    }
  }
}