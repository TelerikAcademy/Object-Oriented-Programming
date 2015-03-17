using System;

internal class EventListener
{
    private ListWithChangedEvent List;

    public EventListener(ListWithChangedEvent list)
    {
        this.List = list;
        // Add "ListChanged" to the Changed event on "List".
        this.List.Changed += new ChangedEventHandler(this.ListChanged);
    }

    // This will be called whenever the list changes.
    private void ListChanged(object sender, EventArgs e)
    {
        Console.WriteLine("This is called when the event fires.");
    }

    public void Detach()
    {
        // Detach the event and delete the list
        this.List.Changed -= new ChangedEventHandler(this.ListChanged);
        this.List = null;
    }
}