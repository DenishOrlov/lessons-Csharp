using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_67_Students;

namespace Lesson_67_Extensions
{
    static class MyExtensions
    {
        public static string GetFullName(this Student student) // Делаем расширенный метод типа string для класса Student
        {
            return student.LastName + " " + student.FirstName; // Возврщаем строку собранную из двух полей, которые взяли из класса Student
        }
    }
}
