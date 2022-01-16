using System;

namespace MyFirstApplication
{
    class Program
    {
        static void Main(string[] agrs)
        {

            Console.Write("Как тебя зовут?");
            string name = Console.ReadLine();

            System.Console.WriteLine($"Привет, {name}, сегодня {DateTime.Now}");

        }
    }
}
