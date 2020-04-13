using System;

namespace Homework10_SQL
{
    public class SQL
    {
        public string Name;
        public string Size;
        public string Model;

        public SQL() { }
        public void GetInfo()
        {
            System.Console.WriteLine($"Название Флешки : {Name}");
            System.Console.WriteLine($"Размер Флешки : {Size}");
            System.Console.WriteLine($"Модель Флешки : {Model}");
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "Флешка для компа", "Флешка для смартфона" };
            string[] size = { "32 gb", "64 gb", "128 gb", "256 gb", "512 gb" };
            string[] model = { "3211p", "11o1k", "2o20p", };
            for (int i = 0; i < 9; i++)
            {
                SQL q = new SQL();
            }

        }
    }
}
