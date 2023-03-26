using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CustomQueue
{
    public class CustomQueue
    {
        public CustomQueue()
        {
            Count = 0;
            items = new int[InitialCapacity];
        }
        private const int InitialCapacity = 4;
        private int[] items;
        private int FirstElementIndex = 0;
        public int Count { get; private set; }

        private void IncreaseSize()
        {
            int[] copy=new int[InitialCapacity*2];
            for (int i = 0; i < items.Length; i++)
            {
                copy[i] = items[i];
            }
            items = copy;
        }
        public void Enquque(int element)
        {
            if (Count==items.Length)
            {
                IncreaseSize();
            }
            items[Count] = element;
            Count++;
        }
        private void IsEmpty()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("CustomQueue is empty");
            }
        }
        private void Shift()
        {
            for (int i = 0; i < Count; i++)
            {
                items[i] = items[i + 1];
            }
        }
        public int Dequeue()
        {
            int firstElement = items[FirstElementIndex];
            items[FirstElementIndex] = 0;
            IsEmpty();
            Shift();
            Count--;
            return firstElement;
        }
        public int Peek()
        {
            return items[FirstElementIndex];
        }
        private void DecreaseSize()
        {
            int[] copy = new int[InitialCapacity];
            items = copy;
        }
        public int Clear()
        {
            IsEmpty();

            while (Count!=0)
            {
                Dequeue();
            }
            DecreaseSize();
            return Count;
        }
        public void ForEach(Action<int> action)
        {
            for (int i = 0; i < Count; i++)
            {
                action(items[i]);
            }
        }
    }
}
