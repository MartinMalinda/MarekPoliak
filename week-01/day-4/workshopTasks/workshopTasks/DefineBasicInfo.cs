using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define several things as a variable then print their values
            // Your name as a string
            // Your age as an integer
            // Your height in meters as a double
            // Whether you are married or not as a boolean
            String name = "Marek";
            byte age = 20;
            double height = 1.80;
            bool married = false;
            Console.Write("My name is {0}, I am {1} years old, I am {2}m high!", name, age, height );
            if (married)
            {
                Console.WriteLine("And I am also married");
            }
            else
            {
                Console.WriteLine("And I am not married unfortunately");
            }
        }
    }
}