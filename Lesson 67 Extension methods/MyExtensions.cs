using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExtens                                                                  // разделяем пространство имён чтоб не засорять
{
    static class MyExtensions
    {  
        public static string statDatTime;                                           // Поле класса для меня
        public static string statDayWeek;                                           // Поле класса для меня

        /* 
            public для того что бы был доступен вне класса
            static - по условию метода расширения
            Особенность в параметрах, которые принимает exten метод - мы указываем 
         */

        // что бы указать что метод расширяет именнно тот класс что нам надо, в параметрах передаём (this_тип данных_ название переменной)

        public static void Print(this DateTime dataVariable)                        // Метод принт для вывода текущей даты и время на консоль
        {
            Console.WriteLine(dataVariable);    
        }

        // первым параметром всегда идёт this и тот тип данных для которого пишем метод расширения, и у которого он будет вызываться
        // первый параметр dateTime мы не увидим в подсказке
        public static bool IsDayOfWeek(this DateTime dateTime, DayOfWeek dayOfWeek) // в качестве параметров берём энам DayOfWeek структуры DateTime и переменную dayOfWeek
        {       
            statDatTime = dateTime + "";                                            // Вернёт дату и время и я это конвертирую в строку из типа данных DateTime
            statDayWeek = dayOfWeek + "";                                           // Вернёт дату и время и я это конвертирую в строку из типа данных DateTime

            return dateTime.DayOfWeek == dayOfWeek;                                 // Сравниваем текущий день недели и переданный из вызова, и возвращаем булевое значение. Тип DateTime. 
        }
    }
}
