namespace TreehouseDefense
{
  class Map
  {
    // 'public' variables can be accessed by other classes
    // but they cannot be changed after they've been created
    // due to being 'readonly'
    public readonly int Width;
    public readonly int Height;
    
    // constructor method
    public Map(int width, int height)
    {
      Width = width;
      Height = height;
    }
    
    public bool OnMap(Point point)
    {
      return point.x > 0 && point.x < Width && 
             point.y > 0 && point.y < Height;
    }
  }
}
