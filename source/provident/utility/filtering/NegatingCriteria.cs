namespace provident.utility.filtering
{
  public class NegatingCriteria<ItemToMatch> : IMatchAn<ItemToMatch>
  {
    IMatchAn<ItemToMatch> to_negate;

    public NegatingCriteria(IMatchAn<ItemToMatch> to_negate)
    {
      this.to_negate = to_negate;
    }

    public bool matches(ItemToMatch item)
    {
      return ! to_negate.matches(item);
    }
  }
}