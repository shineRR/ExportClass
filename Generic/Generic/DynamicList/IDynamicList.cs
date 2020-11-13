using System.Collections.Generic;

namespace Generic.DynamicList
{
    public interface IDynamicList<T>: IEnumerable<T>
    {
        void Add(T element);
        void Remove(T element);
        void RemoveAt(int i);
        void Clear();
    }
}