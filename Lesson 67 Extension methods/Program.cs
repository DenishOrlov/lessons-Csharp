using System;
using MyExtens;

namespace Lesson_67_Extension_methods
{
    /*
     * Extension методы (метода расширения) (расширяющие методы)
     *     
     *      Добаваляют новый функционал к уже существующим классам или структурам, при этом их не модифицируя 
     *      
     *      Применяют при уже существующих классах, если не мой, или находится в библиотеке классов, или классы уже скомпилированны
     *      и нет доступа к ним
     *      
     *      Вообще можно использовать наследование, и наследоваться от нужного класса и добавлять функионал в новый созданный,
     *      если у класса модификатор не sealed
     *      
     *      1. Методы  расширения должны находиться в статическом класса и сами быть статическими
     */
    class Program
    {
        static void Main(string[] args)
        {
            // Допустим, хотим что бы структура DateTime могла выводить себя на консоль
            // У структуры DateTime нет такого метода изначально, и модифицировать её мы не можем
            // currentDateTime.Print()   например так

            DateTime currentDateTime = DateTime.Now;                          // Создаём переменную структуры DateTime и записываем туда текущую дату и время

            currentDateTime.Print();                                          // Вызываем расширенный метод структуры DateTime, чтоб она выводила себя на консоль
                
            Console.WriteLine(DayOfWeek.Friday);                              // Вернёт значение Friday

            Console.WriteLine(currentDateTime.IsDayOfWeek(DayOfWeek.Friday)); // Передаём в качестве параметра DayOfWeek.Friday - это энам (свой тип данных)

            Console.WriteLine(MyExtens.MyExtensions.statDatTime); // Если класс в отдельном файле, то пишем: Пространство_имён.класс.метод(или поле и т.д.)
            Console.WriteLine(MyExtens.MyExtensions.statDayWeek); // Если класс в отдельном файле, то пишем: Пространство_имён.класс.метод(или поле и т.д.)

            string dayFrom = Console.ReadLine();                               // Обьявляю строку и записываю в неё значение введённое из консоли

            DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), dayFrom); // Обьявляю переменную типа DayOfWeek и преобразую в неё значение из введённой строки


            if (currentDateTime.IsDayOfWeek(day))                              // Передаю в качестве аргумента переменную day типа DayOfWeek.
                                                                               // Получаю булевое значение из метода IsDayOfWeek()
            {
                Console.WriteLine($"Сегодня действительно {day} "); 
            }
            else
            {
                Console.WriteLine($"Сегодня не {day} ");
            }

            


        }   
    }
}
