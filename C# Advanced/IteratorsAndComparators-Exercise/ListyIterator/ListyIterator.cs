using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> items;
        int index;
        public ListyIterator(List<T> items)
        {
            this.items = items;
        }
        public ListyIterator(params T[] items)
        {
            this.items = items.ToList();
        }
        public bool Move()
        {
            if (index+1<items.Count)
            {
            index++;
                return true;
            }
            return false;
        }
        public bool HasNext()
        {
            return index < items.Count-1;
        } 
        public void Print()
        {
            if (items.Count==0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            Console.WriteLine(items[index]);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < items.Count; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
