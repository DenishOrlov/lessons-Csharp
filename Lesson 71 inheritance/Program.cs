using System;

namespace Lesson_71_inheritance
{
    /*
     * Наследование в ооп
     *      Инструмент, который помогает избежать ненужное дублирование кода
     *      Особенность, благодаря которой реализуется полиморфизм
     *      Позволяет использовать ваши новые классы, созданные с помощью наследования вашим старым кодом, без внесения туда модификаций
     */
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void PrintName()
        {
            Console.WriteLine($"Меня зовут {FirstName}");
        }
    }
    //Пишем класс в котором нам нужен похожий функционал
    class Student : Person                // Наследуемся от класса Person. Student наслеует весь функционал, и по сути являеется классом Person
    {
        public void Learn()               // Помимо доработки наследника, мы можем добавлять функционал и в уже написанные родительские
        {
            Console.WriteLine("Я учусь"); // Добавляем функционал
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person() { FirstName = "Vova", LastName = "Printer" };
            person1.PrintName();

            // инициализируем наследованый класс, в нем появились все методы класса - родителя(базового) 
            Student student = new Student() { FirstName = "Tim", LastName = "Gamazov" }; // Инициализируем новый обьект нового класса
            student.PrintName();
            student.Learn();



            // Можем обьявить тип данных Person, но присвоить туда новый обьект Student. Такой обьект сможет использовать только функционал Person класса
            
            Person person2 = new Student { FirstName = "Adam", LastName = "Joe" };

            //person2.Learn(); // Так работать не будет, это метод наследника, о котором Person не знает

            // Пример зачем это нужно: Допустим у нас нет наследника Students и мы сделали метод PrintFullName, который в качестве параметра принимает тип данных Person.
            // Потом мы создали класс Student, наследник класса Person. Метод PrintFullName сможет принимать в каxестве параметра и тип данных Student,
            // но работать с теми полями, которые определены в классе Person.

            PrintFullName(person1);                                                       // Вызываем метод с параметром типа данных Person

            Student student1 = new Student() { FirstName = "Кей", LastName = "Парелов" }; //

            PrintFullName(student1);                                                      // Вызываем метод с параметром типа данных Student
        }
        static void PrintFullName(Person person)
        {
            Console.WriteLine($"Фамилия: {person.LastName}\t Имя: {person.FirstName}");
        }
    }
}
