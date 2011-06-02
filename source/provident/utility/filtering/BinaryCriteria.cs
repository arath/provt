namespace provident.utility.filtering
{
  public abstract class BinaryCriteria<ItemToMatch> : IMatchAn<ItemToMatch>
  {
    protected IMatchAn<ItemToMatch> left_side;
    protected IMatchAn<ItemToMatch> right_side;

    protected BinaryCriteria(IMatchAn<ItemToMatch> left_side, IMatchAn<ItemToMatch> right_side)
    {
      this.left_side = left_side;
      this.right_side = right_side;
    }

    public abstract bool matches(ItemToMatch item);
  }
}