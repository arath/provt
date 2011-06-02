using provident.utility.contracts;

namespace provident
{
  public class Calculator
  {
    public int add(int first_number, int second_number)
    {
      Check.true_for_all(x => x >0,first_number, second_number);
      Check.ensure_not_null(value,"The connection should be valid");

      return first_number + second_number;
    }
  }
}