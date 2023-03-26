using System;
using System.Collections;
using System.Collections.Generic;

namespace Stack
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private int initialCapacity = 4;
        private T[] array;
        public CustomStack()
        {
            array = new T[initialCapacity];
        }
        public int Count { get; private set; }

        private void Resize()
        {
            T[] copy = new T[array.Length * 2];
            for (int i = 0; i < Count; i++)
            {
                copy[i] = array[i];
            }
            array = copy;
        }

        public void Push(T elementToPush)
        {
            if (Count==array.Length)
            {
                Resize();
            }
            array[Count]=elementToPush;
            Count++;
            
        }
        public T Pop()
        {
            if (Count==0)
            {
                throw new InvalidOperationException("No elements");
            }
            T lastElement=array[Count-1];
            array[Count - 1] = default(T);
            Count--;
            return lastElement;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                yield return array[i];
            }

        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
       
        
    }
}
