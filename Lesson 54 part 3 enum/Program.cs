using System;

namespace Lesson_54_part_3_enum
{
    class Program
    {
        enum DayOfWeek : byte// Зачения каждого элемента списка не указаны, но будут такие:
        {
            Monday = 1, // у этого элемента списка значение по дэфолту будет 0 (как в массиве), Если не присвоино другое
            Tuesday,    // на каждом слудующем элементе списка значение +1
            Wednesday,  // 3
            Thursday,   // 4
            Friday,    // 5
            Saturday,   // 6
            Sunday      // 7
        }

        static DayOfWeek GetNextDay(DayOfWeek day) // Метод вывода следующего дня / По скольку enum - целые числа, то можем выполнять некоторые операции с ними
        {
            if (day < DayOfWeek.Sunday)            // Проверяем целое значение переменной day
            {
                return day + 1;                    // То возвращаем следующее значение в энуме DayOfWeek
            }
            return DayOfWeek.Monday;               // Если больше воскременья, то выводим первый день (элемент enum)
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine(GetNextDay(DayOfWeek.Sunday));
            Console.WriteLine(GetNextDay(DayOfWeek.Friday));

            DayOfWeek dayOf;                                  // Обьявляем новую переменную типа DayOfWeek
            int value = 55;                                   // Новая инт со значением которого нет в DayOfWeek
            dayOf = (DayOfWeek)value;                         // Пытаемся перевести значение в из int в тип DayOfWeek и присвоить переменной

            if (Enum.IsDefined(typeof(DayOfWeek),value))      // используем метод IsDefined(возвращает true или false), который определит есть ли такое значение в нашем списке DayOfWeek
                                                              // первым параметром передаём typeof(DayOfWeek), вторым - значение для проверки
            {
                dayOf = (DayOfWeek)value;                     // Если есть такое значение, то в переменную записываем день
            }
            else
            {
                throw new Exception("Invalid DayOfWeek value. ");
            }
            Console.WriteLine(dayOf);
        }
    }
}
