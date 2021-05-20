using System;

namespace Lesson_51_chacked_unchecked
{   
    /*
     * "Ядерный Ганди"  и арифметическое переполнение данных
     * 
     * Можно на уровне проекта включить проверку таких ошибок: правой клавишей на проекте(внутри решения)-> Сборка -> Кнопка "Дополнительно" -> Включить проверку арифметического переполнения
     * 
     * ключевое слово checked и unchecked
     * 
     */

    class Program
    {
        static void Main(string[] args)
        {
            byte aggression = 1;

            byte democracyModifier = 2;
            
            //byte      преобр.        int - int                (операция вычитания производится над интами, по этому надо преобразовать обратно. byte в int для вычитания преобразует неявно.
            aggression = (byte)(aggression - democracyModifier); // сужающее преобразование данных/ значение будет отрицательное ( не входит в область значений byte)
                                                                 // по этому при преобразовани в byte, для хранения в переменнй aggression
                                                                 // данные ПЕРЕПОЛНЯТСЯ через нижнюю границу и будет максимальное значение типа byte
            Console.WriteLine(aggression);

            int a = int.MaxValue;
            a = a + 1;                                           // переполнение через верхнюю границу
            Console.WriteLine(a);                                // в переменной окажется минимально допустимое значение int


            int b = int.MinValue;
            b = b - 1;                                           // переполнение через нижнюю границу
            Console.WriteLine(b);                                // в переменной окажется максимально допустимое значение int. То есть по кругу


            aggression = checked((byte)(aggression - democracyModifier)); // проверка на арифметическое переполнение

            checked                                                       // проверка на арифметическое переполнение, все операции внутри фигурных скобок
            {
                aggression = (byte)(aggression - democracyModifier);
            }

            unchecked                                                     // если на всём проекте включена проверка переполнения, внутри фигурных скобок - не будет выполнятся
            {

            }


            Console.WriteLine(aggression);



        }
    }
}
