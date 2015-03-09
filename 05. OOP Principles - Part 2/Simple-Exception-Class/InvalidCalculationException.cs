using System;

public class InvalidCalculationException : ApplicationException
{
	public InvalidCalculationException(string msg) : base(msg)
	{
	}

	public InvalidCalculationException(string msg, Exception innerEx)
		: base(msg, innerEx)
	{
	}
}
