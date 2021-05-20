using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_55_part_2_Classes
{
    class Student                   // выносим класс в отдельный файл
    {
        public Guid id;             // Guid - специальная структура для создания уникальных id
        public string firstName;
        public string lastName;
        public string middleName;
        public int age;
        public string group;
        
    }
}
