using Generic.DynamicList.DynamicListTest;
using Generic.LibraryLoader;

namespace Generic
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string path = args[0];
            Loader loader = new Loader(path);
            DynamicListTest dynamicListTest = new DynamicListTest();
        }
    }
}