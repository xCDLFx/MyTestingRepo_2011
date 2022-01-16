using System;

namespace HomeWork_2_1
{
    class Program
    {
        static void Main(string[] agrs)
        {

            System.Console.WriteLine("Введите максимальную температуру за сутки");
            float maxt = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Введите минимальную температуру за сутки");
            float mint = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine($"Минимальная - {mint} максимальная - {maxt}");
            float sredny = (mint + maxt) / 2;
            System.Console.WriteLine($"Средняя температура за сутки - {sredny}");
        }
    }
}