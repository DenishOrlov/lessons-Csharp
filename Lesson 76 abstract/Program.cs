using System;

namespace Lesson_76_abstract
{
    /*
     * Полиморфизм
     * 
     * Абстрактный класс      // Нельзя создать экземпляр класса. Он нужен для того что бы быть прототипом
     * 
     * Абстрактный метод      // Абстрактный метод можеть быть только в абстрактном классе. Записывается без реализации, то есть, фигурных скобок
     *                        // Наследники австрактного класса должны реализовать его все абстрактные методы
     * 
     * Абстрактное свойство   // Тоже находится только в абстрактном классе и обязательно нужно реализовать в наследнике
     */
    abstract class Weapon                         // Класс, который описывает лишь идею, а реализация конкретных методов будет в классах-наследниках
    {                                             // Класс используем как контракт, который будут реализовывать его наследнки. Контракт имеится ввиду, что если это оружие- мы должны иметь возможность стрелять
                                                  // Все наследники этого класса тоже должны иметь возможность стрелять
        public abstract int Damage { get; }       // Абстрактное свойство обозначеющее урон

        public abstract void Fire();              // Абстрактный метод. И в нём в принципе не может быть реализации

        public void ShowInfo()                    // У абстрактного метода могут быть и не абстрактные методы. Все дочерние классы тоже будут иметь этот метод
        {
            Console.WriteLine($"{GetType().Name} Damage:{Damage}"); // GetType - это метод типа Object, и мы обращаемся к полю .Name/ К свойству Damage - мы как будто обращаемся через this
        }
    }
    class Gun : Weapon                            // Класс Gun должен унаследовать метод Fire. Контракт - то что обязаны реализовать абстрактный метод
    {
        public override int Damage                // Реализуем свойство, используем слово override
        { 
            get { return 6; } 
        } 
        public override void Fire()               // override в паре с abstract так же переопределяет методы
        {
          //throw new NotImplementedException();  // Эта строчка при попытке вызвать метод Fire выдаст ошибку что мы его не реализовали
            Console.WriteLine("Выстрел");
        }
    }
    class Shootgun : Weapon
    {
        public override int Damage { get { return 9; } }
        public override void Fire()
        {
            Console.WriteLine("Выстрел бах");
        }
    }
    class Pistol : Weapon
    {
        public override int Damage { get { return 4; } }
        public override void Fire()
        {
            Console.WriteLine("Выстрел шут") ;
        }
    }
    class Player
    {
        public void Fire(Weapon weapon)           // Передаём в качестве параметра обьект типа Weapon. Так класс Player сможет стрелять со всего, что унаследует клас Weapon. Это полиморфизм в чистом виде
        {                                         // Обьекты наследники будут иметь тип данных как свой так и тот от которого наследуются Weapon
            weapon.Fire();
        }
        public void CheckInfo(Weapon weapon)       // Добавляем метод проверки инфо об оружии
        {
            weapon.ShowInfo();                    // Обращаемся к экземпляру класса, который передадим при вызове метода player1.CheckInfo()
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();        // Создаём обьект класса
            Gun gun = new Gun();                  // Создаём обьект класса ган 
            player1.Fire(gun);                    // Вызываем метод Fire, в качестве аргумента передаём обьект класса Gun, тип данных у него будет и Gun и Weapon

            Shootgun shotgun = new Shootgun();
            Pistol pistol = new Pistol();
            player1.Fire(pistol);                 // Один игрок может стрелать со всего оружия. Оружие передаём в качестве аргумента
            player1.Fire(shotgun);

            Weapon[] inventory = { new Gun(), new Shootgun(), new Pistol()}; // Массив типа Weapon, в котором находятся экземпляры классов, которые имеют тот же тип(а они его наследуют)
            foreach (var item in inventory)                                  // Перебираем значения массива (то есть экземпляры)
            {
                player1.CheckInfo(item);                                     // Вызываем метод  CheckInfo с аргументом - экземпляром класса
                player1.Fire(item);                                          // Вызываем метод  Fire с аргументом - экземпляром класса
                Console.WriteLine();                                         //
            }
        }
    }
}
