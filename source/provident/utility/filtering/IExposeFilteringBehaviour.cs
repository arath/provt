namespace provident.utility.filtering
{
  public interface IExposeFilteringBehaviour<TItemToFilter, TPropertyType>
  {
    IMatchAn<TItemToFilter> create_criteria(IMatchAn<TPropertyType> condition);
  }
}