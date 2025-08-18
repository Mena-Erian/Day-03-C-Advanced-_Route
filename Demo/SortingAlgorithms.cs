using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public delegate bool CustomFunc<T>(int arg01, int arg02);

    internal static class SortingAlgorithms
    {
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
}
