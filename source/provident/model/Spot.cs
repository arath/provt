using System;
using System.Collections.Generic;
using System.Linq;
using provident.utility;

namespace provident.model
{
  public class Spot
  {
    public virtual int id { get; set; }
    public virtual string name { get; set; }
    public virtual bool active { get; set; }
    public virtual Track track { get; set; }

    public void assign_to(Track track)
    {
      this.track = track;
    }
  }

  public class Track
  {
    public virtual int id { get; set; }

    public virtual string name { get; set; }

    IList<Spot> spots { get; set; }

    public Track()
    {
      spots = new List<Spot>();
    }

    public void add(Spot spot)
    {
      spots.Add(spot); 
      spot.assign_to(this);
    }

  }

  public class Car
  {
    public virtual int id { get; private set; }
    public virtual Spot spot { get; private set; }

    public void assign_to(Spot spot)
    {
      this.spot = spot;
    }
  }
}