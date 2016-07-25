using System.Collections.Generic;

namespace Dealership.Contracts
{
    public interface ICommentable
    {
        IList<IComment> Comments { get; }
    }
}
