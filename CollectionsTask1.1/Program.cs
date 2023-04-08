using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsTask1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь до текстового файла");
            
            string path = Console.ReadLine();
            
            string text = File.ReadAllText(path);            

            char[] delimiters = new char[] { ' ', '\r', '\n', '\t' };

            var words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            
            var book2 = new LinkedList<string>(words);

            var watchTwo = Stopwatch.StartNew();

            book2.AddAfter(book2.First, "Вставка");

            Console.WriteLine($"Вставка в  книгу: {watchTwo.Elapsed.TotalMilliseconds}  мс");
        }
    }
}
