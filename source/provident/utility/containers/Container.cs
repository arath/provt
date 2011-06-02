using System;

namespace provident.utility.containers
{
  public class Container
  {
    public static ContainerResolver container_resolver = () =>
    {
      throw new NotImplementedException("This needs to be configured at startup");
    };

    public static IResolveDependencies resolve
    {
      get { return container_resolver();}
    }
  }
}