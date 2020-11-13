using System;

namespace Generic.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ExportClass: Attribute
    {
    }
    
    [ExportClass]
    public class ClassA
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