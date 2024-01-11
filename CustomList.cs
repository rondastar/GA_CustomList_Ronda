using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_CustomList_Ronda
{
    // <T> makes our class generic
    public class CustomList<T>
    {
        private T[] items;
        private int count;

        // default constructor
        public CustomList() : this(10) { }

        // constructor to specify starting size
        public CustomList(int initialSize)
        {
            items = new T[initialSize];
        }

        // Add inserts items at the end
        public void Add(T item)
        {
            CheckIntegrity(); // ensures there's enough space
            items[count++] = item;
        }

        // AddAtIndex places items at a specified index
        public void AddAtIndex(T item, int index)
        {
            CheckIntegrity(); // ensures there's enough space
            if (index < 0 || index > count) throw new ArgumentOutOfRangeException(nameof(index));
            for (int i = count; i > index; i--)
            {
                items[i] = items[i - 1];
            }
            items[index] = item;
            count++;
        }

        // Remove searches for an item and, if found, shifts subsequent elements forward
        public bool Remove(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(item))
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        items[j] = items[j + 1];
                    }
                    count--;
                    return true;
                }
            }
            return false;
        }

        // CheckIntegrity ensures the array size is sufficient, expanding it when 80% full
        private void CheckIntegrity()
        {
            if (count >= 0.8 * items.Length)
            {
                T[] largerArray = new T[items.Length * 2];
                Array.Copy(items, largerArray, count);
                items = largerArray;
            }
        }

        // GetItem retrieves an item by index, with bounds checking
        public T GetItem(int index)
        {
            if (index < 0 || index >= count) throw new ArgumentOutOfRangeException(nameof(index));
            return items[index];
        }

        // This property provides the current item count
        public int Count => count;



    }
}
