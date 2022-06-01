using System;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 3, 3, 4, 4 };
            // Console.WriteLine(isCenteredArray(myArray));
            Console.WriteLine(oddEvenDifference(myArray));
        }

        // An array with an odd number of elements is said to be centered if all
        // elements (except the middle one) are strictly greater than the value of the
        // middle element. Note that only arrays with an odd number of elements have a
        // middle element. Write a function that accepts an integer array and returns 1
        // if it is a centered array, otherwise it returns 0.
        public static int isCenteredArray(int[] arr)
        {
            if (arr.Length % 2 == 0)
                return 0;
            int middle = (arr.Length) / 2;

            for (int index = 0; index < arr.Length; index++)
            {
                if (arr[index] <= arr[middle] && index != middle)
                {
                    return 0;
                }
            }
            return 1;
        }
        // Write a function that takes an array of integers as an argument and returns a
        // value based on the sums of the even and odd numbers in the array. Let X = the
        // sum of the odd numbers in the array and let Y = the sum of the even numbers.
        // The function should return X – Y
        public static int[] calulateSum(int[] acc, int current)
        {
            if (current % 2 == 1)
            {
                acc[0] += current;
            }
            else
            {
                acc[1] += current;
            }
            return acc;
        }
        public static int oddEvenDifference(int[] arr)
        {
            var res = arr.ToList().Aggregate(new int[] { 0, 0 }, (acc, x) => calulateSum(acc, x));
            return res[0] - res[1];
        }
    }
}