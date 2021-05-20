using System;

namespace Lesson_51_part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte aggression = 1;

            byte democracyModifier = 2;
            try
            {
                aggression = checked((byte)(aggression - democracyModifier)); // проверяем на переполнение. Если переполнен - то ошибка, но отшибку мы отлавливаем
                Console.WriteLine(aggression);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка переполнения");
                
            }

            // переполнение с дробным типом данных
            // для float и double никогда не бывает арифметического переполнения данных

            double a = 1.0 / 0.0;
            Console.WriteLine(double.IsInfinity(a));     // проверка на бесконечность  будет True

            double b = 0.0 / 0.0;                       
            Console.WriteLine(double.IsNaN(b));          // проверка на нот э намбе   будет True

            double с = double.MaxValue + double.MaxValue;
            Console.WriteLine(double.IsInfinity(с));     // будет True


            // арифметическое переполнение decimal всегда выдаст исключение

            decimal f = decimal.MaxValue;
            decimal d = decimal.MaxValue;
            decimal g = unchecked(f+d); // всё равно выдаст ошибку, потому что decimal используеся для хранения финансовых данных (денежек)



        }
    }
}
