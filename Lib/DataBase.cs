using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Lib
{
    public class DataBase
    {
        const string CONN_STR = "*************************************************************************;";
        private readonly MySqlConnection _db;
        private MySqlCommand _command;
        public DataBase()
        {
            _db = new MySqlConnection(CONN_STR);
            _command = new MySqlCommand { Connection = _db };
        }
        public void Open()
        {
            _db.Open();
        }
        public void Close()
        {
            _db.Close();
        }
        public List<Vegetables> GetVegetables() // получаем весь список овощей и фруктов.
        {
            var list = new List<Vegetables>();
            var sql = "SELECT * FROM table_vegetables";
            _command.CommandText = sql;
            var result = _command.ExecuteReader();
            while (result.Read())
            {
                var id = result.GetInt32("id");
                var name = result.GetString("name");
                var type = result.GetString("type");
                var color = result.GetString("color");
                var calorie_content = result.GetInt32("calorie_content");
                list.Add(new Vegetables { Id = id, Name = name, Type = type, Color = color, CalorieContent = calorie_content });
            }
            return list;
        }
        public List<string> GetNameVegetables() // получаем все имена овощей и фруктов.
        {
            List<string> names = new List<string>();
            var sql = "SELECT name FROM table_vegetables;";
            _command.CommandText = sql;
            var result = _command.ExecuteReader();
            while (result.Read())
            {
                names.Add(result.GetString("name"));
            }
            return names;
        }
        public List<string> GetColorVegetables() //// получаем все цвета овощей и фруктов.
        {
            List<string> colors = new List<string>();
            var sql = "SELECT color FROM table_vegetables;";
            _command.CommandText = sql;
            var result = _command.ExecuteReader();
            while (result.Read())
            {
                colors.Add(result.GetString("color"));
            }
            return colors;
        }
        public int GetMaxCalorieContent() // получаем максимальную калорийность овощей и фруктов.
        {
            var sql = "SELECT MAX(calorie_content) AS max FROM table_vegetables;";
            _command.CommandText = sql;
            var result = _command.ExecuteReader();
            int value = 0;
            while (result.Read())
            {
                value = result.GetInt32("max");
            }
            return value;
        }
        public int GetMinCalorieContent() // получаем минимальную калорийность овощей и фруктов.
        {
            var sql = "SELECT MIN(calorie_content) AS min FROM table_vegetables;";
            _command.CommandText = sql;
            var result = _command.ExecuteReader();
            int value = 0;
            while (result.Read())
            {
                value = result.GetInt32("min");
            }
            return value;
        }
        public decimal GetAvgCalorieContent() // получаем минимальную калорийность овощей и фруктов.
        {
            var sql = "SELECT AVG(calorie_content) AS avg FROM table_vegetables;";
            _command.CommandText = sql;
            var result = _command.ExecuteReader();
            decimal value = 0;
            while (result.Read())
            {
                value = result.GetDecimal("avg");
            }
            return value;
        }
    }
}
