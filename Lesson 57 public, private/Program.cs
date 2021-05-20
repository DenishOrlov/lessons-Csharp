using System;
using System.Reflection;

namespace Lesson_57_public__private
{
    /*
     * Модификаторы доступа public и private, для членов класса
     *          они только для поведения класса для внешнего доступа. На внутреннем доступе - ничего не меняется
     * 
     */
    class Point                            // описывает положение точки на координат.
    {
        int z = 3;                         // если не указываем модификатор доступа, то по умолчанию он private
        public int x = 1;                  // для внешнего использования кто хочет и как хочет

        private int y = 44;                // для личного использования класса. Можем добираться до неё по средствам методов внутри этого класса

        private void PrintX()              // в private не можем добраться из другого класса напрямую
        {
            Console.WriteLine($"X: {x}");
        }
        public void PrintY()
        {
            Console.WriteLine($"Y: {y}");
        }
        public void PrintPoint()           // через этот метод можем добраться до private метода PrintX(), котрый не доступен напрямую из другого класса
        {
            PrintX();
            PrintY();
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            point.PrintY();                // обращаемся через этот метод к переменной privat y
            point.x = 23;
            point.PrintPoint();

            var typeInfo = typeof(Point).GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public); // возвращает результат - массив обьектов fieldinfo (полях описанных в нашем классе)
            foreach (var item in typeInfo)
            {   // выводим          имя полей         и состояение полей (в данном случе модификаторы) булевым типом true/false 
                Console.WriteLine($"{item.Name}\t IsPrivate: {item.IsPrivate}\t IsPubic {item.IsPublic}");
            }
        }
    }
}
