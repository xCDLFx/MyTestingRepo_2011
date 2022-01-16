using System;

namespace HomeWork_2_2
{
    class Program
    {
        static void Main(string[] agrs)
        {

            Console.WriteLine("Введите число месяца");
            int month = Convert.ToInt32(Console.ReadLine());

            switch (month) 
            { 
                case 1:
                    {
                        Console.WriteLine("Это январь");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Это февраль");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Это март");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Это апрель");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Это май");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Это июнь");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Это июль");
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("Это август");
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("Это сентябрь");
                        break;
                    }
                case 10:
                    {
                        Console.WriteLine("Это октябрь");
                        break;
                    }
                case 11:
                    {
                        Console.WriteLine("Это ноябрь");
                        break;
                    }
                case 12:
                    {
                        Console.WriteLine("Это декабрь");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Такого месяца не существует");
                        break ;
                    }
                    
            }

        }
    }
}