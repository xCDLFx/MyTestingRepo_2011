using System;

namespace MyHomeWork_2_3
{
    class Program
    {
        static void Main(string[] agrs)
        {

            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число нечетное");
            }
        }
    }
}