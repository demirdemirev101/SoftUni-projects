using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    public class CustomTuple<T1,T2,T3> where T3 : IComparable<T3>
    {
        public T1 Item1 { get; set; }
        public T2 Item2 { get; set; }
        public T3 Item3 { get; set; }

        public override string ToString()
        {
            return $"{Item1} -> {Item2} -> {Item3}";
        }
        //public bool IsDrunk()
        //{
        //    if (Item3.CompareTo(T3)==0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
