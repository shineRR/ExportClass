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
            _dynamicList.Add(4);
            _dynamicList.Add(5);
            _dynamicList.Add(6);
            _dynamicList.Add(7);
            
            int[] array = _dynamicList.Items;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\nSize = " + _dynamicList.Count);
            
            _dynamicList.RemoveAt(1);
            _dynamicList.Remove(3);
            
            var s = _dynamicList.GetEnumerator();
            while (s.MoveNext())
            {
                Console.Write(s.Current + " ");
            }
            _dynamicList.Clear();
            Console.WriteLine("\nSize = " + _dynamicList.Count);
        }
    }
}