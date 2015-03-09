using System;
using System.IO;

class SumOfLines
{
    static long CalculateSumOfLines(string fileName)
    {
        StreamReader inFile;
        try
        {
            inFile = File.OpenText(fileName);
        }
        catch (IOException ioe)
        {
            string message = String.Format("Can not open the file {0} for reading.", fileName);
            throw new ParseFileException(message, fileName, ioe);
        }
        using (inFile)
        {
            long sum = 0;
            long lineNumber = 0;
            while (true)
            {				
                lineNumber++;
                string line;
                try
                {
                    line = inFile.ReadLine();
                }
                catch (IOException ioe)
                {
                    throw new ParseFileException("Error reading from file.",
                        fileName, lineNumber, ioe);
                }
                if (line == null)
                {
                    break;  // end of file reached
                }
                try
                {
                    sum += Int32.Parse(line);
                }			
                catch (SystemException se)
                {
                    string message = String.Format("Error parsing line '{0}'.", line);
                    throw new ParseFileException(message, fileName, lineNumber, se);
                }
            }
            return sum;
        }
    }

    static void Main()
    {
        long sumOfLines = CalculateSumOfLines(@"..\..\test.txt");
        Console.WriteLine("The sum of lines={0}", sumOfLines);
    }
}
