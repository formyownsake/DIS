using System;

namespace Assignment1_F19
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 22;
            printSelfDividingNumbers(a, b);

            int n2 = 5;
            printSeries(n2);

            int n3 = 5;
            printTriangle(n3);

            int[] J = new int[] { 1, 3 };
            int[] S = new int[] { 1, 3, 3, 2, 2, 2, 2, 2 };
            int r4 = numJewelsInStones(J, S);
            Console.WriteLine(r4);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("End of Jewel");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            int[] arr1 = new int[] { 1, 2, 3, 5, 6, 7, 8 };
            int[] arr2 = new int[] { 1, 2, 3, 4, 6, 7, 8 };
            
            //getLargestCommonSubArray(arr1, arr2);
            

            solvePuzzle();
        }

        public static void printSelfDividingNumbers(int x, int y)
        {
            try
            {
               

                for(int i=x;i<=y;i++)
                {
                    int z = i;
                    bool m = false;
                    
                    while (z != 0)
                    {
                        
                        
                        int a =  z % 10;
                        
                        if (a != 0 && i % a == 0)
                        {
                            m = true; 
                        }
                        else
                        {
                            m = false;
                            break; //break when false comes once
                        }
                        z = z / 10;
                    }

                    if (m)
                    {
                        Console.WriteLine(i + "is self divinding" + m);// Write your code here
                    }
                    
                    
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("End of Self Dividing");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSelfDividingNumbers()");
            }
        }

        

        public static void printSeries(int n)
        {
            try
            {
                int k = 1;
                for (int i = 1; i <= n  ; i++)

                {
                    for (int j = 0; j < i && k <= 5; j++)
                    {
                        Console.Write(i + " ");
                        k++; // k because we want to run process only 5 times
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("End of print series");
                Console.WriteLine(); Console.WriteLine();
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSeries()");
            }
        }

        public static void printTriangle(int n)
        {
            try
            {
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 0; j < +(2 * n - i); j++)  //put space or star in start
                    {
                        if (j >= i)
                        {
                            Console.Write("*");

                        }
                        else
                        {
                            Console.Write(" ");

                        }
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine("End of triangle");
                Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        public static int numJewelsInStones(int[] J, int[] S)
        {
            try
            {
                int lenJ = J.Length;
                int lenS = S.Length;
                int k = 0;
                for (int i = 0; i < lenJ; i++)
                {
                    for (int j = 0; j < lenS; j++)
                    {
                        if (J[i] == S[j])  //equate elements to find common
                        {

                            k++;
                        }
                    }
                }
                return k;
            }

            catch
            {
                Console.WriteLine("Exception occured while computing numJewelsInStones()");
            }

            return 0;
        }

        public static void getLargestCommonSubArray(int[] J, int[] S)
        {
            try
            {
                int[] k = { 0, 0, 0, 0, 0, 0, 0 };

                int lenJ = J.Length;
                int lenS = S.Length;
                int[,] m = new int[2, 4];
                int l = 0;
                for (int i = 0; i < lenJ; i++)
                {
                    for (int j = 0; j < lenS; j++)
                    {
                        if (J[i] == S[j])
                        {
                            k[l] = J[i];
                            Console.WriteLine(k[l]);
                            l++;

                        }
                    }
                }


                Console.ReadLine();
                int lenK = k.Length;
                int g = 0;
                int h = 0;
                int p;
                for (p = 0; p < lenK - 1; p++)
                {
                    if (k[p + 1] - k[p] == 1)
                    {
                        m[g, h] = k[p];
                        h++;
                    }
                    else
                    {

                        m[g, h] = k[p];
                        g++; h = 0;
                    }
                }
                if (k[p] - k[p - 1] == 1)
                { m[h, g] = k[p]; } 
                Console.WriteLine("g  " + g);
                Console.WriteLine("h  " + h);

                for (int i = 0; i <= 4; i++)
                {
                    for (int j = 0; j <= 2; j++)
                    {
                        Console.Write(m[i, j]); /* here i have derived a matrix which has largest common subarray in the lower rows */

                /* I am unable to find the way to get the array from matrix as i am getting out of bounds error */
                    }
                    Console.WriteLine();
                }
                / 
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getLargestCommonSubArray()");
            }

             
        }

        public static void solvePuzzle()
        {
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing solvePuzzle()");
            }
        }
    }
}

