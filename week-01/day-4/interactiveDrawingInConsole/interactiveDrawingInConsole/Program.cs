using System;

namespace interactiveDrawingInConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorLeft = Console.WindowWidth / 2;
            Console.CursorTop = Console.WindowHeight / 2;
            bool draw = false;
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                switch (keyInfo.Key)
                {
                    case ConsoleKey.DownArrow:
                        if (Console.CursorTop < Console.WindowHeight - 1)
                        {
                            Console.CursorTop += 1;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (Console.CursorTop > 0)
                        {
                            Console.CursorTop -= 1;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (Console.CursorLeft > 0)
                        {
                            Console.CursorLeft -= 1;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (Console.CursorLeft < Console.WindowWidth - 1)
                        {
                            Console.CursorLeft += 1;
                        }
                        break;
                    case ConsoleKey.D:
                        if (draw)
                        {
                            draw = false;
                        }
                        else
                        {
                            draw = true;
                        }
                        break;
                    case ConsoleKey.C:
                        Console.Clear();
                        Console.CursorLeft = Console.WindowWidth / 2;
                        Console.CursorTop = Console.WindowHeight / 2;
                        break;
                    default: //do nothing
                        break;
                }
                if (draw)
                {
                    Console.Write("#");
                    Console.CursorLeft -= 1;
                }
            }
        }
    }
}
