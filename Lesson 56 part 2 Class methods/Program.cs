﻿using System;

namespace Lesson_56_part_2_Class_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t == Car 1 =="); // первый экземпляр класса Car
            var car1 = new Car();                // создаём экземпляр и выделяем под него место в Озу управляемой куче
            car1.PrintSpeed();                   // Вызываем метод отображения скорости и движения (по дэфолту speed = 0)
            car1.DriveForward();                 // Вызываем метод движения вперёд (путем присвоения в приват переменную speed значения 60)
            car1.PrintSpeed();                   // Вызываем метод отображения скорости и движения
            car1.Stop();                         // Вызываем метод отстановки (путем присвоения в приват переменную speed значения 0)
            car1.PrintSpeed();                   // Вызываем метод отображения скорости и движения

            Console.WriteLine("\t == Car 2 =="); // первый экземпляр класса Car
            var car2 = new Car();                // создаём экземпляр и выделяем под него место в Озу управляемой куче
            car2.PrintSpeed();                   // Вызываем метод отображения скорости и движения (по дэфолту speed = 0)
            car2.DriveBackward();                // Вызываем метод движения назад (путем присвоения в приват переменную speed значения -5)
            car2.PrintSpeed();                   // Вызываем метод отображения скорости и движения
            car2.Stop();                         // Вызываем метод отстановки (путем присвоения в приват переменную speed значения 0)
            car2.PrintSpeed();                   // Вызываем метод отображения скорости и движения

        }
    }
}