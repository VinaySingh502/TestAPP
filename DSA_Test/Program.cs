using System;

namespace DSA_App
{
    class Program
    {
        static void Main(string[] args)
        {
            FindMaximumValueofPairs();
            //CountNumbersOfPairs();
            // PrintPairsTriangle();
            // PrintSquarePattern();
            // PrintallStars();
            //PrintSumOfAllPairs();
            //PrintEvenNumbers();
            //PrintAllPairs();
            // PrintMultiplicationTable();
            //PrintNestedForLoopSum();
            // PrintTotal();
            // PrintTotalForLoop();
        }

        static void PrintTotal()
        {
            int total = 0;
            int i = 1;
            int n = 10; // You can set n to any desired value
            while (i <= n)
            {
                total = total + i;
                i = i + 1;
            }
            Console.WriteLine("The total is: " + total);
        }

        static void PrintTotalForLoop()
        {
            int total = 0;
            int n = 10; // You can set n to any desired value

            for (int i = 1; i <= n; i++)
            {
                total = i + 1;
                for (int j = 1; j <= n; j++)
                {
                    total += j;
                }
            }

            Console.WriteLine("The total using for loop is: " + total);
        }

        static void PrintNestedForLoopSum()
        {
            int n = 10; // You can set n to any desired value
            int total = 1;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    total += i + j; // Example operation: sum of all pairs (i, j)
                }
            }

            Console.WriteLine("The total sum of all pairs (i, j) is: " + total);
        }

        public static void PrintMultiplicationTable()
        {
            int n = 10;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write((i * j) + " ");
                }
                Console.WriteLine();
            }


        }

        public static void PrintAllPairs()
        {
            int n = 10;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.WriteLine($"Pair:{i}, {j}");

                }
            }
        }


        public static void PrintEvenNumbers()
        {
            int count = 0;
            int n = 10; // You can set n to any desired value
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        count++;
                    }

                }
            }
            Console.WriteLine($"Even Pair: {count}");
        }

        public static void PrintSumOfAllPairs()
        {
            int n = 10; // You can set n to any desired value
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    sum = sum + i * j; // Example operation: sum of all pairs (i, j)
                }
            }
            Console.WriteLine("The total sum of all pairs (i, j) is: " + sum);
        }

        public static void PrintSquarePattern()
        {
            int n = 5; // You can set n to any desired value
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i == 1 || i == n || j == 1 || j == n)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  "); // Print space for the inner part of the square
                    }
                }
                Console.WriteLine(); // Add this line to move to the next row
            }
        }


        public static void PrintallStars()
        {
            int n = 5; // You can set n to any desired value

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine(); // Move to the next line after printing stars in a row
            }
            Console.WriteLine(); // Add an extra line for better readability 
        }


        public static void PrintPairsTriangle()
        {
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }

        public static void CountNumbersOfPairs()
        {
            int n = 5;
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i < j)
                    {
                        count++;
                        Console.WriteLine($"Pair {count}: ({i}, {j})");
                    }
                }
            }
            Console.WriteLine($"Total pairs where i < j: {count}");
        }

        // 9. **Find the maximum value of i * j for i and j from 1 to n.**
        public static void FindMaximumValueofPairs()
        {
            int n = 6;
            int maxValue = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    int product = i * j;
                    if (product > maxValue)
                    {
                        maxValue = product;
                    }
                }
            }
            Console.WriteLine($"the maximum value of pair (i, j) for i and j from 1 to {n} is: {maxValue}");
        }

        

    }

}