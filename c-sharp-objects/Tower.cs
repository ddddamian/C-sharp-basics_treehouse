namespace TreehouseDefense
{
  class Tower
  {
    private readonly MapLocation _location;
    
    public Tower(MapLocation location)
    {
      _location = location;
    }
    
    public void FireOnInvaders(Invader[] invaders)
    {
      
      
      foreach(Invader invader = invaders)
      {
        if(invader.IsActive && _location.InRangeOf(invader.location, 1))
        {
          invader.DecreaseHealth(1);
          break;
        }
        
      }
    }
  }
}
