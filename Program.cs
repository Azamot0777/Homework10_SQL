using System;

namespace Homework10_SQL
{
    public class SQL
    {
        public string Name;
        public string Size;
        public string Model;

        public SQL(string Name, string Size, string Model)
        {
            this.Name = Name;
            this.Size = Size;
            this.Model = Model;
        }
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
            string[] name = { "Флешка для компа", "Флешка для смартфона", "Флешка обычная", "Встроенная флешка", "Флешка для кота" };
            string[] size = { "32 gb", "64 gb", "128 gb", "256 gb", "512 gb" };
            string[] model = { "3211p", "11o1k", "2o20p", "yyer01", "hjik1" };
            for (int i = 0; i < 5; i++)
            {
                SQL q = new SQL(name[i], size[i], model[i]);
                q.GetInfo();
            }

        }
    }
}
