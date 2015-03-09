using System;

public class ParseFileException : ApplicationException
{
    private string fileName;
    private long? lineNumber;

    public string FileName
    {
        get
        {
            return fileName;
        }
    }

    public long? LineNumber
    {
        get
        {
            return lineNumber;
        }
    }

    public ParseFileException(string message, string fileName, 
        long? lineNumber, Exception causeException)
        : base(message, causeException)
    {
        this.fileName = fileName;
        this.lineNumber = lineNumber;
    }

    public ParseFileException(string message, string fileName, 
        Exception causeException)
        : this(message, fileName, null, causeException)
    {
    }

    public ParseFileException(string message, string fileName)
        : this(message, fileName, null)
    {
    }

    public override string Message
    {
        get
        {
            if (lineNumber != null)
            {
                string result = string.Format("{0} (file: {1}, line:{2})",
                    base.Message, this.fileName, this.lineNumber);
                return result;
            }
            else
            {
                string result = string.Format("{0} (file: {1})",
                   base.Message, this.fileName);
                return result;
            }
        }
    }
}
