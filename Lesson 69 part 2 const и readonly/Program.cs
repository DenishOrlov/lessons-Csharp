using System;

namespace Lesson_69_part_2_const_и_readonly
{   
    /*
     * Пример использования переменных статик
     * 
     *  Три уровня логирования Info Error Warning
     * 
     * 
     */
        
    class MyLogger                                                                      // Класс с уровнями сообщений
    {
        public void Info(string message)
        {
            Console.WriteLine($"Time: {DateTime.Now}\t|Info|\t{message}");
        }
        public void Warning(string message)
        {
            Console.WriteLine($"Time: {DateTime.Now}\t|Warn|\t{message}");
        }
        public void Error(string message)
        {
            Console.WriteLine($"Time: {DateTime.Now}\t|Error|\t{message}");
        }

    }
    class Car
    {
        private static string ERROR_DRIVE = "Сначала заведи двигатель";                // Константы с сообщениями
        private static string ENGINE_STARTED = "Двигатель запущен";
        private static string ATTEMPT_START_ENGINE = "Завожу двигатель";
        private static string ENGINE_ALREADY_STARTED = "Запущен уже этот двигатель";
        private static string CAR_PREPEARED_TO_DRIVE = "Дави на газ";
        private static string CAR_TO_DRIVE = "Поехали";

        private readonly MyLogger _myLogger;                                            // Создаём поле типа класса MyLogger и он меняться не будет
                                                                                        // Это сервис который класс Car будет использовать под свои нужды

        private bool isEngineStarted;                                                   // Создаём поле с значением запущен ли двигатель

        public Car(MyLogger myLogger)                                                   // Конструктор с параметром, аргумент - тип данных MyLogger
        {
            _myLogger = myLogger;                                                       // Записываем в переменную передаваемый параметр при создании экземпляра
        }

        public void StartEngine()                                                       // Метод запуска двигателя
        {
            _myLogger.Info(ATTEMPT_START_ENGINE);                                       // Вызываем метод Info с параметром - строкой
            if (isEngineStarted)                                                        // Проверяем запущен ли двигатель
            {
                _myLogger.Warning(ENGINE_ALREADY_STARTED);                              // Ошибка если двигатель запущен
            }
            else
            {
                isEngineStarted = true;                                                 // Приваиваем тру, и пишем сообщение, чо заведён двигатель
                _myLogger.Warning(ENGINE_STARTED);
            }
        }

        public void Drive()                                                             // Метод драйв
        {
            _myLogger.Info(CAR_PREPEARED_TO_DRIVE);                                     // Сообщение попытки поехать
            if (isEngineStarted)
            {
                _myLogger.Info(CAR_TO_DRIVE);                                           // Если двигатель запущен - выводим поехали
            }
            else
            {
                _myLogger.Error(ERROR_DRIVE);                                           // Если не запущен - ошибка
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(new MyLogger());
            Car car2 = new Car(new MyLogger());
            car1.StartEngine();
            car1.Drive();
            Console.WriteLine();
            car2.Drive();
            car2.StartEngine();
            car2.Drive();



        }
    }
}
