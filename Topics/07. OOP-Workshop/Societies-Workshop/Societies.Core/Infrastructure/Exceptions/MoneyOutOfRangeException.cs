namespace Societies.Core.Infrastructure.Exceptions
{
    using System;

    public class MoneyOutOfRangeException : ArgumentOutOfRangeException
    {
        public MoneyOutOfRangeException(string message, decimal moneyAmount)
            : base(message)
        {
            this.MoneyAmount = moneyAmount;
        }

        public decimal MoneyAmount { get; set; }
    }
}