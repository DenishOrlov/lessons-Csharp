using System;
using Lesson_67_Students;
using Lesson_67_Extensions;

namespace Lesson_67_part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student() { FirstName = "Марти", LastName = "Позов" }; // Создали обьект класа и наполнили его поля значениями

            string fullName = student1.GetFullName();                                     // Создали переменную и поместили туда значение выполнения Extension метода

            Console.WriteLine(fullName);
        }
    }
}
