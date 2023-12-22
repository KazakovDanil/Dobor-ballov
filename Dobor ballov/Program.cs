using System;
using System.Collections.Generic;
using System.Linq;

namespace Dobor_ballov
{
    internal class Program
    {
        static string Make_a_necklace(int value)
        {
            if (value > 0 && value % 2 != 0)
            {
                string line = "";
                for (int i = 1; i <= value; i += 2)
                {
                    line += new string(' ', (value - i) / 2) + new string('*', i) + "\n";
                }

                for (int i = value - 2; i >= 1; i -= 2)
                {
                    line += new string(' ', (value - i) / 2) + new string('*', i) + "\n";
                }
                return line;
            }
            else
            {
                return null;
            }
        }
        static string[] Sort_by_length(string[] words)
        {
            IEnumerable<string> words_sort = from word in words orderby word.Length select word;
            return words_sort.ToArray();
        }
        static void Main(string[] args)
        {
            // Задача 1
            // Эта программа с помощью звездочек нарисовать ромб (ожерелье) и вывести на экран
            Console.WriteLine("Эта программа с помощью звездочек нарисовать ромб (ожерелье) и вывести на экран");
            Console.Write("Введите размер бриллиантовой нити: ");
            if (int.TryParse(Console.ReadLine(), out int value)) 
            {
                Console.WriteLine(Make_a_necklace(value));
            }
            else
            {
                Console.WriteLine("Вы ввели не целое число нити");
            }
            // Задача 2
            // Эта программа сортирует массив по длинне ее элементов
            Console.WriteLine("Эта программа сортирует массив по длинне ее элементов");
            string[] words = { "Telescopes", "Glasses", "Eyes", "Monocles" };
            string[] sorted_words = Sort_by_length(words);
            for (int i = 0; i < sorted_words.Length; i++)
            {
                Console.WriteLine(sorted_words[i]);
            }
            // Задача 3
            // Эта программа расширяет функциональность класса array
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Квадрат: " + string.Join(", ", numbers.Square()));
            Console.WriteLine("Куб: " + string.Join(", ", numbers.Cube()));
            Console.WriteLine("Среднее значение: " + numbers.Average());
            Console.WriteLine("Сумма: " + numbers.Sum());
            Console.WriteLine("Четное: " + string.Join(", ", numbers.Even()));
            Console.WriteLine("Нечетное: " + string.Join(", ", numbers.Odd()));
            Console.ReadKey();
        }
    }
}
