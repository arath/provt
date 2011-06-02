using System;

namespace provident.utility.contracts
{
  public class ContractViolationException : Exception
  {
    public ContractViolationException(string message):base(message)
    {
        
    }
  }
}