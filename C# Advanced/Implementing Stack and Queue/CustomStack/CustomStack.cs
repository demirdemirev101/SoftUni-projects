using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CustomStack
{
    public class CustomStack
    {
        public CustomStack()
        {
            this.items = new int[InitialCapacity];

        }
        private const int InitialCapacity = 4;
        private int[] items;
        public int Count { get; private set; }

        private void Resize()
        {
            int[] copy= new int[this.items.Length*2];
            for (int i = 0; i < this.items.Length; i++)
            {
                copy[i] = this.items[i];
            }
            items = copy;
        }
        private void Shift(int index)
        {
            for (int i = index; i < this.items.Length; i++)
            {
                items[i] = items[i + 1];
            }
        }
        public void Push(int element)
        {
            if (Count==this.items.Length)
            {
                this.Resize();
            }
            this.items[this.Count] = element;
            Count++;
        }
        public int Pop()
        {
            if (this.items.Length==0|| Count==0)
            {
                throw new InvalidOperationException("CustomStack is empty");
            }
            int lastElement=items[Count-1];
            items[Count-1] = 0;
            Count--;
            
            return lastElement;
        }
        public int Peek()
        {
            if (this.items.Length == 0 || Count == 0)
            {
                throw new InvalidOperationException("CustomStack is empty");
            }
            
            return items[Count-1];
        }
        public void ForEach(Action<int> action)
        {
            for (int i = 0; i < this.Count; i++)
            {
                action(this.items[i]);
            }
        }
    }
}
