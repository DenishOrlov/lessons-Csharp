using System;

namespace Lesson_60_overload_Constructor
{   
    /*
     *  Перегрузка конструкторов класса - наличие более одного конструктора. Благодаря перегрузке можем сконструировать обьект одного класса по разному.
     *  
     *      При создании собственного конструктора, конструктор по умолчанию никуда не девается, но его нужно указать явно,
     *      что будет перегрузкой конструктора, но и нормас.
     *              
     */

    class Point
    {
        public Point()
        {
            _x = _y = 1;
        }
        public Point(int x, int y) // обязательно использовать модификатор доступа
        {
            _x = x;
            _y = y;
        }
        private int _x;
        private int _y;

        public void Print()
        {
            Console.WriteLine($"X: {_x}\tY: {_y}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(3,5); // Point() - конструктор по усолчанию
            Point point2 = new Point();
            point.Print();
            point2.Print();
        }
    }
}
