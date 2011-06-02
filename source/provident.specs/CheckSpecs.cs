using developwithpassion.specifications.rhinomocks;
using Machine.Specifications;
using provident.specs.utility;
using provident.utility.contracts;

namespace provident.specs
{
  [Subject(typeof(Check))]
  public class CheckSpecs
  {
    public abstract class concern : Observes
    {
    }

    public class when_providing_access_to_the_contraint_checking_mechanism : concern
    {
      Establish c = () =>
      {
        the_constraint_gateway = fake.an<IVerifyContracts>();

        Scaffold.container_returned(the_constraint_gateway,pipeline, fake);
      };

      Because b = () =>
        result = Check.that;

      It should_return_access_to_the_underlying_constraint_gateway = () =>
        result.ShouldEqual(the_constraint_gateway);

      static IVerifyContracts result;
      static IVerifyContracts the_constraint_gateway;
    }
  }
}