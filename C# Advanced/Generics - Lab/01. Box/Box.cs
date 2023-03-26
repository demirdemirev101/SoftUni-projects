using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace _01._Box
{
    public class Box<T>
    {
        public Box()
        {
            list = new List<T>();
        }
        private List<T> list;
        public int Count { get { return list.Count; } }
        public void Add(T element)
        {
            list.Insert(0, element);
        }
        public T Remove()
        {
            var lastElement = list[0];
            list.Remove(list[0]);
            return lastElement;
        }
    }
}
