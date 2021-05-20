﻿using System;

namespace Lesson_52
{   
    /*
     * Null - совместимые значимые типы  (Nulable) Для того чтоб значимые типы могли хранить null
     * 
     * ? - обозначает, что мы создаём структуру Nulable с полями Value и HasValue
     */ 

    class Program
    {
        static void Main(string[] args)
        {
            string str = null;          // ссылочный тип - присаиваем без проблем

            //int a = null;             // значимый тип - хранит не ссылки а данные, не можем присвоить null
                                        // Зачем надо : например из БД получаем данные имя, фамилия, дата - но этих данных нет. Тогда в ссылочные типы(имя, фамилия) возвращается null а в дату
                                        // Nullable фича может показать значение по дэфолту ли в значимой переменной или изменилось

            DateTime? dataTime = null;  // Так сможем корректно из БД поместить null значние в значимую переменную/ И проверим, что данных нет
        }
    }
}