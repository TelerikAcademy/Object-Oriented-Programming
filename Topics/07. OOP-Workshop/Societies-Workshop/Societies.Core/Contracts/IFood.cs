namespace Societies.Core.Contracts
{
    using Infrastructure.Enumerations.Common;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IFood : IConsumable
    {
        int PortionSizeInGrams { get; set; }

        FoodType Type { get; }
    }
}
