namespace provident.utility.filtering
{
  public delegate TPropertyType PropertyAccessor<in TItemToTarget, out TPropertyType>(TItemToTarget item);
}