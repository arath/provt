using System;

namespace provident.tasks.startup
{

  [AttributeUsage(AttributeTargets.Class,AllowMultiple = false)]
  public class RegisterAsTransient : Attribute
  {
    
  }

  [AttributeUsage(AttributeTargets.Class,AllowMultiple = false)]
  public class RegisterAsSingleton : Attribute
  {
    
  }
}