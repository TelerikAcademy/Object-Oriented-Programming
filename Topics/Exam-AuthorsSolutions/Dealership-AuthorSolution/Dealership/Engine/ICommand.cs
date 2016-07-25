namespace Dealership.Engine
{
    using System.Collections.Generic;

    public interface ICommand
    {
        string Name { get; }

        List<string> Parameters { get; }
    }
}
