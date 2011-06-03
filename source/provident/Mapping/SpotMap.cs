using FluentNHibernate.Cfg;
using FluentNHibernate.Mapping;
using NHibernate;
using provident.model;

namespace provident.Mapping
{
  
  public class NHibernateSessionFactory
  {
    public static ISessionFactory create_session_factory()
    {
      return Fluently.Configure().BuildSessionFactory();
    }
  }


  public class SpotMap : ClassMap<Spot>
  {
    public SpotMap()
    {
      Id(x => x.id);
      Map(x => x.name);
      Map(x => x.active);
      Map(x => x.track);
    }
  }

  public class TrackMap : ClassMap<Track>
  {
    public TrackMap()
    {
      Id(x => x.id);
      Map(x => x.name);
      HasMany(x => x.spots)
        .Inverse()
        .Cascade.All();
    }
  }
  public class CarMap : ClassMap<Car>
  {
    public CarMap()
    {
      Id(x => x.id);
      References(x => x.spot);
    }
  }

}