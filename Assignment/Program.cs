namespace Assignment
{
    internal class Program
    {
        static void Main()
        {
            List<Book> books = new List<Book>() {
                new Book("1d1w8x2e9d6g1", "C Programming", ["Mena Erian", "Another Person"], new DateTime(2000, 1, 1), 2.5m),
                new Book("2a9f3k7h4b2c8", "Mastering C#", ["John Smith", "Sara Lee"], new DateTime(2010, 5, 12), 3.8m),
                new Book("3p6d4n1q8m2r7", "Data Structures and Algorithms", ["David Johnson"], new DateTime(2015, 9, 23), 4.2m),
                new Book("4l7h9s3k2d8f5", "Learning Angular", ["Mena Erian", "Emily Carter"], new DateTime(2021, 3, 15), 4.5m),
                new Book("5x2c8v6b1n4m9", "SQL Fundamentals", ["Michael Brown"], new DateTime(2008, 11, 5), 3.1m),
                new Book("6z9d7e3t1y8u4", "ASP.NET Core in Action", ["Andrew White", "Jessica Green"], new DateTime(2018, 6, 30), 4.7m),
                new Book("7q1w3e5r9t2y6", "Design Patterns Explained", ["Christopher Hall"], new DateTime(2004, 2, 18), 4.0m),
                new Book("8m5n2b7v1c9x3", "JavaScript: The Definitive Guide", ["Ethan Roberts", "Sophia Clark"], new DateTime(2020, 7, 22), 4.9m),
                new Book("9k8j6h4g2f1d7", "Introduction to Databases", ["Paul Walker"], new DateTime(2012, 10, 10), 3.6m),
                new Book("0r4e8t2y6u1i5", "Clean Code", ["Robert C. Martin"], new DateTime(2008, 8, 1), 5.0m),
                // --- continue with 90 more ---
                new Book("a1b2c3d4e5f6", "Effective Java", ["Joshua Bloch"], new DateTime(2017, 11, 1), 4.8m),
                new Book("b2c3d4e5f6g7", "Head First Design Patterns", ["Eric Freeman", "Elisabeth Robson"], new DateTime(2014, 3, 5), 4.6m),
                new Book("c3d4e5f6g7h8", "Python Crash Course", ["Eric Matthes"], new DateTime(2019, 5, 10), 4.7m),
                new Book("d4e5f6g7h8i9", "The Pragmatic Programmer", ["Andrew Hunt", "David Thomas"], new DateTime(1999, 10, 30), 4.9m),
                new Book("e5f6g7h8i9j1", "Programming Pearls", ["Jon Bentley"], new DateTime(2000, 6, 18), 4.1m),
                new Book("f6g7h8i9j1k2", "Modern Operating Systems", ["Andrew S. Tanenbaum"], new DateTime(2014, 9, 7), 4.3m),
                new Book("g7h8i9j1k2l3", "Computer Networks", ["James Kurose", "Keith Ross"], new DateTime(2012, 2, 1), 4.2m),
                new Book("h8i9j1k2l3m4", "Deep Learning", ["Ian Goodfellow", "Yoshua Bengio", "Aaron Courville"], new DateTime(2016, 11, 18), 4.5m),
                new Book("i9j1k2l3m4n5", "Artificial Intelligence: A Modern Approach", ["Stuart Russell", "Peter Norvig"], new DateTime(2020, 4, 10), 4.6m),
                new Book("j1k2l3m4n5o6", "You Don't Know JS", ["Kyle Simpson"], new DateTime(2015, 12, 17), 4.4m),
                // Placeholder filler: 80 more entries with variations
                new Book("k2l3m4n5o6p7", "Learn C++ the Hard Way", ["Zed Shaw"], new DateTime(2018, 8, 20), 4.0m),
                new Book("l3m4n5o6p7q8", "Introduction to Algorithms", ["Thomas H. Cormen", "Charles Leiserson"], new DateTime(2009, 7, 31), 4.7m),
                new Book("m4n5o6p7q8r9", "Refactoring", ["Martin Fowler"], new DateTime(2012, 5, 22), 4.8m),
                new Book("n5o6p7q8r9s1", "Working Effectively with Legacy Code", ["Michael Feathers"], new DateTime(2004, 9, 30), 4.6m),
                new Book("o6p7q8r9s1t2", "Domain-Driven Design", ["Eric Evans"], new DateTime(2003, 8, 30), 4.5m),
                new Book("p7q8r9s1t2u3", "Test-Driven Development", ["Kent Beck"], new DateTime(2002, 11, 15), 4.2m),
                new Book("q8r9s1t2u3v4", "Extreme Programming Explained", ["Kent Beck", "Cynthia Andres"], new DateTime(2004, 3, 1), 4.1m),
                new Book("r9s1t2u3v4w5", "Agile Principles, Patterns, and Practices", ["Robert C. Martin", "Micah Martin"], new DateTime(2006, 12, 12), 4.3m),
                new Book("s1t2u3v4w5x6", "Effective C++", ["Scott Meyers"], new DateTime(2005, 5, 15), 4.7m),
                new Book("t2u3v4w5x6y7", "More Effective C++", ["Scott Meyers"], new DateTime(1996, 2, 22), 4.6m),
            };

            #region User Defined Delegate
            //LibraryEngine.ProcessBooks(books, BookFunctions.GetTitle);
            //LibraryEngine.ProcessBooks(books, BookFunctions.GetAuthors);
            //LibraryEngine.ProcessBooks(books, BookFunctions.GetPrice);
            #endregion

            #region BCL (FUNC, Predicat, Acion) Delegates
            /// //Note: i just make this order of parmaters to be able run 
            /// //the app without any conflict wether you or compiler :)

            /// LibraryEngine.ProcessBooks(BookFunctions.GetPublicationDate, books);
            /// //LibraryEngine.ProcessBooks(books, (price) => price > 4);
            /// //LibraryEngine.ProcessBooks(books, (b) => Console.WriteLine(b));
            #endregion

            #region Anonymous Mehdos
            /// LibraryEngine.ProcessBooks(delegate (Book b)
            /// {
            ///     return b.ISBN;
            /// }, books);
            #endregion

            #region Lambda Expression
            /// LibraryEngine.ProcessBooks(books, (b) =>
            ///     b?.PublicationDate ?? default(DateTime)
            /// );
            #endregion
        }
    }
}
