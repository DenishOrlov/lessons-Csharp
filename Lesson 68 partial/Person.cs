using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_68_partial
{
    partial class Person
    {
        private string FirstName { get; set; }            // поля класса с автоматическими свойствами и генерацией переменной 
        private string LastName { get; set; }

        public Person(string firstName, string lastName) // Конструктор класса с параметрами
        {
            FirstName = firstName;                       // Присваиваем значение из параметров конструктора в поля класса
            LastName = lastName;                
        }
        public partial string AddText(string arg);       // Дублирование обьявления метода


    }
}
