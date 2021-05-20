using System;

namespace Lesson_52_part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int? i = null;                             // Nulable переменная типа int и туда присваиваем null

            Console.WriteLine(i == null);              // true   сравнение с null

            Console.WriteLine(i.HasValue);             // false  присвоино ли значение переменной

            Console.WriteLine(i.GetValueOrDefault());  // 0      вернуть значение Nulable - переменной, или дэфолтное, указанное в скобках метода GetValueOrDefault().
                                                       // Если в скобках не указанное значение, то вернёт дэфолтное значение для типа данных переменной, в данном случае для int 0

            Console.WriteLine(i.GetValueOrDefault(3)); // 3

            Console.WriteLine(i ?? 55);                //  55  если null то дэфолтное значение 55

            //Console.WriteLine(i.Value);                //  реальное значение/ Если пусто - будет ошибка InvalidOperationException

            Console.WriteLine(i);

            // присваиваем значение Nulable переменной i

            i = 2;

            Console.WriteLine(i == null);              // false   сравнение с null

            Console.WriteLine(i.HasValue);             // true  присвоино ли значение переменной

            Console.WriteLine(i.GetValueOrDefault());  // 2
                                                       // 

            Console.WriteLine(i.GetValueOrDefault(3)); // 2

            Console.WriteLine(i ?? 55);                // 2  

            Console.WriteLine(i.Value);                // 2

           
            
        }

    }
}
