namespace Societies.Core.Models.Common.Abstract
{
    using Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Infrastructure.Enumerations.Common;
    using Infrastructure.Exceptions;

    public abstract class Consumable : IConsumable
    {
        private decimal totalPrice;

        public decimal TotalPrice
        {
            get
            {
                return this.totalPrice;
            }
            set
            {
                if(value < 0)
                {
                    throw new PriceOutOfRangeException(
                        "Price was not in the desired range[0:infinity]", 
                        value);
                }
                else if(value > decimal.MaxValue)
                {
                    throw new PriceOutOfRangeException(
                        "Price was not in the desired range[0:infinity]",
                        value);
                }

                this.totalPrice = value;
            }
        }
    }
}