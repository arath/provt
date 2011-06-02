using System;

namespace provident.utility.container
{
  public class Container
  {
    public static ContainerResolver container_resolver = () =>
    {
      throw new NotImplementedException("This needs to be configured at startup");
    };

    public static IResolveDependencies resolve
    {
      get { throw new NotImplementedException(); }
    }
  }
}