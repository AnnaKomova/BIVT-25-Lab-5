using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;

namespace Lab5
{
    public class Purple
    {
        public int[] Task1(int[,] matrix)
        {
            int[] answer = null;

            // code here
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            int c = 0;
            answer = new int[m];
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (matrix[i, j] < 0)
                    {
                        c++;
                    }
                }
                answer[j] = c;
                c = 0;
            }

            //for (int i = 0; i < m; i++)
            //{
            //    Console.Write(answer[i] + " ");
            //}
            //Console.WriteLine();

            // end

            return answer;
        }
        public void Task2(int[,] matrix)
        {

            // code here
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            int min = int.MaxValue;
            int jmin = -1;
            int[] arr = new int[m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (min > matrix[i, j])
                    {
                        min = matrix[i, j];
                        jmin = j;
                    }
                }
                for (int j = 0; j < m; j++)
                {
                    if (min == matrix[i, j])
                    {
                        arr[0] = matrix[i, j];
                    }
                    else if (j < jmin)
                    {
                        arr[j + 1] = matrix[i, j];
                    }
                    else
                    {
                        arr[j] = matrix[i, j];
                    }
                }
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = arr[j];
                }
                min = int.MaxValue;
                jmin = -1;
            }

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write(matrix[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            // end

        }
        public int[,] Task3(int[,] matrix)
        {
            int[,] answer = null;

            // code here
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            int max = int.MinValue;
            int jmax = -1;
            answer = new int[n, m + 1];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (max < matrix[i, j])
                    {
                        max = matrix[i, j];
                        jmax = j;
                    }
                }
                for (int j = 0; j < m; j++)
                {
                    if (j < jmax)
                    {
                        answer[i, j] = matrix[i, j];
                    }
                    else if (j == jmax)
                    {
                        answer[i, j] = matrix[i, j];
                        answer[i, j + 1] = matrix[i, j];
                    }
                    else
                    {
                        answer[i, j + 1] = matrix[i, j];
                    }
                }
                max = int.MinValue;
                jmax = -1;
            }

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m+1; j++)
            //    {
            //        Console.Write(answer[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            // end

            return answer;
        }
        public void Task4(int[,] matrix)
        {

            // code here
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            int sr = 0;
            int c = 0;
            int max = int.MinValue;
            int jmax = -1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (max < matrix[i, j])
                    {
                        max = matrix[i, j];
                        jmax = j;
                    }
                }
                for (int j = jmax + 1; j < m; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        sr += matrix[i, j];
                        c++;
                    }
                }
                if (c != 0)
                    sr /= c;
                for (int j = 0; j < jmax; j++)
                {
                    if (matrix[i, j] < 0 && c != 0)
                    {
                        matrix[i, j] = sr;
                    }
                }


                sr = 0; c = 0;
                max = int.MinValue;
                jmax = -1;
            }

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write(matrix[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            // end

        }
        public void Task5(int[,] matrix, int k)
        {

            // code here
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            int max = int.MinValue;
            int jmax = -1;
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (max < matrix[i, j])
                    {
                        max = matrix[i, j];
                        jmax = j;
                    }
                }
                arr[n - i - 1] = max;
                max = int.MinValue;
                jmax = -1;

            }
            for (int i = 0; i < n; i++)
            {
                if (k < m)
                    matrix[i, k] = arr[i];
            }

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write(matrix[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            // end

        }
        public void Task6(int[,] matrix, int[] array)
        {

            // code here
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            int max = int.MinValue;

            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (max < matrix[i, j])
                    {
                        max = matrix[i, j];
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    if (array.Length == m && max == matrix[i, j] && matrix[i, j] < array[j])
                    {
                        matrix[i, j] = array[j];
                        break;
                    }
                }
                max = int.MinValue;
            }

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write($"{matrix[i, j], 3}");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            // end

        }
        public void Task7(int[,] matrix)
        {

            // code here
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            int[,] answer = new int[n, m];
            int[,] arr = new int[n, 2];
            int min = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (min > matrix[i, j])
                    {
                        min = matrix[i, j];
                        arr[i, 0] = min;
                        arr[i, 1] = i;
                    }
                }
                min = int.MaxValue;
            }

            for (int i = 1; i < n; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    int t = 0;
                    int ti = -1;
                    if (arr[j, 0] > arr[j - 1, 0])
                    {
                        t = arr[j, 0];
                        ti = arr[j, 1];
                        arr[j, 0] = arr[j - 1, 0];
                        arr[j, 1] = arr[j - 1, 1];
                        arr[j - 1, 0] = t;
                        arr[j - 1, 1] = ti;

                    }
                }
            }

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.Write($"{arr[i, j],4}");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    answer[i, j] = matrix[arr[i, 1], j];
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = answer[i, j];
                }
            }

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write($"{matrix[i, j],4}");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            // end

        }
        public int[] Task8(int[,] matrix)
        {
            int[] answer = null;

            // code here
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            if (n != m)
            {
                //Console.WriteLine("null");
                return answer;
            }

            answer = new int[2 * n - 1];
            int sum = 0;

            int i1 = n - 1;
            int j1 = 0;
            int j = 0;
            int i = 0;
            for (int t = 0; t < n * 2 - 1; t++)
            {
                j = j1; //3
                i = i1; //2
                if (t < n - 1)
                {
                    while (j >= 0)
                    {
                        sum += matrix[i, j];
                        j--; i--;
                    }
                    answer[t] = sum;
                    sum = 0;
                    j1++;
                }
                else
                {
                    while (i >= 0)
                    {
                        sum += matrix[i, j];
                        i--; j--;
                    }
                    answer[t] = sum;
                    sum = 0;
                    i1--;
                }
            }

            //for (int i2 = 0; i2 < 2 * n - 1; i2++)
            //{
            //    Console.Write($"{answer[i2], 4}");
            //}
            //Console.WriteLine();

            // end

            return answer;
        }
        public void Task9(int[,] matrix, int k)
        {

            // code here
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);


            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write($"{matrix[i, j], 3}");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            // end

        }
        public int[,] Task10(int[,] A, int[,] B)
        {
            int[,] answer = null;

            // code here


            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write($"{matrix[i, j], 3}");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            // end

            return answer;
        }
        public int[][] Task11(int[,] matrix)
        {
            int[][] answer = null;

            // code here


            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write($"{matrix[i, j], 3}");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            // end

            return answer;
        }
        public int[,] Task12(int[][] array)
        {
            int[,] answer = null;

            // code here


            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write($"{matrix[i, j], 3}");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            // end

            return answer;
        }
    }
}
