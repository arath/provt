namespace provident.utility.filtering
{
  public class PropertyCriteria<TItemToMatch, TPropertyType> : IMatchAn<TItemToMatch>
  {
    PropertyAccessor<TItemToMatch, TPropertyType> accessor;
    IMatchAn<TPropertyType> value_criteria;

    public PropertyCriteria(PropertyAccessor<TItemToMatch, TPropertyType> accessor, IMatchAn<TPropertyType> value_criteria)
    {
      this.accessor = accessor;
      this.value_criteria = value_criteria;
    }
    public bool matches(TItemToMatch item)
    {
      return value_criteria.matches(accessor(item));
    }
  }
}