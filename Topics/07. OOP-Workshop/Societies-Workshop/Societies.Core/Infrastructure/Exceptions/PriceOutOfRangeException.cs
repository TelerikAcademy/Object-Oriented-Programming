namespace Societies.Core.Infrastructure.Exceptions
{
    using System;

    public class PriceOutOfRangeException : ArgumentOutOfRangeException
    {
        public PriceOutOfRangeException(string message, decimal priceValue)
            : base(message)
        {
            this.PriceValue = priceValue;
        }

        public decimal PriceValue { get; set; }
    }
}