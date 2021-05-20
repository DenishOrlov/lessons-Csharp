using System;


namespace Lesson_56
{
    /*
     * ООП
     * Методы обьекта класса
     */

    class Program
    {
        static Student GetStudent()
        {
            var student = new Student(); // уже в методе создаём обьект класса

            student.firstName = "Мартин";
            student.middleName = "Игоревич";
            student.lastName = "Ботов";
            student.age = 20;
            student.id = Guid.NewGuid();
            student.group = "KIT 40";

            return student;
        }
        static void Main(string[] args)
        {
            var firstStudent = GetStudent(); // вызываем метод в котором создастся новый обьект класса Student

            firstStudent.Print();            // вызываем метод класса Students у конкретного экземпляра firstStudent
                                             // для каждого экзэмпляра, метод Print() выводит свои данные конкретного экзэмляра. Например обьект secondStudent с методом принт выведет другие данные

            Student secondStudent = new Student();
            secondStudent.age = 18;
            secondStudent.Print();

            string fullName = firstStudent.GetFullName(); // вызываем метод у конкретного экзэмпляра класса, который возращает его значения
            Console.WriteLine(fullName);
        }
    }
}
