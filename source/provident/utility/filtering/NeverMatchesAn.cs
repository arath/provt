namespace provident.utility.filtering
{
  public class NeverMatchesAn<TItemToMatch> : IMatchAn<TItemToMatch>
  {
    public bool matches(TItemToMatch item)
    {
      return false;
    }
  }
}