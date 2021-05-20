using System;

namespace Lesson_74_protected
{
    /*
     * Модификатора доступа protected при наследовании 
     *      На уровне доступа через экземпляр класса поле protected будет не доступно так же как и private
     *      Protected так же доступен внутри класса как и private. Снаружи класса так же не доступен как и private
     *      В наследние protected доступен, а private - нет
     *      
     *      Protected даёт возможность в базовом классе инкапсулировать логику, чтоб использовать в классе наследнике без возможности сломать
     */

    class A
    {
        public int publicField;
        private int privateField;
        protected int protectedField;
        

        public A()
        {
            Console.WriteLine(publicField);      // Поле доступно
            Console.WriteLine(privateField);     // Поле доступно
            Console.WriteLine(protectedField);   // Поле доступно
        }

        protected int[] RandArr(int a, int b = 0)
        {
            int[] arr = new int[a];  
            Random rand = new Random();
            for(int i = 0; i < a; i++)
            {
                arr[i] = rand.Next(10);
            }
            return arr;
        }
    }
    
    class B : A                                  // проверяем доступ к полям родительского класса из дочернего
    {
        private int[] RandomArray { get; set; }  // Свойство для массива
        public B()                               // Конструктор класса
        {
            Console.WriteLine(++publicField);    // Поле доступно
            //Console.WriteLine(privateField);   // Поле не доступно из потомка, но оно есть
            Console.WriteLine(++protectedField); // Поле доступно в наследнике

            Console.Clear();
            Console.WriteLine("Введите длинну массива");
            int length = int.Parse(Console.ReadLine());
            RandomArray = RandArr(length);       // Генерим массив и записываем в свойство

        }
        public void ShowArr()
        {
            for (int i = 0; i < RandomArray.Length; i++)
            {
                
                Console.Write(RandomArray[i] +"\t");
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine(a.publicField);      // Поле доступно
            //Console.WriteLine(a.privateField);   // Поле не доступно
            //Console.WriteLine(a.protectedField); // Поле не доступно

            B b = new B();
            b.ShowArr();
            b.publicField = 12;
        }
    }
}
