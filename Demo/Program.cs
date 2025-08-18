using static System.Net.Mime.MediaTypeNames;

namespace Demo
{

    /// Step 0. Delegate Declaration
    public delegate int CustomFunc(string arg01);
    /// NEW Delegate (Class), The Reference from this Delegate Can Refer to a Function or More [Pointer To Function]
    /// These Functions Can be Class Member [Static] or Object Member [Non-Static].
    /// These Functions Must Have the Same Signature of the Delegate: int (string).
    /// Regardless Function Access Modifier, Regardless Naming (Function, Parameters).
    public delegate bool CustomPredicate(int obj);
    public delegate bool CustomPredicate<in T>(T obj);
    internal class Program
    {
        public static List<T> FindElements<T>(List<T> Numbers, Predicate<T> predicate)
        {
            List<T> Result = new List<T>(Numbers.Count);

            if (Numbers?.Count > 0)
                foreach (T num in Numbers)
                    if (predicate/*.Invoke*/(num)) Result.Add(num);
            return Result;
        }

        public static List<int> FindNumbers(List<int> Numbers, CustomPredicate predicate)
        {
            List<int> Result = new List<int>(Numbers.Count);

            if (Numbers?.Count > 0)
                foreach (int num in Numbers)
                    if (predicate/*.Invoke*/(num)) Result.Add(num);
            return Result;
        }
        public static List<T> FindNumbers<T>(List<T> Numbers, CustomPredicate<T> predicate)
        {
            List<T> Result = new List<T>(Numbers.Count);

            if (Numbers?.Count > 0)
                foreach (T num in Numbers)
                    if (predicate/*.Invoke*/(num)) Result.Add(num);
            return Result;
        }


        static void Main()
        {
            /// Delegate is a C# Language Feature [C# 2.0]
            /// Has 2 Usages:
            /// 1. Functional Programming
            /// 2. Event-Driven Programming

            #region Delegate Example 01
            /// CustomFunc reference;
            /// // Step 1. Declare Delegate Reference
            /// 
            /// // Step 2. Initialize the Delegate Reference [Pointer To Function]
            /// //reference = new CustomFunc(StringFunction.GetCountOfUpperCaseChars);
            /// reference = StringFunction.GetCountOfUpperCaseChars; // "Syntax Sugar"
            /// reference += StringFunction.GetCountOfLowerCaseChars; //  return for the last
            /// 
            /// reference -= StringFunction.GetCountOfLowerCaseChars;
            /// 
            /// //reference -= StringFunction.GetCountOfUpperCaseChars;
            /// 
            /// // Step 3. Use the Delegate Reference
            /// //reference.Invoke("Mena Erian"); 
            /// Console.WriteLine(reference("Mena Erian")); // "Syntax Sugar"
            /// 
            /// //int x = StringFunction.GetCountOfUpperCaseChars; 
            #endregion

            #region Delegate Example 02 Using Generics
            /// int[] Numbers = { 1, 2, 32, 435, 3, 42, 3, 43, 5, 2, 6456, 34, 34, 5, 345, 3 };
            /// 
            /// //SortingAlgorithms.BubbleSort(Numbers, new AscComparer());
            /// CustomFunc<int> func1 = SortingTypes.CompareGrt;
            /// CustomFunc<int, int> func2 = SortingTypes.CompareGrt;
            /// CustomFunc<int, int, bool> func3 = SortingTypes.CompareGrt;
            /// 
            /// //SortingAlgorithms.BubbleSort(Numbers, func);
            /// SortingAlgorithms.BubbleSort<int>(Numbers, func1);
            /// //SortingAlgorithms.BubbleSort(Numbers, delegate (int x, int y) { return x > y });
            /// //SortingAlgorithms.BubbleSort(Numbers, (x, y) => x > y);
            /// Numbers.PrintAll();

            /// string[] names = ["Mena", "Erian", "Farouk", "Makar", "Gerges", "Fadelalah"];
            /// 
            /// CustomFunc<string, string, bool> func = ComparsionTypes<string>.CompareGrt;
            /// 
            /// SortingAlgorithms.BubbleSort<string>(names, func);
            /// names.PrintAll(); 
            #endregion

            #region Delegate Example 03
            #region Find
            /// List<int> Numbers = Enumerable.Range(0, 100).ToList();
            /// 
            /// List<int> Odds = FindNumbers(Numbers, ConditionFunctions.IsOdd);
            /// List<int> Evens = FindNumbers(Numbers, ConditionFunctions.IsEven);
            /// 
            /// Odds.PrintAll(); 
            #endregion

            #region 
            /// List<int> Numbers = Enumerable.Range(0, 100).ToList();
            /// //List<int> NumbersDisibleBySeven = FindNumbers(Numbers, ConditionFunctions.IsDivisibleBySeven);
            /// 
            /// CustomPredicate<int> predicate = ConditionFunctions.IsDivisibleBySeven;
            /// List<int> NumbersDisibleBySeven = FindNumbers(Numbers, predicate);
            /// 
            /// NumbersDisibleBySeven.PrintAll(); 

            /// /// List<int> Numbers = Enumerable.Range(0, 100).ToList();
            /// //List<int> NumbersDisibleBySeven = FindNumbers(Numbers, ConditionFunctions.IsDivisibleBySeven);
            /// 
            /// // not done
            /// //  List<string> names = ["Mena", "Erian", "Farouk", "Makar", "Gerges", "Fadelalah"];
            /// 
            /// 
            /// //CustomPredicate<int> predicate = ConditionFunctions.IsDivisibleBySeven;
            /// //List<int> NumbersDisibleBySeven = FindNumbers(Numbers, predicate);
            /// 
            /// //NumbersDisibleBySeven.PrintAll(); 
            #endregion
            #endregion

            /// List<string> names = ["Mena", "Erian", "Farouk", "Makar", "Gerges", "Fadelalah"];
            /// //Predicate<string> predicate = ConditionFunctions.IsMoreThan04;
            /// List<string> strs = FindElements<string>(names, ConditionFunctions.IsMoreThan04);
            /// 
            /// strs.PrintAll(); 

            #region Part 06 Built-in Delegates [Predicate, Func, Action]
            /// Predicate<int> predicate = SomeFuns.Test;
            /// predicate(10);
            /// 
            /// Func<int, bool> func = SomeFuns.Test;
            /// func(10);
            /// 
            /// Action<string> action = SomeFuns.Print;
            /// action/*.Invoke*/("Mena");
            /// action("Mena"); 
            #endregion

            #region Part 07 Anonymous Method and Lambada Expression
            /// // Anonymous Methods  
            /// Predicate<int> predicate = delegate (int Number) { return Number > 0; };
            /// predicate(10);
            /// 
            /// Func<int, bool> func = delegate (int Number) { return Number > 0};
            /// func(10);
            /// 
            /// Action<string> action = delegate (string Name) { Console.Write(Name); };
            /// action/*.Invoke*/("Mena");
            /// action("Mena");

            /// // Lambada Expression
            /// // Called as 'FatArrow' and Read as 'GoesTO'
            /// Predicate<int> predicate =  Number => Number > 0; ;
            /// predicate(10);
            /// 
            /// Func<int, bool> func = N => N > 0;
            /// func(10);
            /// 
            /// Action<string> action = (string Name) => Console.Write(Name);
            /// action/*.Invoke*/("Mena");
            /// action("Mena"); 
            #endregion

            #region Part 08 New Feature at Delegate in C# 10.0
            /// // var keyword -> Implicitly Typed Local Variable [C# 2.0]

            /// var predicate = delegate (int Number) { return Number > 0; };
            /// predicate(10);
            /// 
            /// var func = delegate (int Number) { return Number > 0; };
            /// func(10);
            /// 
            /// var action = delegate (string Name) { Console.Write(Name); };
            /// action/*.Invoke*/("Mena");
            /// action("Mena"); 
            #endregion

            #region Part 09 List Methods That Take Function as a Parameter
            /// List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            /// FindElements<int>(Numbers, (N) => N % 2 == 1).PrintAll();
            /// //Numbers.FindAll(x => x % 2 == 1).PrintAll();
            /// //Numbers.Find(x => x % 2 == 1).Print();
            /// //Numbers.FindLast(x => x % 2 == 1).Print();
            /// //Numbers.Exists(x => x % 2 == 1).Print(); // if one el match return true // Like Some
            /// //Numbers.TrueForAll(x => x % 2 == 1).Print(); // Like Every
            /// //Numbers.ForEach(x => ++x);
            /// //Numbers.RemoveAll(x => x % 2 == 1); 
            #endregion
        }
    }
    class SomeFuns
    {
        public static bool Test(int Number) => Number > 0;
        public static void Print(string Name) => Console.Write(Name);
    }
    class StringFunction
    {
        // Stratigy Design Pattern 

        //public StringFunction(int (string) Target)
        //{

        //}
        public static int GetCountOfUpperCaseChars(string Name)
        {
            int count = 0;
            Console.WriteLine("Upper");

            if (Name is not null)
                for (int i = 0; i < Name.Length; i++)
                    if (char.IsUpper(Name[i])) count++;

            return count;
        }
        public static int GetCountOfLowerCaseChars(string Name)
        {
            int count = 0;
            Console.WriteLine("Lower");
            if (Name is not null)
                for (int i = 0; i < Name.Length; i++)
                    if (char.IsLower(Name[i])) count++;

            return count;
        }
    }
    class ConditionFunctions
    {
        public static bool IsOdd(int Number) => Number % 2 == 1;
        public static bool IsEven(int Number) => Number % 2 == 0;
        public static bool IsDivisibleBySeven(int Number) => (Number % 7 == 0) && Number > 1;
        public static bool IsMoreThan04(string e) => e.Length > 4;
    }
}
