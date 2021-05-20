using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_67_Students 
{
    /* 
     * Написать метод, чтоб возвращал полное имя студента
     * 
     * Представим что этот класс записан в библиотеке и не можем его модифицировать, не можем наследовать, по тому, что sealed
     */

    sealed class Student
    {
        public string FirstName { get; set; } // Такое свойство автоматически генерирует поле класса(переменную)
        public string LastName { get; set; }  // Такое свойство автоматически генерирует поле класса(переменную)
    }
}
