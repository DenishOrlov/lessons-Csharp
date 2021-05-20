﻿using System;

namespace Lesson_65_static_constructor
{
    /*
     * Ключевое слово static
     * 
     * Статический конструктор класса  
     *      Этот конструктор вызывается только один раз за работу программы при любом обращении к классу (например обращение к статик методу)
     *      и такой конструктор у программы может быть только один, остальные будут паблик, если нужны.
     *      Статический конструктор работает(внутри) только со статическими полями и методами, свойствами и всего того у чего ключевое слово static
     *      Не принимает параметров
     * 
     */
    class MyClass
    {
        private static int a;
        static MyClass()                         // Статический конструктор класса
        {
            a = 5;                               //Работает со статической переменной и методом
            Foo();
            Console.WriteLine("Статический конструктор");
        }

        public MyClass()
        {
            Console.WriteLine("Конструктор");
        }
        public static void Foo()
        {
            Console.WriteLine("Foo()");
        }
    }    
    class Program
    {
        static void Main(string[] args)
        {
            MyClass.Foo();                      // обращаясь к статическому методу статический конструктор всё равно вызовется,
                                                // хоть мы не создавали новый обьект класса. При чём до самоого метода

            MyClass myClass1 = new MyClass();
            
            new MyClass();
            new MyClass();
            new MyClass();
            

            
        }
    }
}
