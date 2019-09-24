using System;
using System.IO;
using System.Linq;

namespace Example
{
    class Program
    {
        public static void Main(string[] args)
        {
            
        }
        public static void WriteNameIntoFile(string name, string path)
        {
            try
            {
                File.WriteAllText(path, name);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                Console.WriteLine("Unable to write file: "+path);
            }
        }
    }
}