using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Tracing;

namespace Task13_6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            LinkedList <string> linkedlist = new LinkedList<string>();

            // читаем весь файл в строку текста
            string text = File.ReadAllText("D:\\Андрей\\Программирование\\C#\\SF\\Task13.6.1\\Task13.6.1\\Text1.txt");

            // Сохраняем символы-разделители в массив
            char[] delimiters = new char[] { ' ', '\r', '\n' };

            // разбиваем нашу строку текста, используя ранее перечисленные символы-разделители
            var words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            // Запустим таймер
            var watchlist = Stopwatch.StartNew();

            // Вставка элементов в List
            foreach (var word in words) 
            {
                list.Add(word);
            }

            // Выведем результат
            var timelist = watchlist.Elapsed.TotalMilliseconds;
            Console.WriteLine($"Вставка в List: {timelist}  мс");

            // Остановим таймер
            watchlist.Stop();

            // Запустим таймер
            var watchlinkedlist = Stopwatch.StartNew();

            // Вставка элементов в LinkedList
            foreach (var word in words)
            {
                linkedlist.AddLast(word);
            }

            // Выведем результат
            var timelinkedlist = watchlist.Elapsed.TotalMilliseconds;
            Console.WriteLine($"Вставка в LinkedList: {timelinkedlist}  мс");

            // Остановим таймер
            watchlinkedlist.Stop();

            // Вывод результата замера
            Console.WriteLine($"Вставка в List быстрее LinkedList в {(timelinkedlist / timelist).ToString("0.00")} раз");
            Console.ReadKey();  
        }
    }
}