using System;
using System.Runtime.Serialization;

namespace FastAndFurious.ConsoleApplication.Common.Exceptions
{
    public class TunningDuplicationException : ArgumentException
    {
        public TunningDuplicationException()
        {
        }

        public TunningDuplicationException(string message) : base(message)
        {
        }

        public TunningDuplicationException(string message, string paramName) : base(message, paramName)
        {
        }

        public TunningDuplicationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public TunningDuplicationException(string message, string paramName, Exception innerException) : base(message, paramName, innerException)
        {
        }

        protected TunningDuplicationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
