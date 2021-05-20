using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_71_part_2_inheritence
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void PrintFullName()
        {
            Console.WriteLine($"Имя: {FirstName}\tФамилия: {LastName}");
        }
    }
}
