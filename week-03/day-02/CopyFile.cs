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
        public static bool CopyFile(string sourcePath, string destPath)
        {
            try
            {
                File.Copy(sourcePath, destPath);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                return false;
            }
            return true;
        }
    }
}