using System;
using System.Reflection;

namespace Generic.LibraryLoader
{
    public class Loader
    {
        public Loader(string path)
        {
            try
            {
                Assembly asm = Assembly.LoadFrom(path);
                Type[] types = asm.GetTypes();
                Type tp = null;
                foreach (Type t in types)
                {
                    if (t.Name == "ExportClass")
                    {
                        tp = asm.GetType(t.FullName);
                        break;
                    }
                }
                MethodInfo[] methods = tp.GetMethods();

                foreach (MethodInfo mi in methods)
                {
                    Console.WriteLine(mi.Name);
                }
            }
            catch
            {
                Console.WriteLine("Error!");
            }
        }
    }
}