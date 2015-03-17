using System;

namespace MyCollections
{
    using System.Collections;

    // A delegate type for hooking up change notifications.
    public delegate void ChangedEventHandler(object sender, EventArgs e);

    // A class that works just like ArrayList, but sends event
    // notifications whenever the list changes.
    public class ListWithChangedEvent : ArrayList
    {
        // An event that clients can use to be notified whenever the
        // elements of the list change.
        public event ChangedEventHandler Changed;

        // Invoke the Changed event; called whenever list changes
        protected virtual void OnChanged(EventArgs e)
        {
            if (this.Changed != null)
            {
                this.Changed(this, e);
            }
        }

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
    }
}

namespace TestEvents
{
    using MyCollections;

    class EventListener
    {
        private ListWithChangedEvent List;

        public EventListener(ListWithChangedEvent list)
        {
            this.List = list;
            // Add "ListChanged" to the Changed event on "List".
            this.List.Changed += new ChangedEventHandler(ListChanged);
        }

        // This will be called whenever the list changes.
        private void ListChanged(object sender, EventArgs e)
        {
            Console.WriteLine("This is called when the event fires.");
        }

        public void Detach()
        {
            // Detach the event and delete the list
            this.List.Changed -= new ChangedEventHandler(ListChanged);
            this.List = null;
        }
    }

    class Test
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

        static void list_Changed(object sender, EventArgs e)
        {
            Console.WriteLine("List was changed");
        }
    }
}