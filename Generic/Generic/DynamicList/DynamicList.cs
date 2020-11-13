using System;
using System.Collections;
using System.Collections.Generic;

namespace Generic.DynamicList
{
    public class DynamicList<T> : IDynamicList<T>
    {
        private T[] _list;

        public int Count => _list.Length;
        public T[] Items => _list;

        public DynamicList()
        {
           _list = new T[0];
        }

        public void Add(T element)
        {
            int index = _list.Length;
            T[] newList = new T[index + 1];
            
            newList[index] = element;
            _list.CopyTo(newList, 0);
            _list = newList;
        }

        public void Remove(T element)
        {
            if (element == null) return;
            bool isFound = false;
            for (int i = 0; i < _list.Length; i++)
            {
                if (_list[i].Equals(element))
                {
                    RemoveAt(i + 1);
                    isFound = true;
                    break;
                }
            }
            if (!isFound)
                Console.WriteLine("Element is Not Found");
        }

        public void RemoveAt(int i)
        {
            int length = _list.Length;
            if (i > length)
            {
                Console.WriteLine("Out of Range!");
                return;
            }
            T[] newList = new T[length - 1];
            Array.Copy(_list, 0, newList, 0, i - 1);
            Array.Copy(_list, i, newList, i - 1, length - i);
            _list = newList;
        }

        public void Clear()
        {
            _list = new T[0];
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _list.Length; i++)
                yield return _list[i];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}