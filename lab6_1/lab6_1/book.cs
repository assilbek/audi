using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_1
{
    class book
    {
        private String author;
        private String title;
        private String publisher;
        private int pages;
        private int year;
        private static double price = 9;
        public void SetBook(String author, String title, String publisher, int pages, int year)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;

        }
        public static void SetPrice(double price)
        {
            book.price = price;
        }
        public void Show()
        {
            Console.WriteLine("\nBook: \n Author: {0}\n Name: {1}\n Year: {2}\n {3}pages\n Rent price: {4}", author, title, year, pages, book.price);

        }
        public double PriceBook(int s)
        {
            double cust = s * price;
            return cust;
        }

    }
}
