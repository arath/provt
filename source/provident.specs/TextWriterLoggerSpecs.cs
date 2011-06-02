 using System.IO;
 using System.Text;
 using Machine.Specifications;
 using developwithpassion.specifications.rhinomocks;
 using developwithpassion.specifications.extensions;
 using provident.utility.logging;
 using provident.utility.logging.basic;

namespace provident.specs
{  
  [Subject(typeof(TextWriterLogger))]  
  public class TextWriterLoggerSpecs
  {
    public abstract class concern : Observes<ILogMessages,
                                      TextWriterLogger>
    {
        
    }

   
    public class when_logging_an_informational_message  : concern
    {
      Establish c = () =>
      {
        backing_store = new StringBuilder();
        depends.on<TextWriter>(new StringWriter(backing_store));
      };

      Because b = () =>
        sut.informational("Hello World");

      It should_write_the_message_to_its_backing_text_writer = () =>
        backing_store.ToString().ShouldBeEqualIgnoringCase("Hello World\r\n");

      static StringBuilder backing_store;
        
    }
  }
}
