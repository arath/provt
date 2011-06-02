namespace provident.utility.filtering
{
  public class Where<TItemToMatch>
  {
    public static FilteringExtensionPoint<TItemToMatch, TPropertyType> has_a<TPropertyType>(
      PropertyAccessor<TItemToMatch, TPropertyType> accessor)
    {
      return new FilteringExtensionPoint<TItemToMatch, TPropertyType>(accessor);      
    }
  }
}