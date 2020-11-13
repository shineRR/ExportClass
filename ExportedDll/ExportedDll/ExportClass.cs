using System;

namespace ExportedDll
{
    public class ExportClass
    {
        public void Hello()
        {
            Console.WriteLine("Hello");
        }

        public void Bye()
        {
            Console.WriteLine("Bye");
        }

        private static void Yes()
        {
            Console.WriteLine("static");
        }
        
        private void Hey()
        {
            Console.WriteLine("Hey");
        }
    }
}