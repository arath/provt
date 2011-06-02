using System;
using provident.utility.ranges;

namespace provident.utility.filtering
{
  public static class FilteringExtensions
  {
    public static IMatchAn<TItemToMatch> equal_to<TItemToMatch,TPropertyType>(this IExposeFilteringBehaviour<TItemToMatch,TPropertyType> extension_point,TPropertyType value)
    {
      return extension_point.equal_to_any(value);
    }

    public static IExposeFilteringBehaviour<TItemToMatch, TPropertyType> negate<TItemToMatch, TPropertyType>(
      this FilteringExtensionPoint<TItemToMatch, TPropertyType> extension_point)
    {
      return new NegatingFilteringExtensionPoint<TItemToMatch, TPropertyType>(extension_point); 
    }

    public static IMatchAn<TItemToMatch> equal_to_any<TItemToMatch,TPropertyType>(this IExposeFilteringBehaviour<TItemToMatch,TPropertyType> extension_point,params TPropertyType[] potential_values)
    {
      return extension_point.create_criteria_using(new IsEqualToAny<TPropertyType>(potential_values));
    }

    public static IMatchAn<TItemToMatch> between<TItemToMatch,TPropertyType>(this IExposeFilteringBehaviour<TItemToMatch,TPropertyType> extension_point,TPropertyType start, TPropertyType end) where TPropertyType : IComparable<TPropertyType>
    {
      return extension_point.create_criteria_using(new InclusiveRange<TPropertyType>(start, end).as_specification());
    }

    public static IMatchAn<TItemToMatch> greater_than<TItemToMatch,TPropertyType>(this IExposeFilteringBehaviour<TItemToMatch,TPropertyType> extension_point,TPropertyType value) where TPropertyType : IComparable<TPropertyType>
    {
      return extension_point.create_criteria_using(new ExclusiveRangeWithNoUpperBound<TPropertyType>(value).as_specification());
    }

    internal static IMatchAn<TItemToMatch> create_criteria_using<TItemToMatch,TPropertyType>(this IExposeFilteringBehaviour<TItemToMatch,TPropertyType> extension_point,IMatchAn<TPropertyType> condition)
    {
      return extension_point.create_criteria(condition);
    }
  }
}