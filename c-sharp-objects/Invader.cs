namespace TreehouseDefense
{
  class Invader
  {
    private MapLocation _location;
    
    public MapLocation Location
    {
      // method to get location
      get
      {
        return _location;
      }
      //method to set location
      set
      {
        _location = value;
      }
    }
  }
}
