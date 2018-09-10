using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySept10
{
    class ArrayPractice
    {
        public void ShowOutPut(int[] arr)
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

        // Write array that swaps x with y and y with x
        public void Swap(int[] arr, int x, int y)
        {
            var l = arr.Length;

            if (x >= 0 && x < l && y >= 0 && y < l)
            {
                var tmp = arr[x];

                arr[x] = arr[y];
                arr[y] = tmp;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        } 

        public void ReverseInPlace(int[] arr)
        {
            var l = arr.Length;

            var last = l - 1;
            var middle = l / 2;

            for (int i = 0; i < middle; ++i)
            {
                this.Swap(arr, i, last - i);
            }
        }

        public int[] ReverseNew(int[] arr)
        {
            int[] newArr = new int[arr.Length];

            for (int oIndex = arr.Length; oIndex > 0; --oIndex)
            {
                var nIndex = arr.Length - oIndex;

                newArr[nIndex] = arr[oIndex - 1];
            }

            ShowOutPut(newArr);
            return newArr;
        }
        
    }
}
