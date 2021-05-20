using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Lesson_77_interfaces
{
    /*
     * Интерфесы и полиморфизм 
     *      
     *      Интерфейсы имеют только абстрактные методы и никакой реализации в классе
     *      
     *      Задачей интерфейса является определить контракт и то как себя будут вести наследники. Без конкретных деталей 
     *      (С помощью интерфейса мы определяем поведение, которое реализуем в конкретном классе)
     *      
     *      Интерфейсы могут наследовать друг друга, и классы могут наследоваться от нескольких интерфейсов.
     *      
     *      Правильно говорить классы не наследуются, а реализуют интерфейсы
     *      
     *      Интерфейс - это не класс и в нём не может быть конструкторов, полей класса, нельзя сделать экземпляр класса. Но могут быть методы и свойства(так как это тоже метод маскирующийся под переменную)
     *      
     *      По умолчанию все методы интерфейса - public
     *      
     *      Ссылка интерфейса может хранить обьект любого типа данных наследника
     *      
     *      Если реализуем интерфейс, то реализуем все его компоненты
     *      
     *      Пишем реализацию программы с помошью интерфесов. У нас есть данные которые можем получать из БД, но может быть прийдётся получать по HTTP запросу, а может из файла.
     *      Для того что бы не переписывать логику программы мы делаем реализацию с помощью интерфейсов.
     */
    interface IDataProvider                                 // Определяем поведение. Создаём интерфейс класса получения данных
    {
        string GetData();                                   // Метод интерфеса для получения данных 
    }

    interface IDataProcessor                                // Интерфейс обработки данных
    {
        void ProcessData(IDataProvider dataProvider);       // Метод обработки данних
    }

    class ConsoleDAtaProcessor : IDataProcessor             // Создаём класс реализуя интерфейс обработки данных
    {
        public void ProcessData(IDataProvider dataProvider) // Реализуем метода интерфейса ProcessData из interface IDataProcessor
        {
            Console.WriteLine(dataProvider.GetData());      // Вызываем метод GetData() у обьекта dataProvider типа данных IDataProvider, в который передадим параметром обьект класса наследника 
        }
    }
    class DBDataProvider : IDataProvider                    // Реализуем интерфейс полчения данных IDataProvider в классе
    {
        public string GetData()                             // Переопределяем метод интерфейса
        {
            return "Данные из Базы Данных";                 // Возвращаем значение- заглушку
        }
    }
    class FileDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Данные из Файла";
        }
    }
    class APIDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Данные из API";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IDataProcessor dataProcessor = new ConsoleDAtaProcessor();      // Создаём обьект класса обработки данных и записываем его в ссылку IDataProcessor
            dataProcessor.ProcessData(new DBDataProvider());                // Вызываем метод ProcessData() с параметром - созданным обьектом класса
            dataProcessor.ProcessData(new FileDataProvider());              // Вызываем метод ProcessData() с параметром - созданным обьектом класса
            dataProcessor.ProcessData(new APIDataProvider());               // Вызываем метод ProcessData() с параметром - созданным обьектом класса
        }
    }
}
