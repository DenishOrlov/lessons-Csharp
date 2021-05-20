using System;

namespace Lesson_61_This
{
    /*
     * this.  Даёт возможность получить доступ к текущему экземпляру класса. Когда создали обьект, 
     *        то даже не обращаясь к его имени можем внутри обращаться к полям и методам этого обьекта
     *        
     *        Ключевое слово this используеться когда в конструкторах или методах, или свойствах есть 
     *        неоднозначность в названии переменных, которые принимаем в качестве параметров и наших полей или методов класса
     *        
     * вызов конструктора по цепочке - если нам надо использовать предыдущий конструктор как часть нового конструктора
     */

    class Student
    {
        public Student(string lastName, DateTime birthday) // конструктор с минимальным набором данных для создания обьекта класса
        {
            //lastName = lastName; // вот тут существует неоднозначность. Поле класса так же называется как и параметр в конструкторе
                                   // при отработке кода параметр сам в себя запишет значениеа в поле класса не будет значения
//      this - означет к текущему экземпляру класса  
            this.lastName = lastName;
            this.birthday = birthday;
        }
        //вызов конструктора по цепочке
        public Student(string lastName, string firstName, string middleName, DateTime birthday) : this(lastName, birthday) // вызываем конструктор двумя параметрами, которые определяют конструктор
        {
            this.firstName = firstName;
            this.middleName = middleName;

            //this.lastName = lastName;  вот это часть кода ненужна, потому что эта часть логики отработает в предыдущем конструкторе при вызове этого конструктора.
            //this.birthday = birthday;

        }
        
        private string firstName;
        private string middleName;
        private string lastName;
        private DateTime birthday;

        public void Print()
        {   //                                        здесь не нужно this. потому что однозначно
            Console.WriteLine($"Имя: {firstName}\nФамилия: {lastName}\nОтчество: {middleName}\nДата рождения: {birthday}");
        }
        public void SetNameStudent(string firstName)
        {
            this.firstName = firstName;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // this. не можем использовать в методах с модификатором static. При static - экземпляр класса не создаётся, а this применяется к текущему обьекту класса
            Student student2 = new Student("Вадимов", "Vadim", "Селегерович", new DateTime(1998, 12, 1));

            student2.Print();
           
        }
    }
}