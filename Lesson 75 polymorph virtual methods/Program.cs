using System;

namespace Lesson_75_polymorph_virtual_methods
{   
    /*
     * Полиморфизм
     * 
     *      Для того что бы не модийфицировать каждый раз Person, а использовать имеющийся функционал мы можем использовать полиморфизм и переопределние методов
     *      
     *      В зависимости от того какой класс мы передадим в параметре вызова методжа Drive, от того зависит какую реализацию метода мы вызовем. 
     *      При этом не меняя код класса Person
     *      
     *      Можем переопределять в наследниках метод как угодно: добавлять логику метода, менять старую логику, убирать старую логику, комбинировать старую и новую логику, не меняя Person 
     *      
     *      
     * Виртуальные методы
     * 
     * 
     * virtual 
     * 
     *      Для того что бы иметь возможность переопределить какой-то метод, который находится в базовом классе, у этого метода должен быть модификатор virtual
     *      (их называют виртуальными методами)
     *      
     *      
     * override
     *      Для того что бы переопределить метод в классе наследнике нужно использовать ключ слово override
     */
    class Car
    {
        protected virtual void StartEngine()         // Делаем протект метод для наследования и переопределения
        {
            Console.WriteLine("Двигатель запущен");
        }
        public virtual void Drive()                  // Метод класса, выводит текст
        {
            StartEngine();
            Console.WriteLine("Я машина, я еду");    // Вывод текста
        }
    }
    class Person
    {
        public void Drive(Car car)                   // Метод Drive, куда параметром передаём обьект класса Car, чтоб можно было вызвать метот Drive класса Car
        {
            car.Drive();                             // Вызываем метод у класса Car
        }   
    }
    class SportCar : Car
    {
        protected override void StartEngine()       // Переопределяем метод и вызываем в следующем в этом классе
        {
            Console.WriteLine("Эрон дон");          
        }
        public override void Drive()                // Переопределяем метод
        {
            StartEngine();
            Console.WriteLine("Я еду очень быстро");
        }
    }
    class TruckCar : Car
    {
        public override void Drive()                // Переопределяем метод, просто добавляя функционал
        {
            base.Drive();
            Console.WriteLine("На грузовом авто");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();                   // Создаём обьекты классов
            Person person1 = new Person();
            car1.Drive();

            person1.Drive(car1);                    // Вызываем метод Drive у классы Person, передавая параметр обьект класса Car

            person1.Drive(new Car());               // Сразу создаём обьект класса в параметре, в момент вызова Drive класса person

            person1.Drive(new SportCar());          // Вызываем реализацию метода в классе наследник
        }
    }
}
