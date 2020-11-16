using System;
using System.Reflection;
using Generic.Attributes;

namespace Generic.LibraryLoader
{
    public class Loader
    {
        public Loader(string path)
        {
            try
            {
                Assembly asm = Assembly.LoadFrom("C:\\Users\\shine\\Desktop\\Dev\\ExportClass\\Generic\\Generic\\bin\\Debug\\Generic.exe");
                Type[] types = asm.GetTypes();
                Type tp = null;
                foreach (Type t in types)
                {
                    if (t.IsPublic && Attribute.IsDefined(t, typeof(ExportClass)))
                    {
                        Console.WriteLine(t.FullName);
                        tp = asm.GetType(t.FullName);
                        MethodInfo[] methods = tp.GetMethods();
                    
                        foreach (MethodInfo mi in methods)
                        {
                            Console.WriteLine(mi.Name);
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("Error!");
            }
        }
    }
}