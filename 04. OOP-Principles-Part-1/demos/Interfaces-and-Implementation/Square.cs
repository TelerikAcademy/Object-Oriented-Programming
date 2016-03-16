public class Square : IShape
{
    private int x, y, size;

    public Square(int x, int y, int size)
    {
        this.x = x;
        this.y = y;
        this.size = size;
    }

    // Derived from IShape
    public void SetPosition(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    // Derived from IShape  
    public double CalculateSurface()
    {
        return size * size;
    }
}
