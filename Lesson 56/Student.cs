using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_56
{
    class Student                   // выносим класс в отдельный файл
    {
        public Guid id;             // Guid - специальная структура для создания уникальных id
        public string firstName;
        public string lastName;
        public string middleName;
        public int age;
        public string group;

        public void Print() //если мы хотим что бы метод класса работал с полями ТОГО же класса, то мы не передаём ему параметры
        {
            Console.WriteLine($"\nid:      {id}");
            Console.WriteLine($"Фамилия: {lastName}");
            Console.WriteLine($"Имя:     {firstName}");
            Console.WriteLine($"Отчество:{middleName}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Группа:  {group}");
        }
        
        public string GetFullName()
        {
            return $"{lastName}  {firstName}  {middleName}";
        }
    }
}
