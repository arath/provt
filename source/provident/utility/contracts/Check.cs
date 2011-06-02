using System;

namespace provident.utility.contracts
{
  public class Check
  {
    public static ConstraintGatewayResolver gateway_resolver = () =>
    {
      throw new NotImplementedException("This needs to be configured at application startup");
    };

    public static IVerifyContracts that
    {
      get { return gateway_resolver();}
    }
  }
}