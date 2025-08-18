namespace Demo
{

    /// Step 0. Delegate Declaration
    public delegate int CustomFunc(string arg01);
    /// NEW Delegate (Class), The Reference from this Delegate Can Refer to a Function or More [Pointer To Function]
    /// These Functions Can be Class Member [Static] or Object Member [Non-Static].
    /// These Functions Must Have the Same Signature of the Delegate: int (string).
    /// Regardless Function Access Modifier, Regardless Naming (Function, Parameters).
    internal class Program
    {
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
        
        
        
        }
    }
    class StringFunction
    {
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
}
