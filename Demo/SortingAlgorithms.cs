using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    //public delegate bool CustomFunc<T>(int arg01, int arg02);
    public delegate bool CustomFunc<T>(T arg01, T arg02);
    public delegate bool CustomFunc<T1, T2>(T1 arg01, T2 arg02);
    //public delegate TResult CustomFunc<T1, T2, TResult>(T1 arg01, T2 arg02);
    public delegate TResult CustomFunc<in T1, in T2, out TResult>(T1 arg01, T2 arg02);

    internal static class SortingAlgorithms
    {
        public static void BubbleSort<T>(T[] elements, CustomFunc<T, T, bool> func)
        {
            if (elements is null || func is null) return;

            for (int i = 0; i < elements.Length - 1; i++)
            {
                for (int j = 0; j < elements.Length - 1 - i; j++)
                {
                    if (func.Invoke(elements[j], elements[j + 1]))
                        Swap(ref elements[j], ref elements[j + 1]);
                }
            }
        }

        public static void BubbleSort<T>(T[] Numbers, CustomFunc<T, T> func)
        {
            if (Numbers is null || func is null) return;

            for (int i = 0; i < Numbers.Length - 1; i++)
            {
                for (int j = 0; j < Numbers.Length - 1 - i; j++)
                {
                    if (func.Invoke(Numbers[j], Numbers[j + 1]))
                        Swap(ref Numbers[j], ref Numbers[j + 1]);
                }
            }
        }
        public static void BubbleSort<T>(T[] Numbers, CustomFunc<T> func)
        {
            if (Numbers is null || func is null) return;

            for (int i = 0; i < Numbers.Length - 1; i++)
            {
                for (int j = 0; j < Numbers.Length - 1 - i; j++)
                {
                    if (func.Invoke(Numbers[j], Numbers[j + 1]))
                        Swap(ref Numbers[j], ref Numbers[j + 1]);
                }
            }
        }
        private static void Swap<T>(ref T v1, ref T v2)
        {
            T Temp = v1;
            v1 = v2;
            v2 = Temp;
        }

        public static void BubbleSort(int[] Numbers, CustomFunc<int> func)
        {
            if (Numbers is null || func is null) return;

            for (int i = 0; i < Numbers.Length - 1; i++)
            {
                for (int j = 0; j < Numbers.Length - 1 - i; j++)
                {
                    if (func.Invoke(Numbers[j], Numbers[j + 1]))
                        Swap(ref Numbers[j], ref Numbers[j + 1]);
                }
            }
        }

        public static void BubbleSort(int[] Numbers, ICustomComparer comparer)
        {
            if (Numbers is null) return;

            for (int i = 0; i < Numbers.Length - 1; i++)
            {
                for (int j = 0; j < Numbers.Length - 1 - i; j++)
                {
                    if (comparer.Compare(Numbers[j], Numbers[j + 1]))
                        Swap(ref Numbers[j], ref Numbers[j + 1]);
                }
            }
        }
        private static void Swap(ref int v1, ref int v2)
        {
            int Temp = v1;
            v1 = v2;
            v2 = Temp;
        }
    }

    class SortingTypes
    {
        public static bool CompareGrt(int x, int y) => x > y;
        public static bool CompareLes(int x, int y) => x < y;

    }
    class ComparsionTypes<T> where T : IComparable<T>
    {
        public static bool CompareGrt(T x, T y) => x.CompareTo(y) == 1;
        public static bool CompareLes(T x, T y) => x.CompareTo(y) == -1;
    }

}
