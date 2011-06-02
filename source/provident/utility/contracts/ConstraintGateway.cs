using System.Linq;

namespace provident.utility.contracts
{
  public class ConstraintGateway : IVerifyContracts
  {
    public void all_are_positive(params int[] values)
    {
      if (values.All(x => x > 0)) return;
      throw new ContractViolationException("All of the values are not positive");
    }
  }
}