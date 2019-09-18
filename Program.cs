/*
 * Author: Chinmayi Karmalkar 
 * Date: 09/19/2019
 * Comments: This C# Console application consists of the solution to Assignment1
 */




using System;   // ADD COMMENTS WHERE NEEDED

namespace Assignment1
{
    class Program
    {
        static void Main()
        {
            Program p = new Program();

            //1. Self Dividing Numbers
            //Console.WriteLine("1. Self Dividing Numbers");
            //int a = 1, b = 22;
            //p.selfDividingNumbers(a, b);

            //2. Print Series
            //Console.WriteLine("2. Print Series");
            //p.series(5);

            //3. Print Inverse Triangle
            //Console.WriteLine("3. Print inverse Triangle");
            //int n1=5;
            //p.printTriangle(n1);

            //4. Count number of jewels in stones
            //Console.WriteLine("4. Count number of jewels in stones");
            //int[] j= { 1, 3 };
            //int[] s= { 1, 3, 3, 2, 2, 2, 2, 2 };
            //int final=numJewelsInStone(j,s);
            //Console.WriteLine(final);

            //5.Longest Sub Array
            Console.WriteLine("5. Longest Sub Array");
            int[] arr1 = new int[] { 1, 5, 3, 4, 6, 7, 9 };
            int[] arr2 = new int[] { 6, 3, 5, 4, 2 };
            //displayArray(arr1);

            //array to get the largest common sub array
            getLargestCommonSubArray(arr1, arr2);

            //6. Solve Puzzle
            //Console.WriteLine("6. Solve Puzzle");
            //solvePuzzle();

            Console.ReadLine();
        }

        /*void printTriangle(int n)
        {
            try
            {
                int i, k, count = 1;
                //int num = 5;
                for (k = 1; k <= n-1; k++)
                {
                    for (i = 1; i <= count; i++)
                        Console.Write(" ");
                    count++;
                    for (i = 1; i <= 2 * (n - k) - 1; i++)
                        Console.Write("*");
                    Console.WriteLine();
                }
            }
            catch
            {
                Console.WriteLine("Exception while computing PrintTriangle()");
            }
        }*/

        //void selfDividingNumbers(int x, int y)
        //{
        //    try
        //    {
        //        for (int i = x; i <= y; i++)
        //        {
        //            int r1 = isSelfDividing(i);
        //            if (r1 == 1)
        //                Console.WriteLine(i);
        //        }
        //        int isSelfDividing(int n)
        //        {
        //            int temp = n;
        //            while (temp > 0)
        //            {
        //                int d = temp % 10;
        //                if (d == 0 || n % d != 0)
        //                    return 0;
        //                temp = temp / 10;
        //            }
        //            return 1;
        //        }

        //    }
        //    catch
        //    {
        //        Console.WriteLine("Exception occured while running selfDividingNumbers()");
        //    }
        // }

        //void series(int n)
        //{
        //    try
        //    {
        //        //loop to increment numbers 1 to 5
        //        for (int i = 1; i <= n; i++)
        //        {
        //            //loop to print the number equal to its value
        //            for (int j = 1; j <= i; j++)
        //                Console.WriteLine(i);
        //        }
        //    }
        //    catch
        //    {
        //        Console.WriteLine("Exception occured while running Series()");
        //    }

        //}

        //static int numJewelsInStone(int[] a, int[] b)
        //{
        //    try
        //    {
        //        int count = 0;
        //        loop for jewels array
        //        for (int i = 0; i < b.Length; i++)
        //            {
        //                loop for stones array
        //                for (int j = 0; j < a.Length; j++)
        //                    {
        //                        compare to check for common jewels in stones
        //                        if (b[i] == a[j])
        //                            {
        //                                Console.WriteLine(b[i]);
        //                                count++;
        //                            }

        //                    }
        //            }
        //        return count;
        //    }
        //    catch
        //    {
        //        Console.WriteLine("Exception occured while computing numJewelsInStones()");
        //    }
        //    return 0;
        //}

        public static void getLargestCommonSubArray(int[] m, int[] n)
        {
            int min_position; //to keep of lowest element position
            int temp; //for swap

            //sort array1 - Selection Sort
            //Console.WriteLine("Array 1 Sorted");
            for (int i=0; i<m.Length;i++)
            {
                min_position = i;

                for(int j=i+1; j<n.Length;j++)
                {
                    if (m[j]<m[min_position])
                    {
                        min_position =j;
                    }
                }

                if(min_position!=i)
                {
                    temp = m[i];
                    m[i] = m[min_position];
                    m[min_position] = temp;
                }
                //Console.Write(" " + m[i]);
            }

            //Console.WriteLine("\n Array 2 sorted ");

            //sort array2 - Selection Sort
            for (int i = 0; i < n.Length; i++)
            {
                min_position = i;

                for (int j = i + 1; j < n.Length; j++)
                {
                    if (n[j] < n[min_position])
                    {
                        min_position = j;
                    }
                }

                if (min_position != i)
                {
                    temp = n[i];
                    n[i] = n[min_position];
                    n[min_position] = temp;
                }
                //Console.Write(" " + n[i]);
            }

            int lim;
            //Console.WriteLine("\n***");
            //checking lengths of the arrays
            if (m.Length < n.Length)
                lim = m.Length;
            else
                lim = n.Length;

            //array to store the final values of the common elements from both arrays
            int[] final = new int[10];

            for (int k=0;k<lim;k++)
            {
                if (m[k] == n[k])
                    final[k] = m[k];
            }

            Console.WriteLine("\n\nFinal Array");
            for (int l = 0; l < final.Length; l++)
            {
                if (final[l] == 0)
                    continue;
                else
                    Console.Write(" " + final[l]);
            }
        }

        //public static void displayArray(int[] a)
        //{
            
        //}



        //void solvePuzzle()
        //{
        //    //input strings - ask for input string and output strings - method to collect inputs

        //    //method to identify unique characters in the string

        //    //method to test assigned values 

        //    //return void
        //}
    }
}

