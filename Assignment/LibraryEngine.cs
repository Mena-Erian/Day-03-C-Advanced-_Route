using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{

    public delegate string GetData(Book book);
    public class LibraryEngine
    {
        #region User-Define 
        public static void ProcessBooks(List<Book> bList, GetData fPtr)
        {
            if (bList is null) return;
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }
        #endregion

        #region BCL (FUNC, Predicat, Acion) Delegates
        public static List<string> ProcessBooks(Func<Book, string> fPtr, List<Book> bList)
        {
            List<string> list = new List<string>(bList.Count);
            foreach (Book B in bList) list.Add(fPtr(B));

            return list;
        }
        public static void ProcessBooks(List<Book> bList, Predicate<decimal> fPtr)
        {
            if (bList is null) return;
            foreach (Book B in bList)
            {
                if (B is null) continue;
                if (fPtr(B.Price))
                    Console.WriteLine(B.Price);
            }
        }
        public static void ProcessBooks(List<Book> bList, Action<Book> fPtr)
        {
            if (bList is null) return;
            foreach (Book B in bList)
            {
                if (B is null) continue;
                fPtr(B);
            };
        }
        #endregion


        #region Anonymous Mehdos
        ///  public static List<string> ProcessBooks(Func<Book, string> fPtr, List<Book> bList)
        ///  {
        ///      List<string> list = new List<string>(bList.Count);
        ///      foreach (Book B in bList) list.Add(fPtr(B));
        ///
        ///      return list;
        ///  }
        #endregion

        #region Lambda Expression
        public static void ProcessBooks(List<Book> bList, Func<Book, DateTime> fPtr)
        {
            foreach (Book B in bList)
                Console.WriteLine(fPtr(B).ToString());
        }
        #endregion

    }
}
