using System;

namespace Lesson_63_static_field
{
    /*
     * Ключевое слово static
     *      При использовании слова static в оперативной памяти выделяется одна область такого поля на все экзэмпляры класса
     *      То есть меняя значение этого поля в одном из экземпляров класса - оно будет менятся во всех
     *      Это как расшаренное поле для всех экземпляров класса
     * 
     * Статические поля класса
     */
    class MyClass
    {
        public int a;

        public static int b;

        private static int c;               // Private поле не позволит напрямую менять значение из главной функции
                                            // но по прежнему его можно изменять внутри класса с помощью методов и т.д.

        public void SetB(int b)             // Пример метода сеттера, для изменения значения поля static
        {
            MyClass.b = b;                  // Только обращаясь напрямую к классу можно менять значение статик поля
        }

        public void SetC(int c)             // Такой же сеттер, для изменения значения поля private static 
        {
            // this.c = c;                  // Так работать не будет, потому что this - ссылка обьекта класса на себя, а при статике может и не быть обьекта класса
            MyClass.c = c;
        }
        public int C                        // Можно производить доступ через свойства
        {
            get { return c; }
            set { c = value; }
        }

        public void Print()
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass class1 = new MyClass();
            class1.a = 12;                     // Это поле (без static) можно менять напрямую через экземпляр класса (если оно public)

            MyClass class2 = new MyClass();
            class2.a = 22;
            class2.Print();

            MyClass.b = 3;                     // Доступ к статическому полю (если оно public) осуществляется напрямую через обращение к классу, а не к экземпляру класса
                                               // и его значение будет общим для всех экземпляров

            class2.C = 44;                     // Доступ к статической переменной через сеттер и через экземпляр класса. Напомню значение поменяется и для остальных экземпляров

            class1.SetB(55);                   // Запись значение в поле с ключевым словом static
            class1.SetC(66);
            Console.WriteLine();

            class2.Print();
            Console.WriteLine();
            class1.Print();
        }
    }
}
