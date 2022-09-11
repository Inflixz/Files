using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Interaction
    {
        /// <summary>
        /// Принимает число
        /// </summary>
        /// <returns></returns>
        public int TakeNumber()
        {
            int result;
            string input = Console.ReadLine();
            while (!int.TryParse(input, out result))
            {
                Console.WriteLine("Ошибка. Введите цифру:");
                input = Console.ReadLine();
            }
            return result;
        }
        /// <summary>
        /// Принимает текст
        /// </summary>
        /// <returns></returns>
        public string TakeText()
        {
            string result = Console.ReadLine();
            return result;
        }
        /// <summary>
        /// Выводит текст WriteLine
        /// </summary>
        /// <param name="text"></param>
        public void ShowTextWriteLine(string text)
        {
            Console.WriteLine($"{text}");
        }
        /// <summary>
        /// Выводит текст Write
        /// </summary>
        /// <param name="text"></param>
        public void ShowTextWrite(string text)
        {
            Console.Write($"{text}");
        }
        /// <summary>
        /// Отчиситка
        /// </summary>
        public void Clear()
        {
            Console.Clear();
        }
    }
}
