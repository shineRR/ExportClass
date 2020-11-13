using System;

namespace Generic.DynamicList.DynamicListTest
{
    public class DynamicListTest
    {
        DynamicList<int> _dynamicList = new DynamicList<int>();
        
        public DynamicListTest()
        {
            Console.WriteLine("\nDynamic List");
            _dynamicList.Add(1);
            _dynamicList.Add(2);
            _dynamicList.Add(3);
            _dynamicList.Add(3);
            _dynamicList.Add(3);
            _dynamicList.Add(3);
            _dynamicList.Add(3);
            Console.WriteLine("Size = " + _dynamicList.Count);
            _dynamicList.RemoveAt(1);
            _dynamicList.Remove(3);
            var s = _dynamicList.GetEnumerator();
            while (s.MoveNext())
            {
                Console.WriteLine(s.Current);
            }
            _dynamicList.Clear();
            Console.WriteLine("Size = " + _dynamicList.Count);
        }
    }
}