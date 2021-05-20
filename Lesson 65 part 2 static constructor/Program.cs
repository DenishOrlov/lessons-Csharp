using System;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_65_part_2_static_constructor
{
    /*
     * Пример использования статического конструктора
     * 
     *  Класс, который должен организовывать работу с какой то базой данных. Нам треуется информация о строке подключения к БД.
     *  Так как строка у нас одинакова для всех новых обьектов класса, то нет смысла каждый раз при создании нового экземпляра класса 
     *  создавать новую переменную с одинаковой строкой.
     *  
     *  Статический конструктор хорошо использовать, когда нужны постоянные данные, но на момент компиляции они не готовы 
     */

    class DbRepository                     // 
    {
        private static string connectionString;

        static DbRepository()                                   // Конструктор, будет вызван один раз и запишет строку
        {
            var configMan = new ConfigurationManager();         // Создаём новый обьект класса ConfigurationManager 
            connectionString = configMan.GetConnectionString(); // Вызываем у этого обьекта метод получения строки и записываем значение в переменную статик
        }
        public void GetData()
        {
            Console.WriteLine("Использую: " + connectionString);
        }
    }

    class ConfigurationManager                                    // Этот класс для работы с файлом конфигурации, откуда подтягивается строка конфигурайии из файла
    {
        public string GetConnectionString()
        {
            return "Local Db";              // Загрушка, в реальном проекте здесь бы было обращение к файлу
        }
    }
        
    class Program
    {
        static void Main(string[] args)
        {
            DbRepository firstRepos = new DbRepository();          // Создаём новый обьект класса
            firstRepos.GetData();                                  // Вызываем у него метод
        }
    }
}
