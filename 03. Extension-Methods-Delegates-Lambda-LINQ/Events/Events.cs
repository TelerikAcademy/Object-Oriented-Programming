using System;

public class Program
{
    // Test the ListWithChangedEvent class.
    public static void Main()
    {
        // Create a new list.
        ListWithChangedEvent list = new ListWithChangedEvent();

        // Create a class that listens to the list's change event.
        EventListener listener = new EventListener(list);

        // Add and remove items from the list.
        list.Add("item 1");
        list.Clear();

        // Alternatives to subscribing to an event
        //list.Changed += list_Changed;
        //list.Add("item 2");

        //list.Changed += (sender, e) =>
        //{
        //    Console.WriteLine("This is also valid and is fired when the list is changed.");
        //};
        //list.Add("item 3");

        listener.Detach();
        list.Add("item 4");
    }

    private static void list_Changed(object sender, EventArgs e)
    {
        Console.WriteLine("List was changed");
    }
}