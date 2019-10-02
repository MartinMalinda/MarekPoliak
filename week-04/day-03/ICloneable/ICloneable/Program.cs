using System;

namespace ICloneable
{
    class Program
    {
        static void Main(string[] args)
        {
            Student alex = new Student();
            alex.Introduce();
            Student alexovKlon = alex.Clone();
            alexovKlon.Introduce();
        }
    }
    
    public interface ICloneable<T>
    {
         T Clone();
    }
}
