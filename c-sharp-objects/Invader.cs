namespace TreehouseDefense
{
  class Invader
  { 
    private readonly Path _path;
    private int _pathStep = 0;
    
    public MapLocation Location => _path.GetLocationAt(_pathStep);
    
    public int Health { get; private set; } = 2;
    
    // true if the invader has reached the end of the path
    public bool HasScored { get { return _pathStep >= _path.Length; } }
    
    // true if the invader's health is 0 or less.
    //public bool IsNeutralized { get { return Health <= 0; } }
    public bool IsNeutralized => Health <= 0;
    
    public bool IsActive => !(IsNeutralized || HasScored);
    
    public Invader(Path path)
    {
      _path = path;
    }
    
    public void Move() => _pathStep += 1; 
    
    public void DecreaseHealth(int factor)
    {
      Health -= factor; 
    }
  }
}
