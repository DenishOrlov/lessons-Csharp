using System;

namespace Lesson_60_part_2_overload_Constructor
{
    /*
     * 
     * 
     */
    class Student
    {
        public Student( string lastName, DateTime birthday) // конструктор с минимальным набором данных для создания обьекта класса
        {
            _lastName = lastName;
            _birthday = birthday;
        }
        public Student(string lastName, string firstName, string middleName, DateTime birthday)
        {
            _firstName = firstName;
            _middleName = middleName;
            _lastName = lastName;
            _birthday = birthday;

        }
        public Student(Student student)         // Этот конструктор позволяет скопировать данные класса в новый класс
        {
            _firstName = student._firstName;    // Присваиваем через конструктор полям класса значения из класса передаваемого параметром (Student student) 
            _middleName = student._middleName;
            _lastName = student._lastName;
            _birthday = student._birthday;
        }
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private DateTime _birthday;

        public void Print()
        {
            Console.WriteLine($"Имя: {_firstName}\nФамилия: {_lastName}\nОтчество: {_middleName}\nДата рождения: {_birthday}");
        }
        public void SetNameStudent(string _firstName)
        {
            this._firstName = _firstName;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Вадимов", new DateTime(1998,10,5));
            Student student2 = new Student("Вадимов","Vadim", "Селегерович", new DateTime(1998,12,1));

            Student student4 = student2;  // это скопирует только ссылку на данные в управляемой куче!!! При изменении данных в одном обьекте класса - данные будут меняться и во втором. 

            Student student3 = new Student(student2); // Этот конструктор позволяет скопировать данные из существующего класса в новый

            student2.SetNameStudent("Сергей"); 

            student.Print();
            Console.WriteLine();
            student2.Print();
            Console.WriteLine();
            student3.Print();

        }
    }
}
