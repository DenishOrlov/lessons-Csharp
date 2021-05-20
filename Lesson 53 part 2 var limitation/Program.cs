using System;

namespace Lesson_53_part_2_var_limitation
{
    /*
     * Ограничения для использования var
     */


    //class MyClass
    //{
    //    public var a = 0;  // не можем использовать как поля класса
    //}
    class Program
    {
        //static void Bar(var a) // не можем использовать как параметр метода
        //{

        //}
        //static var Foo()  // не можем использовть как тип возвращаемого значения
        //{

        //}
        static int Sum (int a, int b)
        {
            var result = a + b;         // и так можем использовать
            return result;
        }
        static void Main(string[] args)
        {
            var t = Sum(2,3);           // так можем использовать
            
            Console.WriteLine(t);
        }
    }
}
