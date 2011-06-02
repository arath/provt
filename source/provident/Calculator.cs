using System;

namespace provident
{
  public class Calculator
  {
    public int add(int first_number, int second_number)
    {
      if (first_number < 0 || second_number < 0)
        throw new ArgumentException();

      return first_number + second_number;
    }
  }
}