using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            book b1 = new book();
            b1.SetBook("Достоевский Ф.М.", "Братья Карамазовы", "Вильямс", 2035, 2000);
            book.SetPrice(12);
            b1.Show();
            Console.WriteLine("\n Finally price for rent: {0} p.", b1.PriceBook(3));
            Console.ReadKey();
        }
    }
}
