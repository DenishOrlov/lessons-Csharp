using System;

namespace Lesson_64_part_2_class_static_work
{
    /*
     * Написать программу, которая будет считать количество созданных обьектов моего класса 
     * 
     */

    class MyClass
    {
        private static int count = 0;  // счётчик создания обьектов классов

        public MyClass()              // конструктор
        {
            this.Count++;              // инкрементим счётчик
        }   
        public int Count               // свойства поля счётчика, чтоб иметь доступ к значению 
        {                              // при выводе и при записе
            get { return count; }
            private set { count = value; } // делаем get приватным, чтоб можно было менять значение только внутри класса
        }

        public static int CountStatic   // делаем доступ к значению через класс на прямую 
        {
            get { return count; }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass class1 = new MyClass(); 
            MyClass class2 = new MyClass();
            MyClass class3 = new MyClass();
            MyClass class4 = new MyClass();

            Console.WriteLine(class4.Count);        // получаем значение через обьект класса 
            Console.WriteLine(class2.Count);
            Console.WriteLine(MyClass.CountStatic); // получаем значение через класс


        }
    }
}
