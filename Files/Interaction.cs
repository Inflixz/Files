using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Interaction
    {
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
        public string TakeText()
        {
            string result = Console.ReadLine();
            return result;
        }
        public void ShowTextWriteLine(string text)
        {
            Console.WriteLine($"{text}");
        }
        public void ShowTextWrite(string text)
        {
            Console.Write($"{text}");
        }
        public void Clear()
        {
            Console.Clear();
        }
    }
}
