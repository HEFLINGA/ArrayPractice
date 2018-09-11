using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySep11
{
    class Program
    {
        public static void ShowOutPut(int[] arr)
        {
            var l = arr.Length;

            Console.Write("OutPut: ");

            if (l == 0)
            {
                Console.WriteLine($"{{ {arr[0]} }}");
            }
            else if (l > 0)
            {
                Console.Write($"{{ {arr[0]}");

                for (int i = 1; i < l; ++i)
                {
                    Console.Write($", {arr[i]}");
                }

                Console.WriteLine(" }");
            }
            else
            {
                Console.WriteLine(" { }");
            }

            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            var oa = new[] { 3, 2, 1, 7, 14, 8, 5, 12 };
            var soa = new[] { 1, 2, 3, 5, 7, 8, 12, 14 };

            Console.WriteLine("Original Unsorted Array)");
            ShowOutPut(oa);

            var na = MySort(oa);
            var sna = MySort(soa);

            Console.WriteLine("Original Sorted Array");
            ShowOutPut(soa);

            Console.WriteLine("Sorted Unsorted array");
            ShowOutPut(na);

            Console.WriteLine("Sorted Sorted Array");
            ShowOutPut(sna);
        }

        public static int[] MySort(int[] arr)
        {
            var na = new int[arr.Length];
            var nextIndex = arr.Length - 1;
            
            for (int i = 0; i < arr.Length; ++i)
            {
                na[i] = arr[i];
            }

            for (int k = 0; k < nextIndex; ++k)
            {
                for (int i = 0; i < nextIndex; ++i)
                {
                    SortSwap(na, i);
                }
            }

            return na;
        }

        public static void SortSwap(int[] na, int i)
        {
            var next = i + 1;

            if (na[i] > na[next])
            {
                var tmp     = na[i];

                na[i]       = na[next];
                na[next]    = tmp;
            }
        }
    }
}
