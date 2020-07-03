using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract2_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите цену 1 шт. товара: ");
                double goods = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                for (int i = 10; i < 101; i += 10)
                {
                    Console.WriteLine("Стоимость " + i + " шт: " + goods * i);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат ввода данных");
            }
            Console.ReadKey();
        }
    }
}
