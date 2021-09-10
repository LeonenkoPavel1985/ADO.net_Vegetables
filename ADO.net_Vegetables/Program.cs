using System;
using System.IO;
using Lib;

namespace ADO.net_Vegetables
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new DataBase();
            var exit = false;
            do
            {
                CLI.ShowMenu();
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": 
                        db.Open(); // отображение всех овощей и фруктов.
                        CLI.ShowVegetables(db.GetVegetables()); 
                        db.Close();
                        break;
                    case "2":  //  отображение названий овощей и фруктов.
                        db.Open();
                        CLI.ShowListValue(db.GetNameVegetables(), "Названия овощей и фруктов:");
                        db.Close();
                        break;
                    case "3":  //  отображение цветов овощей и фруктов.
                        db.Open();
                        CLI.ShowListValue(db.GetColorVegetables(), "Все цвета овощей и фруктов:");
                        db.Close();
                        break;
                    case "4":  //  отображение максимальной калорийности овощей и фруктов.
                        db.Open();
                        CLI.ShowValue(db.GetMaxCalorieContent(), "Максимальная калорийность овощей и фруктов:");
                        db.Close();
                        break;
                    case "5":  //  отображение максимальной калорийности овощей и фруктов.
                        db.Open();
                        CLI.ShowValue(db.GetMinCalorieContent(), "Минимальноя калорийность овощей и фруктов:");
                        db.Close();
                        break;
                    case "6":  //  6. отображение средней калорийности овощей и фруктов.
                        db.Open();
                        CLI.ShowValue(db.GetAvgCalorieContent(), "Средняя калорийность овощей и фруктов:");
                        db.Close();
                        break;
                    case "0": // выход из программы.
                        exit = true;
                        break;
                    default:
                        break;
                }
            } while (!exit);
        }
    }
}
