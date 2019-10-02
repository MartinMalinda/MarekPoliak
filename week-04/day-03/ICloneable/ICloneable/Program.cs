using System;

namespace ICloneable
{
    class Program
    {
        static void Main(string[] args)
        {
            Student alex = new Student();
           alex.Introduce();
            Student marek = alex.Clone();
            marek.Introduce();
        }
    }
    
    public interface ICloneable<T>
    {
         T Clone();
    }
}
