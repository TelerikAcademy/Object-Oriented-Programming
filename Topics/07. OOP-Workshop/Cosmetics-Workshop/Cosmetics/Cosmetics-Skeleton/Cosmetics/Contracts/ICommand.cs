namespace Cosmetics.Contracts
{
    using System.Collections.Generic;

    interface ICommand
    {
        string Name { get; }

        IList<string> Parameters { get; }
    }
}
