using System;
using System.Linq;

namespace p17_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int kol = 0;
                while (true)
                {
                    Console.Write("количество элементов массива: ");
                    kol = int.Parse(Console.ReadLine());
                    if (kol > 0) { break; }
                }
                double[] arr = new double[kol];
                for (int i = 0; i < kol; i++)
                {
                    Console.Write($"{i+1} элемент массива: ");
                    arr[i] = Convert.ToDouble(Console.ReadLine());
                }
                Console.WriteLine("\tЗадание А");
                foreach(var item in arr.GroupBy(u => u).Where(u => u.Count() > 0).Select(u => new { el = u.Key, ch = u.Count() }))
                    Console.WriteLine($"{item.el} - {item.ch}");
                Console.WriteLine("\tЗадание B");
                foreach (var item in arr.GroupBy(u => u).Where(u => u.Count() > 0).Select(u => new { el = u.Key, ch = u.Count() }))
                    Console.WriteLine($"{item.el * item.ch} - {item.ch}");
            }
            catch { Console.WriteLine("неверные данные"); }
        }
    }
}
