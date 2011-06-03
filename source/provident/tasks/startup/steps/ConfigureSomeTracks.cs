using provident.model;
using provident.Mapping;



namespace provident.tasks.startup.steps
{
  public class ConfigureSomeTracks
  {
    public void run()
    {


      var sessionFactory = NHibernateSessionFactory.create_session_factory();
      
      using (var session = sessionFactory.OpenSession())
      {
        using (var transaction = session.BeginTransaction())
        {

          var track = new Track();
          track.name = "The first track";
          var first_spot = new Spot {active = true, name = "The first spot"};
          track.add(first_spot);

          var car = new Car();
          car.assign_to(first_spot);

          session.SaveOrUpdate(track);
          session.SaveOrUpdate(car);

          transaction.Commit();
        }
      }
    }

    public void save<TEntity>(TEntity item)
    {
  
    }
  }
}