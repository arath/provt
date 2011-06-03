using Ninject;

namespace provident.utility.containers.ninject
{
  public interface IConfigureANinjectKernel
  {
    void configure(IKernel kernel);
  }
}