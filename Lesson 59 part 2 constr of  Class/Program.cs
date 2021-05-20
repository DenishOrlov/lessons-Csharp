using System;

namespace Lesson_59_constr_of__Class
{
    /*
     
     * Конструктор с параметром  - всегда есть у любого класа и будет, если мы не написали свой
     */


    class Gun                                           // класс - наша крупнокалиберная пушка/ У него есть состояние(поля класса(переменные)) и поведение(методы)/
    {

        public Gun(bool isLoaded)                       //  Конструктор с параметром
        {                                               // 
                                                        // 
            this._isLoaded = isLoaded;                  // this - означет, что обращаемся к переменной - поле класса
        }

        private bool _isLoaded;                         // это поле отвечает за готовность орудия (заряженность) | это поле тоже спарятали

        private void Reload()                           // спрятали этот метод, и снаружи класса мы его не можем использовать
        {
            Console.WriteLine("Заряжаю...");

            _isLoaded = true;

            Console.WriteLine("-Заряжено-");
        }
        public void Shoot()
        {
            if (!_isLoaded)                             // проверяем состояние заряженности пушки
            {
                Console.WriteLine("__Орудие не заряжено__");
                Reload();
            }
            Console.WriteLine("^^^^Выстрел^^^^");
            _isLoaded = false;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun(isLoaded: false);          // Создаём новый обьект класса Gun и обязательно указываем параметр? можем указывать явно
            gun.Shoot();                                 // Нас интересует только выстрел, а какие операции она внутри выполняет чтоб произвести выстрел - нам не интересно

        }
    }
}
