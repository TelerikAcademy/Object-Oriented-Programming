namespace Dealership.Contracts
{
    public interface IComment
    {
        string Content { get; }

        string Author { get; set; }
    }
}
