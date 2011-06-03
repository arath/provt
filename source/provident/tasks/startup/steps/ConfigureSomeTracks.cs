using provident.model;

namespace provident.tasks.startup.steps
{
  public class ConfigureSomeTracks
  {
    public void run()
    {
      var track = new Track();
      track.name = "The first track";
      var first_spot = new Spot {active = true, name = "The first spot"};
      track.add(first_spot);

      var car = new Car();
      car.assign_to(first_spot);

      save(track);
      save(car);
    }

    public void save<TEntity>(TEntity item)
    {
    }
  }
}