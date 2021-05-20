﻿using System;

namespace Lesson_68_partial
{   
    /*
     * Частичные типы
     * 
     * partial классы  Позволяет код такого класса разнести в разные файлы. То есть разбить класс на части. При компиляции он всё равно будет цельный.
     *                 Приминяется редко. Не используется если очень большой класс и тяжело в нём ориентироваться, то если разбить его на файлы, будет хуже.
     *                 Используеться, если часть класса генерируется автоматом в отдельном файлею
     * 
     * partial методы  Например для того что бы обозначить в классе, где нет реализации этого метода, что где то этот метод есть
     */
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Иван", "Ураган"); // Создаём экземпляр класса
            person1.PrintFullName("Андреевич");            // Вызываем метод класса, который находится в другом файле составного класса

            Console.WriteLine(person1.AddText("template"));// Вызываю частичный метод
        }
    }
}
