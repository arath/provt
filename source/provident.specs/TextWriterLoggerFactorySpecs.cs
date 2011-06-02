 using System.IO;
 using Machine.Specifications;
 using developwithpassion.specifications.rhinomocks;
 using developwithpassion.specifications.extensions;
 using provident.utility.logging;
 using provident.utility.logging.basic;

namespace provident.specs
{  
  [Subject(typeof(TextWriterLoggerFactory))]  
  public class TextWriterLoggerFactorySpecs
  {
    public abstract class concern : Observes<ICreateLoggers,
                                      TextWriterLoggerFactory>
    {
        
    }

   
    public class when_creating_a_logger_bound_to_a_calling_type : concern
    {
      Establish c = () =>
      {
        the_writer = new StringWriter();
        depends.on<TextWriterLoggingWriterProvider>(() => the_writer);
      };

      Because b = () =>
        result = sut.create_logger_bound_to(typeof(int));


      It should_create_a_logger_with_the_correct_information = () =>
        result.ShouldBeAn<TextWriterLogger>()
          .writer.ShouldEqual(the_writer);

      static ILogMessages result;
      static TextWriter the_writer;
    }
  }
}
