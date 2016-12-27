using System;
using System.Text;

namespace CustomDataStructures
{
    // implement indexing, addition, removal, indexOf, removeAt, operators
    public class GenericList<T>
        where T : IComparable<T>
    {
        private const int InitialCapacity = 4;

        public static int CompareLex(GenericList<T> first, GenericList<T> second)
        {
            if(ReferenceEquals(first, second))
            {
                return 0;
            }

            var length = Math.Min(first.Count, second.Count);

            for (var i = 0; i < length; i++)
            {
                if(first[i].CompareTo(second[i]) != 0)
                {
                    return first[i].CompareTo(second[i]);
                }
            }

            if(first.Count > second.Count)
            {
                return 1;
            }
            else if(second.Count > first.Count)
            {
                return -1;
            }

            return 0;
        }

        private T[] elements;

        public int Capacity
        {
            get
            {
                return elements.Length;
            }
        }

        public int Count { get; private set; }

        public T this[int index]
        {
            get
            {
                return this.elements[index];
            }

            set
            {
                this.elements[index] = value;
            }
        }

        public GenericList(int capacity)
        {
            this.Count = 0;
            var powerOfTwo = this.NearestPowerOf2(capacity);

            this.elements = new T[powerOfTwo];
        }

        public GenericList()
        {
            this.Count = 0;
            this.elements = new T[InitialCapacity];
        }

        public void Add(T item)
        {
            if(this.Count == this.Capacity)
            {
                this.Expand();
            }

            elements[this.Count++] = item;
        }

        public void RemoveFirst(T item)
        {
            int index = -1;

            for(var i = 0; i < this.Count; i++)
            {
                if(this.elements[i].Equals(item))
                {
                    index = i;
                    break;
                }
            }

            this.RemoveAt(index);
        }

        public void RemoveAt(int index)
        {
            for (var i = index; i < this.Count - 1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }

            this.elements[this.Count - 1] = default(T);

            this.Count--;
        }

        public static GenericList<T> operator+ (GenericList<T> list, T[] items)
        {
            foreach (var itemToAdd in items)
            {
                list.Add(itemToAdd);
            }

            return list;
        }

        public static GenericList<T> operator+ (GenericList<T> list, T item)
        {
            list.Add(item);
            return list;
        }

        public static GenericList<T> operator- (GenericList<T> list, T itemToRemove)
        {
            list.RemoveFirst(itemToRemove);
            return list;
        }

        public static GenericList<T> operator-- (GenericList<T> list)
        {
            list.RemoveAt(list.Count - 1);
            return list;
        }

        public static implicit operator bool (GenericList<T> list)
        {
            return list != null && list.Count > 0;
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            for (var i = 0; i < this.Count; i++)
            {
                result.Append(this.elements[i]);

                if(i != this.Count - 1)
                {
                    result.Append(" -> ");
                }
            }

            return result.ToString();
        }

        private void Expand()
        {
            var newElements = new T[2 * this.Capacity];

            for(var i = 0; i < this.Count; i++)
            {
                newElements[i] = this.elements[i];
            }

            this.elements = newElements;
        }

        private int NearestPowerOf2(int n)
        {
            var pow = 0;

            while (n > 0)
            {
                n >>= 1;
                pow++;
            }

            return 1 << pow;
        }
    }
}
