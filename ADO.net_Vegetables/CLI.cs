using System;
using System.Collections.Generic;
using Lib;

namespace ADO.net_Vegetables
{
    class CLI
    {
        public static void ShowMenu()
        {
            Console.WriteLine("БАЗА ДАННЫХ 'ОВОЩИ И ФРУКТЫ'.");
            Console.WriteLine("Выберите пункт меню для работы с базой:");
            Console.WriteLine("1. Отображение всей информации таблицы с овощями и фруктами.");
            Console.WriteLine("2. Отображение всех названий овощей и фруктов.");
            Console.WriteLine("3. Отображение всех цветов овощей и фруктов.");
            Console.WriteLine("4. Показать максимальную калорийность овощей и фруктов.");
            Console.WriteLine("5. Показать минимальную калорийность овощей и фруктов.");
            Console.WriteLine("6. Показать среднюю калорийность овощей и фруктов.");
            Console.WriteLine("0. Выход");
        }
        public static void ShowVegetables(List<Vegetables> vegetables)
        {
            foreach (var vegetabl in vegetables)
            {
                ShowVegetabl(vegetabl);
            }
        }
        public static void ShowVegetabl(Vegetables vegetables)
        {
            Console.WriteLine("--- --- ---");
            Console.WriteLine();
            Console.WriteLine ($"{vegetables.Id}: {vegetables.Name} {vegetables.Type} {vegetables.Color} {vegetables.CalorieContent}");
            Console.WriteLine("--- --- ---");
            Console.WriteLine();
        }
        public static void ShowListValue<T>(List<T> list, string title = " ")
        {
            if (title != " ")
            {
                Console.WriteLine($"{title}:");
            }
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        public static void ShowValue<T>(T value, string msg = " ")
        {
            if (msg != " ")
            {
                Console.Write(msg);
            }
            Console.WriteLine(value);
            Console.WriteLine();
        }
    }
}
