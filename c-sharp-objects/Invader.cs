namespace TreehouseDefense
{
  class Invader
  {
    private MapLocation _location;
    
    // method to get location
    public MapLocation GetLocation()
    {
      return _location;
    }
    //method to set location
    public void SetLocation(MapLocation value)
    {
      _location = value;
    }
  }
}
