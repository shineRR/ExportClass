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
        public void Hey()
        {
            Console.WriteLine("Hey");
        }

        public void Print()
        {
            Console.WriteLine("Print");
        }

        private static void Yes()
        {
            Console.WriteLine("static");
        }
        
        private void GetXY()
        {
            Console.WriteLine("GetXY");
        }
    }

    [ExportClass]
    internal class ClassB
    {
        public void Hey()
        {
            Console.WriteLine("Hey");
        }

        public void Print()
        {
            Console.WriteLine("Print");
        }

        private static void Yes()
        {
            Console.WriteLine("static");
        }
        
        private void GetXY()
        {
            Console.WriteLine("GetXY");
        }
    }
}