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

        
          public static int isPrimeHappy(int n)
        {
            var primeList = new List<int>();
            int curTest = 2;
            while (curTest < n)
            {

                int sqrt = (int)Math.Sqrt(curTest);

                bool isPrime = true;
                for (int i = 0; i < primeList.Count && primeList.ElementAt(i) <= sqrt; ++i)
                {
                    if (curTest % primeList.ElementAt(i) == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime) primeList.Add(curTest);

                curTest += 1;
            }
            var sum = primeList.Aggregate(0, (a, b) => a + b);
            if (sum % n == 0)
            {
                return 1;
            }
            return 0;
        }
        public static int isTwinPaired(int[] arr)
        {
            var evenList = new List<int>();
            var oddList = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenList.Add(arr[i]);
                }
                else
                {
                    oddList.Add(arr[i]);
                }
            }
            var sortedEvenList = evenList.OrderBy(number => number).ToList();
            var sortedOddList = oddList.OrderBy(number => number).ToList();
            if (evenList.SequenceEqual(sortedEvenList) && oddList.SequenceEqual(sortedOddList))
            {
                return 1;
            }
            return 0;
        }
        public static int sameNumberOfFactors(int n1, int n2)
        {
            if (n1 < 0 || n2 < 0) return -1;
            if (n1 == n2) return 1;
            if (n1 == 0 || n2 == 0) return 0;
            var factors1 = new List<int>();
            var factors2 = new List<int>();
            for (int i = 1; i <= Math.Max(n1, n2); i++)
            {
                if (n1 % i == 0)
                {
                    factors1.Add(i);
                }
                if (n2 % i == 0)
                {
                    factors2.Add(i);
                }
            }
            if (factors1.Count() == factors2.Count())
            {
                return 1;
            }
            return 0;
        }
    }
}