using System.Collections.Generic;
using System.Linq;
using developwithpassion.specifications.rhinomocks;
using Machine.Specifications;
using provident.utility;

namespace provident.specs
{
  [Subject(typeof(EnumerableExtensions))]
  public class EnumerableExtensionsSpecs
  {
    public abstract class concern : Observes
    {
    }

    public class when_running_an_action_against_each_item_in_a_set : concern
    {
      Establish c = () =>
      {
        items = Enumerable.Range(1, 100);
      };

      Because b = () =>
        items.for_each(item => number_of_items_visited++);

      It should_have_triggered_the_action_with_each_item = () =>
        number_of_items_visited.ShouldEqual(100);

      static int number_of_items_visited;
      static IEnumerable<int> items;
    }
  }
}