using System;

public class ParseFileException : ApplicationException
{
    private readonly string fileName;

    private readonly long? lineNumber;
    
    public ParseFileException(string message, string fileName, long? lineNumber, Exception causeException)
        : base(message, causeException)
    {
        this.fileName = fileName;
        this.lineNumber = lineNumber;
    }

    public ParseFileException(string message, string fileName, Exception causeException)
        : this(message, fileName, null, causeException)
    {
    }

    public string FileName
    {
        get
        {
            return this.fileName;
        }
    }

    public long? LineNumber
    {
        get
        {
            return this.lineNumber;
        }
    }

    public override string Message
    {
        get
        {
            if (this.lineNumber != null)
            {
                string result = string.Format(
                    "{0} (file: {1}, line:{2})", 
                    base.Message, 
                    this.fileName, 
                    this.lineNumber);
                return result;
            }
            else
            {
                string result = string.Format("{0} (file: {1})", base.Message, this.fileName);
                return result;
            }
        }
    }
}
