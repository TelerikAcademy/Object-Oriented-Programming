using System;
using System.Collections;

// A delegate type for hooking up change notifications.
public delegate void ChangedEventHandler(object sender, EventArgs e);

// A class that works just like ArrayList, but sends event
// notifications whenever the list changes.
public class ListWithChangedEvent : ArrayList
{
    // An event that clients can use to be notified whenever the
    // elements of the list change.
    public event ChangedEventHandler Changed; // EventHandler

    // Override some of the methods that can change the list;
    // invoke event after each
    public override int Add(object value)
    {
        int i = base.Add(value);
        this.OnChanged();
        return i;
    }

    public override void Clear()
    {
        base.Clear();
        this.OnChanged();
    }

    public override object this[int index]
    {
        set
        {
            base[index] = value;
            this.OnChanged();
        }
    }

    // Invoke the Changed event; called whenever list changes
    private void OnChanged()
    {
        if (this.Changed != null)
        {
            this.Changed(this, EventArgs.Empty);
        }
    }
}
