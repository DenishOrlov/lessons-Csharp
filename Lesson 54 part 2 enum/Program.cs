using System;

namespace Lesson_54_part_2_enum
{
    class Program
    {
        enum Days       // Можно указать значения для каждого элемента, или нескольких
        {
            Monday,     // у этого элемента списка значение по дэфолту будет 0 (как в массиве), Если не присвоино другое
            Tuesday,    // на каждом слудующем элементе списка значение +1
            Wednesday,  // 2
            Thursday,   // 3
            Friday = 10,// 10 Здесь присваиваем своё значение и дальше не присваиваем
            Saturday,   // 11 И дальше значения будут +1
            Sunday      // 12
        }

        enum DayOfWeek : byte// Зачения каждого элемента списка не указаны, но будут такие:
        {
            Monday = 1, // у этого элемента списка значение по дэфолту будет 0 (как в массиве), Если не присвоино другое
            Tuesday,    // на каждом слудующем элементе списка значение +1
            Wednesday,  // 3
            Thursday,   // 4
            Friday ,    // 5
            Saturday,   // 6
            Sunday      // 7
        }
        static void Main(string[] args)
        {
            // к элементу типа enum ображаемся через точку
            DayOfWeek day = DayOfWeek.Saturday;                           // по дэфолту значение переменной Monday/ значение можно присваивать только по Тексту(Monday)
            
            
            

            //   Enum.GetUnderlyingType()  Метод принимает в качестве параметра принимает тип данных Type
            Console.WriteLine(Enum.GetUnderlyingType(typeof(DayOfWeek))); // получаем тип данных, который используется чтоб хранить экземпляры! переменной DayOfWeek,
                                                                          // передав методу в скобках typeof(DayOfWeek) - это метод возвращает обьект типа Type

            Console.WriteLine(day);                                       // Выводим элемент
            
            Console.WriteLine((int)day);                                  // Выводим соответствующее численное значение элемента (преобразуем к типу int)

            Console.WriteLine((int)DayOfWeek.Thursday);                   // Напрямую выводим соответствующее численное значение элемента

            Console.WriteLine((DayOfWeek)1);                              // Приводим int (значение 3) к типу данных нашего энама DayOfWeek

            Console.WriteLine();

            for (int i = 1; i <= 7; i++)                                  // Это я от себя
            {
                Console.WriteLine((DayOfWeek)i);
            }


        }
    }
}
