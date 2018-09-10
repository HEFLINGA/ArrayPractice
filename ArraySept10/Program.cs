using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySept10
{
    class Program
    {   
        static void Main(string[] args)
        {
            Console.WriteLine("Step 1: ");
            ArrayPractice array = new ArrayPractice();
            int[] firstArr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9};

            array.Swap(firstArr, 0, 3);
            array.ShowOutPut(firstArr);

            Console.WriteLine("Step 2: ");
            int[] secArr = new int[] { 1, 2, 3, 4, 5 };
            array.ReverseInPlace(secArr);
            array.ShowOutPut(secArr);

            Console.WriteLine();

            Console.WriteLine("Step 3: ");
            int[] thdArr = new int[] { 1, 2, 3, 4, 5, 6 };
            array.ReverseNew(thdArr);

            Console.WriteLine();
        }
    }
}
