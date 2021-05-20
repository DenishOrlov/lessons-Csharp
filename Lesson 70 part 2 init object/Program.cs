using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_70_part_2_init_object
{
    
    class Program
    {
        static void Main(string[] args)
        {
            // Стандартное заполнение полей обьекта
            Person person1 = new Person();
            person1.FirstName = "Вадим";
            person1.LastName = "Андропов";

            Address address1 = new Address();
            address1.City = "Харьков";
            address1.Region = "Правобережье";
            address1.Country  = "Украина";

            person1.Address = address1;


            // Заполнение при создании
            Person person2 = new Person         // Используем конструктор без паеметров
            {
                FirstName = "Равиль",
                LastName = "Рубин",
                Address = new Address           // Созданный обьект клааса записывается прямо в поле класса
                {                       
                    City = "Тримштат",          // Явно видно, что информация об адрессе принадлежит классу person
                    Region = "Козье",
                    Country = "Ингушетия"
                }
            };

            Person person3 = new Person("Вадим", "Павлов") // Более удобно записывать адресс, не создаём отдельно, а уже при обьявлении Person
            {
                Address = new Address
                {
                    City = "Тримштат",
                    Region = "Козье",
                    Country = "Ингушетия"
                }
            };


            Console.WriteLine(person1);
        }
    }
}
