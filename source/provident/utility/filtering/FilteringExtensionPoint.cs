namespace provident.utility.filtering
{
  public class FilteringExtensionPoint<TItemToFilter, TPropertyType> :
    IExposeFilteringBehaviour<TItemToFilter, TPropertyType>
  {
    public PropertyAccessor<TItemToFilter, TPropertyType> accessor { get; private set; }

    public IExposeFilteringBehaviour<TItemToFilter, TPropertyType> not
    {
      get { return this.negate(); }
    }

    public FilteringExtensionPoint(PropertyAccessor<TItemToFilter, TPropertyType> accessor)
    {
      this.accessor = accessor;
    }

    public IMatchAn<TItemToFilter> create_criteria(IMatchAn<TPropertyType> condition)
    {
      return new PropertyCriteria<TItemToFilter, TPropertyType>(accessor, condition);
    }
  }
}