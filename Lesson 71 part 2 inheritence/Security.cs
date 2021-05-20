using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_71_part_2_inheritence
{
    class Security:Employee
    {
        public void Guard()
        {
            Console.WriteLine("Охраняю");
        }
    }
}
