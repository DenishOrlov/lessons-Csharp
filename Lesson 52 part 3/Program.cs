using System;

namespace Lesson_52_part_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;

            int? b = 22; // если будет null - будет ошибка надо учитывать возможность появления null

            int? result = a + b;
            
            Console.WriteLine(result);

            Console.WriteLine(a == b);
            
            Console.WriteLine(a > b);
            
            Console.WriteLine(a < b);
        }
    }
}
