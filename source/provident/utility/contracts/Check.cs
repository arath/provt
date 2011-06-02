using provident.utility.containers;

namespace provident.utility.contracts
{
  public class Check
  {
    public static IVerifyContracts that
    {
      get { return Container.resolve.an<IVerifyContracts>(); }
    }
  }
}