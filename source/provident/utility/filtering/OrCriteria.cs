namespace provident.utility.filtering
{
  public class OrCriteria<ItemToMatch> : BinaryCriteria<ItemToMatch>
  {
    public OrCriteria(IMatchAn<ItemToMatch> left_side, IMatchAn<ItemToMatch> right_side) : base(left_side, right_side)
    {
    }

    public override bool matches(ItemToMatch item)
    {
      return left_side.matches(item) || right_side.matches(item);
    }
  }
}