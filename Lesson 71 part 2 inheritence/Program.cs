using System;

namespace Lesson_71_part_2_inheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher1 = new Teacher();
            teacher1.PrintFullName();
            teacher1.Salary = 13000;
            teacher1.Teach();
            Console.WriteLine(teacher1.Salary);

        }
    }
}
