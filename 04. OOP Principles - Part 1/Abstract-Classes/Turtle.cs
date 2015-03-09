public class Turtle : Animal
{
    public override int Speed
    {
        get
        {
            return 1;
        }
    }

    public override string GetName()
    {
        return "turtle";
    }
}
