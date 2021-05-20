using System;

namespace Lesson_77_interfaces_part_2
{
    /*
     * 
     */
    interface IHasInfo                                      // Добавляем интерфейс
    {
        void ShowInfo();                                    // Добавляем метод в интерфейсе
    }

    interface IWeapon                                       // Создаём новый интерфейс после создания класса Weapon (этот класс полностью соответствует контракту интерфейса) 
    {                                                       // Этот интерфейс сделан чтоб охватить больше типов оружия например огнестрел и холодное.
                                                            // У этих типов будет метод чтоб наснести урон и значение урона
        int Damage { get; }                                 // Определяем свойство 
        void Fire();                                        // Определяем метод
    }
    abstract class Weapon : IHasInfo, IWeapon               // Наследуемся от интерфейса, чтоб получить метод ShowInfo / Множественное наследование
    {                                                       // Класс нужен для того, чтоб например нести контракты (абстрактные методы и свойства) огнестрельного оружия
        public abstract int Damage { get; }                 // Определяем свойство
        public abstract void Fire();                        // Определяем метод выстрела
        public void ShowInfo()                              // Переопределяем метод, заполняем его логикой
        {
            Console.WriteLine($"Weapon: {GetType().Name}  Damage: {Damage}");
        }
    }
    class Gun : Weapon
    {
        public override int Damage { get{return 10;} }      // Переопределение абстрактного метода 
        public override void Fire() 
        {
            Console.WriteLine("Выстрел");
        }
    }
    class Shootgun : Weapon
    {
        public override int Damage { get { return 7; } }
        public override void Fire()
        {
            Console.WriteLine("Выстрез Бах");
        }
    }
    class Pistol : Weapon
    {
        public override int Damage { get{ return 4; } }
        public override void Fire()
        {
            Console.WriteLine("Выстрел Пух");
        }
    }
    class Player
    {
        public void Fire(IWeapon weapon)         // Было Weapon стало IWeapon, потому что сделали интерфейс, и теперь аргументом будет тип данных IWeapon
        {                                        // Сделано для того что бы охватить все типы оружия, огнестрел, холодное, лазерное и т.д.
            weapon.Fire();                       // Выстрел игрока из переданного оружия
        }
        public void CheckInfo(IHasInfo hasInfo)  // С помощью такой реализации мы можем через класс Player вызвать информацию о любом обьекте, наследованном от IHasInfo
        {
            hasInfo.ShowInfo();
        }
    }
    class Box : IHasInfo
    {
        public void ShowInfo()                   // Когда реализуем метод интерфейса - не надо писать override
        {
            Console.WriteLine("Коробка");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            player.CheckInfo(new Box());          // Вызываем метод у класса Player с параметром - обьекта нового класса, наследованого от IHasInfo

            Weapon[] inventory = { new Gun(), new Shootgun(), new Pistol() };
            foreach (var item in inventory)
            {
                //item.ShowInfo();                // Вызываем метод, внутри у каждого типа оружия

                player.Fire(item);                // Вызываем метод Fire через класс Player 
                player.CheckInfo(item);           // Вызываем метод проверки информации ShowInfo через метод CheckInfo класса Player

            }
        }
    }
}
