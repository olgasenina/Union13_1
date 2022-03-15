using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Union13_1
{
    class Program
    {
        /// <summary>
        /// Наша задача — сравнить производительность вставки в List и LinkedList.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Сравниваем производительность вставки в List<T> и LinkedList<T>");

            // читаем весь файл в строку текста
            string text = File.ReadAllText("C:\\_МОЯ\\File_Unit13\\Text1.txt");

            Console.WriteLine();
            Console.WriteLine("Работает List<T>:");
            UseList(text);

            Console.WriteLine();
            Console.WriteLine("Работает LinkedList<T>:");
            UseLinkedList(text);

            Console.ReadLine();
        }

        /// <summary>
        /// Сохраняем содержимое файла в List
        /// </summary>
        /// <param name="text">Текст из файла</param>
        static void UseList(string text)
        {
            var words = new List<string>();

            // запускаем таймер
            var stopWatch = Stopwatch.StartNew();

            // записываем в коллекцию List<T>
            words.Add(text);

            // смотрим, сколько операция заняла, в миллисекундах
            Console.WriteLine(stopWatch.Elapsed.TotalMilliseconds);
        }

        /// <summary>
        /// Сохраняем содержимое файла в LinkedList
        /// </summary>
        /// <param name="text"></param>
        static void UseLinkedList(string text)
        {
            var words = new LinkedList<string>();

            // запускаем таймер
            var stopWatch = Stopwatch.StartNew();

            // записываем в коллекцию List<T>
            words.AddLast(text);

            // смотрим, сколько операция заняла, в миллисекундах
            Console.WriteLine(stopWatch.Elapsed.TotalMilliseconds);
        }
        
    }
}
