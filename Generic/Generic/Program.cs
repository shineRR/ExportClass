using System;
using Generic.DynamicList;
using Generic.LibraryLoader;

namespace Generic
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string path = "C:\\Users\\shine\\Desktop\\Dev\\ExportClass\\ExportedDll\\ExportedDll\\bin\\Debug\\ExportedDll.dll";
            // Loader loader = new Loader(path);
            
            DynamicList<int> dynamicList = new DynamicList<int>();
            dynamicList.Add(1);
            dynamicList.Add(2);
            dynamicList.Add(3);
            dynamicList.Add(3);
            dynamicList.Add(3);
            dynamicList.Add(3);
            dynamicList.Add(3);
            foreach (var arr in dynamicList.Items)
            {
                Console.WriteLine(arr);
            }
            Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||");
            
            foreach (var arr in dynamicList.Items)
            {
                Console.WriteLine(arr);
            }
            dynamicList.Remove(3);
            foreach (var arr in dynamicList.Items)
            {
                Console.WriteLine(arr);
            }
            
        }
    }
}