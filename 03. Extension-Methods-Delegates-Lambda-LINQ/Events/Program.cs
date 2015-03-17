using System;

public class Program
{
    // Test the ListWithChangedEvent class.
    public static void Main()
    {
        // Create a new list.
        ListWithChangedEvent list = new ListWithChangedEvent();

        // Add and remove items from the list.
        Console.WriteLine("----- Adding item 1");
        list.Add("item 1");
        list.Clear();

        // Attach method as a listener
        // list.Changed += new ChangedEventHandler(ListOnChanged);
        list.Changed += ListOnChanged;

        // Attach delegate as a listener
        list.Changed += delegate(object sender, EventArgs args)
            {
                Console.WriteLine("degate(object sender, EventArgs args)");
            };

        // Attach anonymous type as a listener
        list.Changed += (sender, args) => Console.WriteLine("(sender, args) =>");

        Console.WriteLine("----- Adding item 2");
        list.Add("item 2");

        list.Changed -= ListOnChanged;

        Console.WriteLine("----- Adding item 3");
        list.Add("item 3");
    }

    private static void ListOnChanged(object sender, EventArgs eventArgs)
    {
        Console.WriteLine("ListOnChanged(object sender, EventArgs eventArgs)");
    }
}