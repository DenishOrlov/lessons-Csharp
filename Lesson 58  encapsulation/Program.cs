using System;

namespace Lesson_58__encapsulation
{   
    /*
     *   Инкапсуляция
     *      Позволяет нам делать такой класс, чтоб его использовали так как я задумал, использовать правило
     *      
     *      Суть инкапсуляции в том, что мы скрываем состояние обьекта, защищаем его от внешнего мира и можем менять это состояния 
     *      только с помощью методов этого же обьекта (public метода в данном случае)
     *      
     *      
     */
    class Gun                                       // класс - наша крупнокалиберная пушка/ У него есть состояние(поля класса(переменные)) и поведение(методы)/
    {
        private bool isLoaded;                      // это поле отвечает за готовность орудия (заряженность) | это поле тоже спарятали

        private void Reload()                       // спрятали этот метод, и снаружи класса мы его не можем использовать
        {
            Console.WriteLine("Заряжаю...");

            isLoaded = true;

            Console.WriteLine("-Заряжено-");
        }
        public void Shoot()
        {       
            if (!isLoaded)                            // проверяем состояние заряженности пушки
            {
                Console.WriteLine("__Орудие не заряжено__");
                Reload();
            }
            Console.WriteLine("^^^^Выстрел^^^^");
            isLoaded = false;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun();                      // Создаём новый обьект класса Gun
            gun.Shoot();                              // Нас интересует только выстрел, а какие операции она внутри выполняет чтоб произвести выстрел - нам не интересно
           
        }
    }
}
