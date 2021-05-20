using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_55_part_2_Classes;

namespace Lesson_55_part_2_Classes
{   // Этот клас мы вынесли в отдельный файл

    //class Student                   // при создании класса (шаблона) мы прописываем характеристики которые могут содержать бьекты класса
    //{                               // Класс - наш собственный тип данных. Может быть значением вернувшимся из метода, а так же передавать этот тип данных в качестве параметров
    //    public Guid id;             // Guid - специальная структура для создания уникальных id
    //    public string firstName;
    //    public string lastName;
    //    public string middleName;
    //    public int age;
    //    public string group;
    //}
    class Program
    {
        static Student GetStudent()          // Тип возвращаемого обьекта -  Student
        {
            Student student = new Student(); //или так:  var student = new Student();

            student.firstName = "Martin";
            student.middleName = "Игоревич";
            student.lastName = "Фримен";
            student.age = 19;
            student.id = Guid.NewGuid();
            student.group = "KIT 40-b";

            return student;                 // Возвращаем заполненный обьект класса Student
        }

        static void Print(Student student) // передаём в метод в качестве параметра обьект типа Student
        {
            Console.WriteLine($"id:      {student.id}");
            Console.WriteLine($"Фамилия: {student.lastName}");
            Console.WriteLine($"Имя:     {student.firstName}");
            Console.WriteLine($"Отчество:{student.middleName}");
            Console.WriteLine($"Возраст: {student.age}");
            Console.WriteLine($"Группа:  {student.group}");
        }

        static void Main(string[] args)
        {
            var firstStudent = GetStudent();
            Print(firstStudent);
        }
    }
}
