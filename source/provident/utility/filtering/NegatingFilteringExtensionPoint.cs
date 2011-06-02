namespace provident.utility.filtering
{
  public class NegatingFilteringExtensionPoint<TItemToFilter, TPropertyType> :
    IExposeFilteringBehaviour<TItemToFilter, TPropertyType>
  {
    IExposeFilteringBehaviour<TItemToFilter, TPropertyType> original;

    public NegatingFilteringExtensionPoint(IExposeFilteringBehaviour<TItemToFilter, TPropertyType> original)
    {
      this.original = original;
    }

    public IMatchAn<TItemToFilter> create_criteria(IMatchAn<TPropertyType> condition)
    {
      return original.create_criteria(condition).not();
    }
  }
}