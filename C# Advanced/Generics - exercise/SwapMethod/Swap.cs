using System;
using System.Collections.Generic;
using System.Text;

namespace SwapMethod
{
    public class Swap<T>
    {
        public Swap()
        {
            Items = new List<T>();
        }
        public List<T> Items { get; set; }

        public void SwapIndexes(int index1,int index2)
        {
            
            if (index1>=0 && index1<Items.Count
                && index2 >= 0 && index2 < Items.Count)
            {
                T swap=Items[index1];
                Items[index1] = Items[index2];
                Items[index2] = swap;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (T item in Items)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }
            return sb.ToString().Trim();
        }
    }
}
