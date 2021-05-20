using System;

namespace Lesson_54
{
    /*
     *  Enum (Перечисления ) Набор логически связанных констант
     *  
     *  структура обьявления:  " enum Название : Тип перечисления" (тип обязательно целочисленный: byte, int, short, long)
     *  Если тип перечисления явно не указан - по дэфолту будет int
     * 
     */

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;                 // Создаём переменную типа ConsoleKey куда присваиваем код сваойства .Key(enum) нажатой клавиши

                int keyCode = (int)key;                                 // Создаём переменную int, и присваиваем туда значение переменной key преобразуя в int

                Console.WriteLine($"\t Enum {key}\tKey Code {keyCode}");// Выводим на экран две переменные

                if (key == ConsoleKey.Enter)                            // Проверяем нажат ли Enter
                {
                    Console.WriteLine("Вы нажали Enter");               // Выводим сообщение если нажат Enter
                }
            }
            Console.WriteLine("Hello World!");
        }
    }
}
