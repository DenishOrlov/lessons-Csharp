using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_56_part_2_Class_methods
{
    class Car
    { 
        private int speed = 0;   // private - на уровне экзэмляра к такому полю доступ не имеем
        public void PrintSpeed()
        {
            if (speed == 0)
            {
                Console.WriteLine("Стоим на месте...");
            }
            if (speed > 0)
            {
                Console.WriteLine($"Едем вперёд со скоростью {speed} км\\ч");

            }
            if (speed < 0)
            {
                Console.WriteLine($"Едем назад со скоростью {-speed} км\\ч");
            }

        }
        public void DriveForward() // метод устанавливает значение поля speed в 60
        {
            speed = 60;
        }
        public void Stop()          // метод устанавливает значение поля speed в 0
        {
            speed = 0;
        }
        public void DriveBackward()// метод устанавливает значение поля speed в -5
        {
            speed = -5;
        }
    }
}
