using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment_sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question1:
            Console.WriteLine("Question 1");
            int[] ar1 = { 2, 5, 1, 3, 4, 7 };
            int n1 = 3;
            ShuffleArray(ar1, n1);

            //Question 2 
            Console.WriteLine("Question 2");
            int[] ar2 = { 0, 1, 0, 3, 12 };
            MoveZeroes(ar2);
            Console.WriteLine("");

            //Question3
            Console.WriteLine("Question 3");
            int[] ar3 = { 1, 2, 3, 1, 1, 3 };
            CoolPairs(ar3);
            Console.WriteLine();

            //Question 4
            Console.WriteLine("Question 4");
            int[] ar4 = { 2, 7, 11, 15 };
            int target = 9;
            TwoSum(ar4, target);
            Console.WriteLine();

            //Question 5
            Console.WriteLine("Question 5");
            string s5 = "korfsucy";
            int[] indices = { 6, 4, 3, 2, 1, 0, 5, 7 };
            RestoreString(s5, indices);
            Console.WriteLine();

            //Question 6
            Console.WriteLine("Question 6");
            string s61 = "bulls";
            string s62 = "sunny";
            if (Isomorphic(s61, s62))
            {
                Console.WriteLine("Yes the two strings are Isomorphic");
            }
            else
            {
                Console.WriteLine("No, the given strings are not Isomorphic");
            }
            Console.WriteLine();

            //Question 7
            Console.WriteLine("Question 7");
            int[,] scores = { { 1, 91 }, { 1, 92 }, { 2, 93 }, { 2, 97 }, { 1, 60 }, { 2, 77 }, { 1, 65 }, { 1, 87 }, { 1, 100 }, { 2, 100 }, { 2, 76 } };
            HighFive(scores);
            Console.WriteLine();

            //Question 8
            Console.WriteLine("Question 8");
            int n8 = 19;
            if (HappyNumber(n8))
            {
                Console.WriteLine("{0} is a happy number", n8);
            }
            else
            {
                Console.WriteLine("{0} is not a happy number", n8);
            }

            Console.WriteLine();

            //Question 9
            Console.WriteLine("Question 9");
            int[] ar9 = { 7, 1, 5, 3, 6, 4 };
            int profit = Stocks(ar9);
            if (profit == 0)
            {
                Console.WriteLine("No Profit is possible");
            }
            else
            {
                Console.WriteLine("Profit is {0}", profit);
            }
            Console.WriteLine();

            //Question 10
            Console.WriteLine("Question 10");
            int n10 = 3;
            Stairs(n10);
            Console.WriteLine();
        }

        //Question 1
        /// <summary>
        /// Shuffle the input array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].
        /// Print the array in the form[x1, y1, x2, y2, ..., xn, yn].
        ///Example 1:
        ///Input: nums = [2,5,1,3,4,7], n = 3
        ///Output: [2,3,5,4,1,7]
        ///  Explanation: Since x1 = 2, x2 = 5, x3 = 1, y1 = 3, y2 = 4, y3 = 7 then the answer is [2,3,5,4,1,7].
        ///Example 2:
        ///Input: nums = [1,2,3,4,4,3,2,1], n = 4
        ///Output: [1,4,2,3,3,2,4,1]
        ///Example 3:
        ///Input: nums = [1,1,2,2], n = 2
        ///Output: [1,2,1,2]
        /// </summary>

        private static void ShuffleArray(int[] nums, int n)
        {
            try
            {
                var res = new int[nums.Length];//creating a new array 'res'
                var index = 0;//initializing index value
                for (int i = 0, j = n; j < nums.Length; i++, j++)
                {
                    res[index] = nums[i];// moving values of nums to res
                    index++;//incrementing index ,to move the value from nums based on n
                    res[index] = nums[j];//moving the value depend on n
                    index++;//incrementing index for next iteration and to store the value from num to res using iteration value i
                }
                foreach (int value in res)
                {
                    Console.WriteLine(value);//printing the values in res after shuffling the values
                }


            }
            catch (Exception)
            {

                throw;
            }
        }
        /* Q1 Explanation :
         * increased the index twice in one for loop to arrange the values in expected order
         * 
         */

        //Question 2:
        /// <summary>
        /// Write a method to move all 0's to the end of the given array. You should maintain the relative order of the non-zero elements. 
        /// You must do this in-place without making a copy of the array.
        /// Example:
        ///Input: [0,1,0,3,12]
        /// Output: [1,3,12,0,0]
        /// </summary>

        private static void MoveZeroes(int[] ar2)
        {
            try
            {
                int index = 0; //initializing the index value
                int x = ar2.Length;

                for (int i = 0; i < ar2.Length; i++)
                {
                    if (ar2[i] == 0)
                    {
                        index += 1;// incrementing the index value to for every '0' occurence

                    }
                    else
                    {
                        ar2[i - index] = ar2[i];//moving non zero value to the prior position depending on the index value
                    }

                }
                for (int i = x - index; i < x; i++)
                {
                    ar2[i] = 0;// adding value '0' s to the array based on x - index value
                }
                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine(ar2[i]);//priniting the array after keeping all 0 values at the end of the array
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        //Question 3
        /// <summary>
        /// For an array of integers - nums
        ///A pair(i, j) is called cool if nums[i] == nums[j] and i<j
        ///Print the number of cool pairs
        ///Example 1
        ///Input: nums = [1,2,3,1,1,3]
        ///Output: 4
        ///Explanation: There are 4 cool pairs (0,3), (0,4), (3,4), (2,5) 
        ///Example 3:
        ///Input: nums = [1, 2, 3]
        ///Output: 0
        ///Constraints: time complexity should be O(n).
        /// </summary>

        private static void CoolPairs(int[] nums)
        {
            try
            {
                Dictionary<int, int> dic = new Dictionary<int, int>();//creating one empty dictionary
                int count = 0;//initializing the count 
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] == nums[j])
                        {
                            dic.TryAdd(i, j);//adding the values to dictionary when the values are equal
                            count += 1;//counting number of times happy values are repeated
                        }
                    }
                }
                Console.WriteLine(count);
                foreach (KeyValuePair<int, int> ele1 in dic)
                {
                    Console.Write("({0},{1})",
                              ele1.Key, ele1.Value);//displaying the count of happy numbers repeated
                }
            }
            catch (Exception)
            {

                throw;
            }
            Console.WriteLine();
        }

        //Question 4:
        /// <summary>
        /// Given integer target and an array of integers, print indices of the two numbers such that they add up to the target.
        ///You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// You can print the answer in any order
        ///Example 1:
        ///Input: nums = [2,7,11,15], target = 9
        /// Output: [0,1]
        ///Output: Because nums[0] + nums[1] == 9, we print [0, 1].
        ///Example 2:
        ///Input: nums = [3,2,4], target = 6
        ///Output: [1,2]
        ///Example 3:
        ///Input: nums = [3,3], target = 6
        ///Output: [0,1]
        ///Constraints: Time complexity should be O(n)
        /// </summary>
        private static void TwoSum(int[] nums, int target)
        {
            try
            {
                Dictionary<int, int> dic = new Dictionary<int, int>();//creating one empty dictionary

                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i + 1; j < nums.Length - 1; j++)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            dic.Add(i, j);// adding the indexes to the dictionary when condition met

                        }
                    }
                }
                foreach (KeyValuePair<int, int> ele1 in dic)
                {
                    Console.WriteLine("[{0},{1}]",
                              ele1.Key, ele1.Value);//printing the values of indexes
                }


            }
            catch (Exception)
            {

                throw;
            }

        }

        //Question 5:
        /// <summary>
        /// Given a string s and an integer array indices of the same length.
        ///The string s will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        ///Print the shuffled string.
        ///Example 1
        ///Input: s = "korfsucy", indices = [6,4,3,2,1,0,5,7]
        ///Output: "usfrocky"
        ///Explanation: As shown in the assignment document, “K” should be at index 6, “O” should be at index 4 and so on. “korfsucy” becomes “usfrocky”
        ///Example 2:
        ///Input: s = "USF", indices = [0,1,2]
        ///Output: "USF"
        ///Explanation: After shuffling, each character remains in its position.
        ///Example 3:
        ///Input: s = "ockry", indices = [1, 2, 3, 0, 4]
        ///Output: "rocky"
        /// </summary>
        private static void RestoreString(string s, int[] indices)
        {
            try
            {

                Dictionary<int, char> dict = new Dictionary<int, char>();//creating one empty dictionary
                for (int i = 0; i < indices.Length; i++)
                {
                    dict.Add(indices[i], s[i]);//adding the values from string and indices
                }
                var ordered_dic = dict.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);//sorting the key values in orderby to sort in an order

                foreach (KeyValuePair<int, char> ele1 in ordered_dic)
                {
                    Console.Write("{0}",
                              ele1.Value);//printing the values
                }


            }
            catch (Exception)
            {

                throw;
            }
            Console.WriteLine();
        }

        //Question 6
        /// <summary>
        /// Determine whether two give strings s1 and s2, are isomorphic.
        ///Two strings are isomorphic if the characters in s1 can be replaced to get s2.
        ///All occurrences of a character must be replaced with another character while preserving the order of characters.
        ///No two characters may map to the same character but a character may map to itself.
        ///Example 1:
        ///Input:s1 = “bulls” s2 = “sunny” 
        ///Output : True
        ///Explanation: ‘b’ can be replaced with ‘s’ and similarly ‘u’ with ‘u’, ‘l’ with ‘n’ and ‘s’ with ‘y’.
        ///Example 2:
        ///Input: s1 = “usf” s2 = “add”
        ///Output : False
        ///Explanation: ‘u’ can be replaced with ‘a’, but ‘s’ and ‘f’ should be replaced with ‘d’ to produce s2, which is not possible. So False.
        ///Example 3:
        ///Input : s1 = “ab” s2 = “aa”
        ///Output: False
        /// </summary>
        private static bool Isomorphic(string s1, string s2)
        {
            try
            {

                if (s1.Length != s2.Length)
                {
                    return false;
                }

                var str1Dictionary = new Dictionary<char, char>();//empty dictionary 1
                var str2Dictionary = new Dictionary<char, char>();//empty dictionary 2
                var length = s1.Length;

                for (int i = 0; i < length; i++)
                {
                    if (str1Dictionary.ContainsKey(s1[i]))//if key value of s1 is present in str1Dictionary
                    {
                        if (str1Dictionary[s1[i]] != s2[i])//comparing value of s1 with the key of s2
                        {
                            return false;
                        }
                    }
                    else
                    {
                        str1Dictionary.Add(s1[i], s2[i]);//adding the keys from s1 and s2
                    }

                    if (str2Dictionary.ContainsKey(s2[i]))//if key value of s2 is present in str2Dictionary
                    {
                        if (str2Dictionary[s2[i]] != s1[i])////comparing value of s2 with the key of s1
                        {
                            return false;
                        }
                    }
                    else
                    {
                        str2Dictionary.Add(s2[i], s1[i]);//adding the keys from s2 and s1
                    }
                }

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }


        //Question 7
        /// <summary>
        /// Given a list of the scores of different students, items, where items[i] = [IDi, scorei] represents one score from a student with IDi, calculate each student's top five average.
        /// Print the answer as an array of pairs result, where result[j] = [IDj, topFiveAveragej] represents the student with IDj and their top five average.Sort result by IDj in increasing order.
        /// A student's top five average is calculated by taking the sum of their top five scores and dividing it by 5 using integer division.
        /// Example 1:
        /// Input: items = [[1, 91], [1,92], [2,93], [2,97], [1,60], [2,77], [1,65], [1,87], [1,100], [2,100], [2,76]]
        /// Output: [[1,87],[2,88]]
        /// Explanation: 
        /// The student with ID = 1 got scores 91, 92, 60, 65, 87, and 100. Their top five average is (100 + 92 + 91 + 87 + 65) / 5 = 87.
        /// The student with ID = 2 got scores 93, 97, 77, 100, and 76. Their top five average is (100 + 97 + 93 + 77 + 76) / 5 = 88.6, but with integer division their average converts to 88.
        /// Example 2:
        /// Input: items = [[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100]]
        /// Output: [[1,100],[7,100]]
        /// Constraints:
        /// 1 <= items.length <= 1000
        /// items[i].length == 2
        /// 1 <= IDi <= 1000
        /// 0 <= scorei <= 100
        /// For each IDi, there will be at least five scores.
        /// </summary>
        private static void HighFive(int[,] items)
        {
            try
            {

                var dict = new SortedDictionary<int, List<int>>();//creating empty dictionary
                if (items.Length >= 1 && items.Length <= 1000)//items size is between 1 to 1000
                {
                    if (items.GetUpperBound(1) + 1 == 2)//items columns are equal to 2
                    {
                        for (int x = 0; x < items.GetLength(0); x++)
                        {

                            var studentId = items[x, 0];
                            if (studentId >= 1 && studentId <= 1000)//items key are between 1 to 1000
                            {
                                var score = items[x, 1];
                                if (score >= 1 && score <= 100)//items marks are between 1 to 100
                                {

                                    if (dict.ContainsKey(studentId))
                                    {
                                        dict[studentId].Add(score);
                                    }
                                    else
                                    {
                                        dict[studentId] = new List<int>();
                                        dict[studentId].Add(score);
                                    }
                                }
                            }

                        }
                    }
                }

                var keys = dict.Keys;//taking only keys
                int[,] ans = new int[keys.Count, 2];//creating one empty 2d array
                int i = 0;
                foreach (var student in dict)
                {
                    //ans[i] = new int[2];
                    ans[i, 0] = student.Key;
                    var sum = 0;
                    // sort the score and get the first 5
                    var temp = student.Value.ToArray();
                    Array.Sort(temp);
                    var k = 5;
                    for (int j = temp.Length - 1; j >= 0 && k > 0; j--)
                    {
                        //Console.WriteLine(temp[j]);
                        sum += temp[j];//calculating sum
                        k--;
                    }
                    ans[i, 1] = sum / 5;//total sum divide by 5
                    i++;
                }
                for (int a = 0; a <= ans.GetUpperBound(0); a++)
                {
                    for (int b = 0; b <= ans.GetUpperBound(1); b++)
                    {
                        Console.WriteLine(ans[a, b]);//printing the average for each key value
                    }

                }


            }

            catch (Exception)
            {

                throw;
            }
        }

        //Question 8
        /// <summary>
        /// Write an algorithm to determine if a number n is happy.
        ///A happy number is a number defined by the following process:
        ///•	Starting with any positive integer, replace the number by the sum of the squares of its digits.
        ///•	Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
        ///•	Those numbers for which this process ends in 1 are happy.
        ///Return true if n is a happy number, and false if not.
        ///Example 1:
        ///Input: n = 19
        ///Output: true
        ///Explanation:
        ///12 + 92 = 82
        ///82 + 22 = 68
        ///62 + 82 = 100
        ///12 + 02 + 02 = 1
        ///Example 2:
        ///Input: n = 2
        ///Output: false
        ///Constraints:
        ///1 <= n <= 231 - 1
        /// </summary>

        private static bool HappyNumber(int n)
        {
            try
            {
                var present = new HashSet<int>();//creating one empty hash set
                while (n != 1)//value n not equal to 1
                {
                    present.Add(n);//adding to the hash set
                    int sum = 0;//initializing sum value
                    while (n > 0)//n > 0
                    {
                        int rem = n % 10;//taking the remainder
                        sum += rem * rem;//remainder square added to the sum
                        n = n / 10;//taking quotient value
                    }
                    n = sum;
                    if (present.Contains(n))//if n value is already present returning false
                        return false;
                }

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 9
        /// <summary>
        /// Professor Manish is planning to invest in stocks. He has the data of the price of a stock for the next n days.  
        /// Tell him the maximum profit he can earn from the given stock prices.Choose a single day to buy a stock and choose another day in the future to sell the stock for a profit
        /// If you cannot achieve any profit return 0.
        /// Example 1:
        /// Input: prices = [7,1,5,3,6,4]
        /// Output: 5
        /// Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
        /// Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
        /// Example 2:
        /// Input: prices = [7,6,4,3,1]
        /// Output: 0
        ///Explanation: In this case, no transactions are done and the max profit = 0.
        ///Try to solve it in O(n) time complexity.
        /// </summary>

        private static int Stocks(int[] prices)
        {
            try
            {
                var result = 0;
                if (prices == null || prices.Length < 2) return 0;
                for (int i = 0; i < prices.Length - 1; i++)
                {
                    for (int j = i + 1; j < prices.Length; j++)
                    {
                        result = Math.Max(result, prices[j] - prices[i]);//taking the max value from resulu and the diffrenece between j,i values
                    }
                }

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 10
        /// <summary>
        /// Professor Clinton is climbing the stairs in the Muma College of Business. He generally takes one or two steps at a time.
        /// One day he came across an idea and wanted to find the total number of unique ways that he can climb the stairs. Help Professor Clinton.
        /// Print the number of unique ways. 
        /// Example 1:
        ///Input: n = 2
        ///Output: 2
        ///Explanation: There are two ways to climb to the top.
        ///1. 1 step + 1 step
        ///2. 2 steps
        ///Example 2:
        ///Input: n = 3
        ///Output: 3
        ///Explanation: There are three ways to climb to the top.
        ///1. 1 step + 1 step + 1 step
        ///2. 1 step + 2 steps
        ///3. 2 steps + 1 step
        ///Hint : Use the concept of Fibonacci series.
        /// </summary>

        private static void Stairs(int steps)
        {
            try
            {
                int x = 1, y = 1;
                for (int i = 2; i <= steps; i++)
                {
                    int sum = x + y;
                    x = y;
                    y = sum;
                }

                Console.WriteLine(y);

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}