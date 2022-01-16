using System;

namespace MyHomeWork_2_4
{
    class Program
    {
        static void Main(string[] agrs)
        {
            String name = "ООО Пятерочка";
            int prod = 456;
            int smen = 16;
            string tovar = "Хлеб";
            int kol = 1;
            int stoimost = 25;
            int summa = kol * stoimost;
            int chek = 789;

            Console.WriteLine($"|    {name}   |");
            Console.WriteLine("|    Кассовый чек    |");
            Console.WriteLine("|Приход              |");
            Console.WriteLine("|       Иванов И.И.  |");
            Console.WriteLine("|        Кассир      |");
            Console.WriteLine($"|Продажа#{prod} Смена#{smen}|");
            Console.WriteLine($"|1) {tovar}             |");
            Console.WriteLine($"|{kol} x {stoimost} = {summa}         |");
            Console.WriteLine($"|Итог ={summa}            |");
            Console.WriteLine($"|Сумма без НДС   ={summa} |");
            Console.WriteLine($"|Безналичными    ={summa} |");
            Console.WriteLine($"|Чек #{chek}            |");
            Console.WriteLine("| Спасибо за покупку |");
            Console.WriteLine("|   Ждем вас снова   |");


        }
    }
}