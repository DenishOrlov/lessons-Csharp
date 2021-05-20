using System;

namespace Lesson_78_multiple_inheritance
{
    /*
     *  Множественное наследование
     */

    interface IWeapon                                    // Создаём интерфейс под оружие 
    {
         void Fire();                                    // Определяем метод выстрела
    }
    interface IThrowingWeapon : IWeapon                  // Создаём интерфейс метательного оружия/ Он наследуется от Iweapon, по этому следуемый класс должен реализовать методы обоих интерфейсов
    {
        void Throw();                                    // Метод метания оружия
    }
    class Gun : IWeapon                                  // Сосздаём класс пушки
    {
        public void Fire()
        {
            Console.WriteLine($"{GetType().Name}: Бах");
        }
    }
    class LaserGun : IWeapon                              // Создаём класс лазерного оружия
    {
        public void Fire()
        {
            Console.WriteLine($"{GetType().Name}: Пиу");
        }
    }
    class Knife : IThrowingWeapon                         // Создаём класс ножа и реализуем методы интерфейсов
    {
        public void Fire()
        {
            Console.WriteLine($"{GetType().Name}: Хыщ");
        }
        public void Throw()
        {
            Console.WriteLine($"{GetType().Name}: Фьють");
        }
    }

    class Player                                            // Реализуем методы разного типа оружия, с помошью новых интерфейсов
    {
        public void Fire(IWeapon weapon)
        {
            weapon.Fire();
        }
        public void Throw(IThrowingWeapon throwingWeapon)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            IWeapon[] inventory = { new Gun(), new LaserGun(), new Knife()};

            foreach(var item in inventory)
            {
                player.Fire(item);
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
