using System;

// Reference type
class RefClass
{
    private int value;

    public int Value
    {
        get { return this.value; }
        set { this.value = value; }
    }
}

// Value type
struct ValStruct
{
    private int value;

    public int Value
    {
        get { return this.value; }
        set { this.value = value; }
    }
}

class ValueAndReferenceTypes
{
    static void Main(string[] args)
    {
        RefClass refExample = new RefClass();
        refExample.Value = 100;
        RefClass refExample2 = refExample;
        refExample2.Value = 200;
        Console.WriteLine(refExample.Value); // Prints 200

        ValStruct valExample = new ValStruct();
        valExample.Value = 100;
        ValStruct valExample2 = valExample;
        valExample2.Value = 200;
        Console.WriteLine(valExample.Value); // Prints 100
    }
}
