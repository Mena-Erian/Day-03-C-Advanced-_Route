using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }
        public Book(string _ISBN, string _Title,
        string[] _Authors, DateTime _PublicationDate,
        decimal _Price)
        {
            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            PublicationDate = _PublicationDate;
            Price = _Price;
        }

        public override string ToString()
         => $"ISBN: {ISBN}, Title: {Title}, Authors: {Authors}, Publication: {PublicationDate:d}, Price: {Price:c}";
    }
    public class BookFunctions
    {
        public static string GetISBN(Book B) => B?.ISBN ?? "NOT FOUND";
        public static string GetPublicationDate(Book B) 
            => B?.PublicationDate.ToString() ?? "NOT FOUND";

        public static string GetTitle(Book B) => B?.Title ?? "NOT FOUND";
        public static string GetAuthors(Book B)
        {
            if (B == null) return "NOT FOUND";
            string authors = "Authors: ";
            int Count = 0;

            foreach (string author in B.Authors)
            {

                if (Count < B.Authors.Length - 1) authors += $"{author}, ";
                else authors += $"{author}";

                Count++;
            }

            return authors;
        }
        public static string GetPrice(Book B) => B?.Price.ToString() ?? "NOT FOUND";
    }
}
