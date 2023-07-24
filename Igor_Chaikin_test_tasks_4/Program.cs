using System;
using System.Collections.Generic;

namespace Igor_Chaikin_test_tasks_4
{
    class Program
    {
        // time complexity: O(n) (or O(n/2) where n - characters count)
        static string ReverseString(string s) {
            int count = s.Length;
            int lastIdx = count - 1;
            char[] sArray = s.ToCharArray();
            for (int i = 0; i < count / 2; i++) {
                char tmp = sArray[i];
                sArray[i] = sArray[lastIdx - i];
                sArray[lastIdx - i] = tmp;

            }
            return new string(sArray);
        }

        // time complexity: O(n) (or O(n/2) where n - characters count)
        static bool IsPalindrome(string s) {
            int count = s.Length;
            int lastIdx = count - 1;
            char[] sArray = s.ToCharArray();
            for (int i = 0; i < count / 2; i++)
            {
                if (sArray[i] != sArray[lastIdx - i]) {
                    return false;
                }
            }
            return true;
        }

        // time complexity: O(n) 
        static IEnumerable<int> MissingElements(int[] arr) {
            int count = arr.Length;
            int lastIdx = count - 1;
            List<int> result = new List<int>();
            if (count == 0) {
                return result;
            }

            int currentIdx = 0;
            for (int i = arr[0]; i < arr[lastIdx]; i++)
            {
                if (i != arr[currentIdx])
                {
                    result.Add(i);
                }
                else {
                    currentIdx++;
                }
            }
            return result;

        }

        static void Main(string[] args)
        {
            // test of task 4.1
            // output: "!dlroW olleH"
            Console.WriteLine(ReverseString("Hello World!"));
            // output: "elpmaxE"
            Console.WriteLine(ReverseString("Example"));
            Console.WriteLine();

            // test of task 4.2
            // output: True
            Console.WriteLine(IsPalindrome("abccba"));
            // output: False
            Console.WriteLine(IsPalindrome("afccba"));
            // output: True
            Console.WriteLine(IsPalindrome("abcdcba"));
            Console.WriteLine();

            // test of task 4.3
            // output: [5,7,8]
            IEnumerable<int> test_1 = MissingElements(new int [] { 4, 6, 9});
            foreach (int resultElement in test_1) {
                Console.Write($"{resultElement} ");
            }
            Console.WriteLine();
            // output: []
            IEnumerable<int> test_2 = MissingElements(new int[] { 2, 3, 4 });
            foreach (int resultElement in test_2)
            {
                Console.Write($"{resultElement} ");
            }
            Console.WriteLine();
            // output: [2]
            IEnumerable<int> test_3 = MissingElements(new int[] { 1, 3, 4 });
            foreach (int resultElement in test_3)
            {
                Console.Write($"{resultElement} ");
            }
            Console.WriteLine();
            // output: []
            IEnumerable<int> test_4 = MissingElements(new int[] {});
            foreach (int resultElement in test_4)
            {
                Console.Write($"{resultElement} ");
            }
            Console.WriteLine();
            // output: [1,2,3,4]
            IEnumerable<int> test_5 = MissingElements(new int[] { 0, 5 });
            foreach (int resultElement in test_5)
            {
                Console.Write($"{resultElement} ");
            }
            Console.WriteLine();
        }
    }
}
