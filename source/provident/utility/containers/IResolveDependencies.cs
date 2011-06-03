using System.Collections.Generic;

namespace provident.utility.containers
{
  public interface IResolveDependencies
  {
    TDependency an<TDependency>();
    IEnumerable<TDependency> all<TDependency>();
  }
}