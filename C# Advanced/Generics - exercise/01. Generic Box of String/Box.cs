using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Generic_Box_of_String
{
    public class Box<T>
    {
        public List<T> Items { get; set; }

        public Box()
        {
            Items = new List<T>();
        }

        public override string ToString()
        {
            StringBuilder sb=new StringBuilder();
            foreach (T item in Items)
            {
            sb.AppendLine($"{typeof(T)}: {item}");
            }
            return sb.ToString().Trim();
        }
    }
}
