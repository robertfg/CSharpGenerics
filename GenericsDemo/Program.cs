using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    class Program
    {
        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }

        static void Main(string[] args)
        {
            var list1 = new List<int> { 1, 2, 3, 4, 5 };
            var list2 = new List<int> { 2, 4, 6, 8, 10 };
            var set1 = new HashSet<int> { 3, 6, 9, 12, 15 };
            var array1 = new[] { 4, 8, 12, 16, 20 };

            /*  This is too cumbersome to perform for each collection.
             *  Use LINQ instead.   */
            //int numOdd = 0;
            //foreach(var value in list1)
            //{
            //    if (IsOdd(value))
            //    {
            //        numOdd++;
            //    }
            //}

            // This is still too much code.
            int numOdd =
                list1.Count(x => IsOdd(x)) +
                list2.Count(x => IsOdd(x)) +
                set1.Count(x => IsOdd(x)) +
                array1.Count(x => IsOdd(x));

            Console.WriteLine(numOdd);
            Console.ReadKey();
        }
    }
}
