using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Intermediate
{
    public class Stack
    {
        private readonly object[] _items = new object[5];

        private int _count;

        public void Push(object obj)
        {
            _items[_count++] = obj ?? throw new InvalidOperationException();
        }

        public object Pop()
        {
            if(_items.Length == 0)
                throw new InvalidOperationException();

            var index = _count - 1;
            var toPop = _items[index];
            _count--;

            return toPop;
        }

        public void Clear()
        {
            Array.Clear(_items, 0, _items.Length);
        }
    }
}
