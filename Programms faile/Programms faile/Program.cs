using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programms_faile
{
    public class StringCompare
    {
        public static void Main(string[] args)
        {
            string a = "Привет";
            string b = "привет";
            string c = "Привет, мир!";

            Console.WriteLine($"Строки '{a}' и '{b}' одинаковы (без учета регистра): {a.ToLower() == b.ToLower()}"); // true
            Console.WriteLine($"Строки '{a}' и '{b}' одинаковы (с учетом регистра): {a == b}"); // false
            Console.WriteLine($"Строка '{c}' содержит '{a}': {c.Contains(a)}"); // true
            Console.WriteLine($"Позиция '{a}' в '{c}': {c.IndexOf(a)}"); // 0
        }
    }
}
