using System;

namespace Lesson_79_explicit_implementation_interface
{
    /*
     * Явная реализация интерфейсов    
     *      Для того что бы у каждого интерфейса(с одинаковыми методами) в одном и том же классе(который реализует эти интерфейсы) вызывался разный код
     *      
     *      Вопрос на собеседовании. Может ли класс реализовать два интерфейса у которых обьявлено два одинаковых метода? 
     *      
     *      Заметил, что реализуемый класс ссылается на оба метода в двух интерфейсах
     *      
     */
    
    interface IFirstInterface
    {
        void Action();

    }
    interface ISecondInterface
    {
        void Action();
    }
    class MyClass : IFirstInterface, ISecondInterface
    {
        public void Action()                                    // Просто реализуем метод интерфейсов класса
        {
            Console.WriteLine("Интерфейс Action()");            // Два раза выведется это сообщение
        }
    }
    class MyOtherClass : IFirstInterface, ISecondInterface
    {
        void IFirstInterface.Action()                           // Явная реализация метода интерфейса IFirstInterface.
        {
            Console.WriteLine("MyOtherClass\t IFirstInterface.Action()");
        }
        void ISecondInterface.Action()                          // Явная реализация метода интерфейса ISecondInterface
        {
            Console.WriteLine("MyOtherClass\t ISecondInterface.Action()");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            MyClass myClass = new MyClass();
            
            Foo(myClass);
            Bar(myClass);

            MyOtherClass myOtherClass = new MyOtherClass();              // Создаём экземпляр класса. Он реализует два интерфейса, то этому может иметь оба типа данных
            Foo(myOtherClass);                                           // Этот класс с явно определённой реализацией интерфейсов. 
            Bar(myOtherClass);                                           // Вызываем методы передавая параметром экземпляр класса, где явно реализованы оба метода интерфейсов 

            IFirstInterface firstInterface = myOtherClass;               // Если у нас есть интерфейс, то мы можем в ссылку присвоить экземпляр класса наследника
            firstInterface.Action();
            // Вызвать нужный метод вместо конструкции высше
            ((IFirstInterface)myOtherClass).Action();                    // Привели данные к типу IFirstInterface и вызвали метод Action
            ((ISecondInterface)myOtherClass).Action(); 


            //if (myOtherClass is IFirstInterface )

        }


        static void Foo(IFirstInterface firstInterface)                   // Передаём параметром обьект типа (или ссылку) IFirstInterface, по этому вызывается именно его реализация
        {
            firstInterface.Action();                                      // Вызываем метод Action() у обьекта типа IFirstInterface
        }
        static void Bar(ISecondInterface secondInterface)                 // Передаём параметром обьект типа данных ISecondInterface
        {
            secondInterface.Action();                                     // Вызываем метод Action() у обьекта типа ISecondInterface
        
    }
}
