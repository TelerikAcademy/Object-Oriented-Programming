using System;
using System.Collections;

// A class that works just like ArrayList, but sends event
// notifications whenever the list changes.
public class ListWithChangedEvent : ArrayList
{
    // An event that clients can use to be notified whenever the
    // elements of the list change.
    public event ChangedEventHandler Changed;

    // Override some of the methods that can change the list;
    // invoke event after each
    public override int Add(object value)
    {
        int i = base.Add(value);
        this.OnChanged(EventArgs.Empty);
        return i;
    }

    public override void Clear()
    {
        base.Clear();
        this.OnChanged(EventArgs.Empty);
    }

    public override object this[int index]
    {
        set
        {
            base[index] = value;
            this.OnChanged(EventArgs.Empty);
        }
    }

    // Invoke the Changed event; called whenever list changes
    protected virtual void OnChanged(EventArgs e)
    {
        if (this.Changed != null)
        {
            this.Changed(this, e);
        }
    }
}