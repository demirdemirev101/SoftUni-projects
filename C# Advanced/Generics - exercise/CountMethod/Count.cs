using System;
using System.Collections.Generic;
using System.Text;

namespace CountMethod
{
    public class CountMethod<T> where T : IComparable<T>    
    {
        public CountMethod()
        {
            Items = new List<T>();
        }
        public List<T> Items { get; set; }
        public int Occurances(T element)
        {
            int count = 0;
           
                foreach (var item in Items)
                {
                    if (item.CompareTo(element)>0)
                    {
                        count++;
                    }
                }
            
            return count;
        }
    }
}
