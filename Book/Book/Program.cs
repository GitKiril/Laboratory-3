using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your book title? ");
            string title = Console.ReadLine();
            Console.Write("Write  author name  : ");
            string author = Console.ReadLine();
            Console.WriteLine("Write  content : ");
            string content = Console.ReadLine();
            Book book = new Book(new Title(title), new Author(author), new Content(content));
            Console.WriteLine();
            Console.Clear();
            book.Title.Show();
            book.Author.Show();
            book.Content.Show();
            Console.WriteLine();
        }


    }
}
