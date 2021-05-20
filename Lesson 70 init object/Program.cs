using System;

namespace Lesson_70_init_object
{
    /*
     * Синтаксис инициализации обьектов
     * 
     * Прямо в момент создания обьекта класса можем присвоить нужные данные в поля или свойства с модификатором public
     */

    class Cat
    {
        public int Age { get; set; }
        public string Name { get; set; }
    
        public Cat()
        {

        }
        public Cat(string Name)
        {
            this.Name = Name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Тут создан сначала обьект, а потом присвоены значения полям
            Cat cat1 = new Cat();
            cat1.Age = 3;
            cat1.Name = "Ингибитор";

            // Вот так выглядит синтаксис инициализации обьектов. Тут можем присвоить значение в паблик поля
            // Тут выполняется полная инициализация обьекта класса с данными в поля
            Cat cat2 = new Cat
            {
                Age = 3,
                Name = "Ингибитор"
            };

            // Используем инициализацию с конструктором с парамтром

            Cat cat3 = new Cat("Рыжик");
            cat3.Age = 3;

            Cat cat4 = new Cat("Рыжик")
            {
                Name = "Петрушка",       //Это значение будет хранится, потому что записалось последним
                Age = 3
            }; 

            //Console.WriteLine("Hello World!");
        }
    }
}
