using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProveraZnanja
{
    class Program
    {
        static void Main(string[] args)
        {
            #region BubbleSort
            ////bubble sort
            //var nekiNiz = new int[] { 4, 5, 12, 0, 1, 2 };

            //BubbleSort(nekiNiz);
            //foreach (var item in nekiNiz)
            //{
            //Console.WriteLine(item);

            //}
            //Console.ReadLine();
        //}
//        private static int[] BubbleSort(int[] unsortedArray)
//    {
//             var length = unsortedArray.Length;
//            for (int i = 0; i < length - 1; i++)
//            {
//                for (int j = 0; j < length - 1 - i; j++)
//                {
//                    if (unsortedArray[j] > unsortedArray[j + 1])
//                    {
//                        //izvrsi swap
//                        var temp = unsortedArray[j];
//                        unsortedArray[j] = unsortedArray[j + 1];
//                        unsortedArray[j + 1] = temp;
//                    }
//                }
//            }
//	return unsortedArray;
//}
            #endregion
            #region Factorial
            //factorial
            //var input = Int32.Parse(Console.ReadLine());
            //var factResult = 1;
            //for (int i = input; i >= 1; i--)
            //{
            //    factResult = factResult * i;
            //}

            //Console.WriteLine(factResult);
            //Console.ReadLine();
            #endregion
            #region Factorial +Recursion
            //    var factNumber = Int32.Parse(Console.ReadLine());
            //    var factResult = FactCalculation(factNumber);
            //    Console.WriteLine(factResult);
            //    Console.ReadLine();
            //    
            //}
            //static int fact = 1;
            //private static int FactCalculation(int factNumber)
            //{
            //    if (factNumber>0)
            //    {
            //        fact = factNumber * FactCalculation(factNumber - 1);
            //    }
            //    return fact;
            //}
            #endregion
            #region Remainder5And3
            //// obican pristup
            //var resultat = 0;
            //for (int i = 0; i < 1000; i++)
            //{
            //    if (i%5==0||i%3==0)
            //    {
            //        resultat += i;

            //    }
            //}

            //Console.WriteLine(resultat);
            //Console.ReadLine();
            ////oneliner
            //var result = Enumerable.Range(0, 1000).Where(n => n % 3 == 0 || n % 5 == 0).Sum();
            //Console.WriteLine(result);
            //Console.ReadLine();



            #endregion
            #region QuickSort
            var unsortedArray = new int[] { 5, 155, 10, 2, 1, 3, 0 };
            SortArray(unsortedArray);
            foreach (var item in unsortedArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        private static void SortArray (int[] unsortedArray)
        {
            QuickSort(unsortedArray, 0, unsortedArray.Length - 1);
        }
        private static void QuickSort(int[] unsortedArray, int left, int right)
        {
            int l = left;
            int r = right;
            var pivot = unsortedArray[(left + right) / 2];

            while (l<=r)
            {
                    while (unsortedArray[l] < pivot)
                        l++;
                    while (unsortedArray[r] > pivot)
                        r--;

                if (l<=r)
                {
                    var temp = unsortedArray[l];
                    unsortedArray[l] = unsortedArray[r];
                    unsortedArray[r] = temp;
                    l++;
                    r--;
                }
            }

            if (left < r)
                QuickSort(unsortedArray, left, r);
            if (l<right)
                QuickSort(unsortedArray, l, right);

        }
        #endregion
    }
    }
