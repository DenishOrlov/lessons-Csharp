using System;

namespace Lesson_54_part_4_enum
{
    /*
     * Конвертируем 
     * 
     */

    class Program
    {
        enum Color
        {
            White,
            Red,
            Green,
            Blue,
            Orange
        }

        static void Main(string[] args)
        {
            var values = Enum.GetValues(typeof(Color));  // Получить все элементы enuma Color/ Enum.GetValues() вернул массив

            foreach (var item in values)
            {
                Console.WriteLine(item);
            }

            string str = Console.ReadLine();

            //у нас enum может быть любого типа, по этому зараннее нужно проверить тип
            Color color = (Color)Enum.Parse(typeof(Color), str, ignoreCase: true); // Создаём новую переменную типа Color и записываем туда значение конвертировав в enum
                                                                                   // Первый аргумент - тип списка typeof(Color). Второй - переменная которую надо преобразовать
            // есть и такой Enum.TryParse                                          // Третий - игнорировать Большие/маленькие буквы
            Console.WriteLine(color);

            // фича автозаполнения swich. автоматом генерирует значения при введении Color в параметр и нажатии левым кликом мышкой в пустой области 

            switch (color)
            {
                case Color.White:
                    break;
                case Color.Red:
                    break;
                case Color.Green:
                    break;
                case Color.Blue:
                    break;
                case Color.Orange:
                    break;
                default:
                    break;
            }

        }
    }
}
