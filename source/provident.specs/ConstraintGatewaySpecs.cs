using developwithpassion.specifications.rhinomocks;
using Machine.Specifications;
using provident.utility.contracts;
using developwithpassion.specifications.extensions;

namespace provident.specs
{
  [Subject(typeof(ConstraintGateway))]
  public class ConstraintGatewaySpecs
  {
    public abstract class concern : Observes<IVerifyContracts,ConstraintGateway>
    {
    }

    public class when_verifying_that_all_integers_are_positive : concern
    {
      public class and_all_of_them_are : when_verifying_that_all_integers_are_positive
      {
        Because b = () =>
          sut.all_are_positive(1, 2, 3, 4);

        It should_not_throw_a_contract_violation_exception = () =>
        {
        };
      }

      public class and_they_are_not_all_positive : when_verifying_that_all_integers_are_positive
      {
        Because b = () =>
          spec.catch_exception(() => sut.all_are_positive(1, 2, -3, 4));

        It should_throw_a_contract_violation_exception = () =>
          spec.exception_thrown.ShouldBeAn<ContractViolationException>()
            .Message.ShouldNotBeEmpty();
      }
    }
  }
}