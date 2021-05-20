using System;

namespace Lesson_49_part_2
{   
    /*
     * 
     * Пример использования Рекурсии при отображении на консоль сохранённых данных 
     * (скорее всего односвязног списка)
     */

   
    class Program
    {
        class Item // клас Item состоит из двух полей ( то есть из двух переменных? из которых будет состоять новый обьект класса Item, когда его создадим)
        {
            public int Value { get; set; } // здесь будет храниться информация, которая конкретно в текущем элементе будет находится
            public Item Child { get; set; } // второе поле - тоже обьект Item ( обьект нашего класса, который сейчас же и описываем, то есть включает сам себя)
                                            // можем иметь цепочку вложенных обьектов
        }

        static Item InitItem() //метод InitItem, который возвращает обьект класса Item
        {
            return new Item()
            {
                Value = 5, // Item значение в котором будет 5
                Child = new Item() // а его полю Child присваиваем ещё один обьект класса Item
                {
                    Value = 10, // Item значение в котором будет 10
                    Child = new Item() // а его полю Child присваиваем ещё один обьект класса Item
                    {
                        Value = 2 // Item значение в котором будет 2
                    }
                }
            };
        }
        static void Print (Item item) // параметром передаём обьект класса Item
        {
            if (item != null) // проверка на наличие подобьекта Child
            {
                Console.WriteLine(item.Value);//выводим значение
                Print(item.Child); // берём параметр Child и вызываем метод с ним, так как это обьект класса Item
            }
            
        }
        static void Main(string[] args)
        {
            Item item = InitItem(); // вся цепочка присваивается в переменную item
            //Print(item);

            //Реализация с помощью цикла, перебора обьекта Item
            for (Item i = item; i != null; i = i.Child) //Item i = item начальное Value/ i != null - проверка на наличие Child/ i = i.Child присваиваем следующее вложенное значение
            {
                Console.WriteLine(i.Value);
            }


        }
    }
}
