using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Lesson_53_var
{
    /*
     * Ключевое слово var
     * 
     * неявно типизированные локальные переменные
     * 
     * 
     * var - не тип данных. Это Ключевое слово указывает компилятору на то что он должен выяснить тип данных переменной
     *       в зависимости от того что мы хотим присвоить в эту переменную. Чем мы изначально её инициализируем - таким
     *       типом данных она и будет.
     *       Переменная всё равно строготипизированная.
     *       var удобно использовать для обьявления обьектов/классов/коллекций, которые для создания требуют длинной записи
     *       
     */

    class Program
    {
        static void Main(string[] args)
        {
            var t = 5;                          // тут компилятор поймёт тип данных как int

            var s = "Hello";                    // тут компилятор поймёт тип данных как string

            var y = new float[10];

            // var a = null; не получится

            Console.WriteLine(t.GetType());
            Console.WriteLine(s.GetType());
            Console.WriteLine(y.GetType());


            // неявная типизация с var
            var d = new Dictionary<int, string>();

            // без var
            Dictionary<int, string> dic = new Dictionary<int, string>();

            var ti = new { Name = "Мартин ", Age = 25 }; // анонимный тип. прямо на лету создаём свой тип данных

            Console.WriteLine(ti.GetType());

            int[] numbers = { 1, 5, 344, 50, 2, 56, 4, 7, 11 };   // массив элементов 

            var result = from i in numbers where i > 15 select i; // это Linq запрос на нахождение в массиве numbers элемента больше 15

            foreach (var item in result)                          // выводим на экран
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            Console.WriteLine($"Тип данных result {result.GetType()}");

        }
    }
}
