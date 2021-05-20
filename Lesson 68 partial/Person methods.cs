using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_68_partial
{
    partial class Person                                // Обьявление составного класса
    {
        public string GetFullName()                     // Метод конкатенирующий строки
        {
            return FirstName + " " + LastName;          // Возвращаем значение полного имени
        }
        public void PrintFullName(string arg = "")      // Метод вывода на экран полного имени  
        {
            Console.WriteLine(GetFullName()+" "+arg);   // Вывод на консоль
        }
        public partial string AddText(string arg)       // Частичный метод
        {
            return GetFullName() + " "+ arg;            // Какой то функционал метода
        }

    }
}
