using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200226_Array_part2
{
    class Program
    {
        static void Main(string[] args)
        {


            /*
            ============================ * Объявить одномерный (5 элементов ) массив с именем A 
            ============================* и двумерный массив (3 строки, 4 столбца) дробных чисел с именем B. 
            ============================ * Заполнить одномерный массив А числами, введенными с клавиатуры пользователем, 
            ============================ * а двумерный массив В случайными числами с помощью циклов. 
            ============================  * Вывести на экран значения массивов: 
            ============================ * массива А в одну строку, 
            ============================ * массива В — в виде матрицы. 
             * Найти в данных массивах общий максимальный элемент, 
             * минимальный элемент, 
            =========================== * общую сумму всех элементов, 
             * общее произведение всех элементов, 
            =========================== * сумму четных элементов массива А, 
            =========================== * сумму нечетных столбцов массива В.    
             */
            //Console.WriteLine(" *** Exercise 1 ***");

            //int[] A = new int[5];
            //for (int i = 0; i < A.Length; i++)
            //{
            //    A[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("========== >>>>   Array A :");
            //for (int i = 0; i < A.Length; i++)
            //{
            //    //Console.WriteLine($"A[{i}] = {A[i]}");
            //    Console.Write(A[i] + " ");
            //}

            //Console.WriteLine("\n========== >>>>   Array A :");
            //float[,] B = new float[3, 4];
            //Random r = new Random();
            //for (int i = 0; i < B.GetUpperBound(0) + 1; i++)
            //{
            //    for (int j = 0; j < B.GetUpperBound(1) + 1; j++)
            //    {
            //        B[i, j] = r.Next(0, 10);

            //    }
            //}

            //Console.WriteLine("========= >>>>    Array B :");
            //for (int i = 0; i < B.GetUpperBound(0) + 1; i++)
            //{
            //    for (int j = 0; j < B.GetUpperBound(1) + 1; j++)
            //    {
            //        Console.Write("{0} ", B[i, j]);

            //    }
            //    Console.Write("\n");
            //}
            //Console.WriteLine("========= >>>>    Array B :");


            //Console.WriteLine(" ========== >>>>>  FIND MAX  :");


            //int size = 0;
            //float[] arr = new float[size];
            //for (int i = 0; i < B.GetUpperBound(0) + 1; i++)
            //{
            //    for (int j = 0; j < B.GetUpperBound(1) + 1; j++)
            //    {
            //        for (int x = 0; x < A.Length; x++)
            //        {
            //            if (A[x] == B[i, j])
            //            {
            //                Console.WriteLine($"***A[{x}] = {A[x]}");
            //                size++;

            //            }
            //        }
            //    }

            //    Console.Write("\n");
            //}

            //Console.WriteLine($"size = {size}");


            //Console.WriteLine(" <<<< ==========  FIND MAX");

            //int sum1 = 0;
            //float sum2 = 0;
            //for (int i = 0; i < A.Length; i++)
            //{
            //    sum1 += A[i];

            //}
            //for (int i = 0; i < B.GetUpperBound(0) + 1; i++)
            //{
            //    for (int j = 0; j < B.GetUpperBound(1) + 1; j++)
            //    {
            //        sum2 += B[i, j];


            //    }
            //}

            //Console.WriteLine($"Summa1 = {sum1}");
            //Console.WriteLine($"Summa2 = {sum2}");

            //Console.WriteLine($" ========== >>>>>  ALL SUMMA   :  {sum1 + sum2}");


            //int sumA = 0;
            //float sumB = 0;

            //for (int i = 0; i < A.Length; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sumA += A[i];

            //    }
            //}

            //Console.WriteLine($" ========== >>>>>  The sum of the even elements of an array A: {sumA}");

            //for (int i = 0; i < B.GetUpperBound(0) + 1; i++)
            //{
            //    for (int j = 0; j < B.GetUpperBound(1) + 1; j++)
            //    {
            //        if (j % 2 != 0)
            //        {
            //            sumB += B[i, j];

            //        }

            //    }
            //}

            //Console.WriteLine($" ========== >>>>>  The sum of the odd columns in the array: {sumB} ");





            /*
               1. Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100.
                  Определить сумму элементов массива, расположенных между минимальным и максимальным элементами.
             */
            Console.WriteLine(" *** Exercise 2 ***");
            int[,] C = new int[5, 5];
            Random c = new Random();
            for (int i = 0; i < C.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < C.GetUpperBound(1) + 1; j++)
                {
                    C[i, j] = c.Next(-10, 10);

                }
            }

            Console.WriteLine("========= >>>>    Array C :");
            for (int i = 0; i < C.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < C.GetUpperBound(1) + 1; j++)
                {
                    Console.Write("{0}    ", C[i, j]);

                }
                Console.Write("\n");
            }
            Console.WriteLine("========= >>>>    Array C :");

           
            int z1 = 0;
            int index_max_i = 0;
            int index_max_j = 0;
            int z2 = 100;
            int index_min_i = 0;
            int index_min_j = 0;
            for (int i = 0; i < C.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < C.GetUpperBound(1) + 1; j++)
                {
                    if (z1 < C[i, j])
                    {
                        z1 = C[i, j];
                        index_max_i = i; index_max_j = j;
                        Console.Write("\n");
                    }
                    else if (z2 > C[i, j])
                    {
                        z2 = C[i, j];
                        index_min_i = i;
                        index_min_j = j;

                    }

                }
                Console.Write("\n");
            }
            Console.Write($"MAX Element C[{index_max_i},{index_max_j}]= {C[index_max_i, index_max_j]};  MIN Element C[{index_min_i},{index_min_j}] = {C[index_min_i, index_min_j]}");
            Console.Write("\n");
            Console.Write("\n");

            int[,] arr1 = new int[5,5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == 0)
                    {
                        arr1[0, j] = C[index_min_i, j];

                    }
                    else if (i == index_min_i)
                    {
                        arr1[index_min_i, j] = C[0, j];
                    }
                    else
                    {
                        arr1[i, j] = C[i, j];
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($" ARR1 = {0}    ", arr1[i, j]);

                }
                Console.Write("\n");
            }

            /*2. Заполнить массив случайными числами, вывести его на экран. 
           Найти самую длинную последовательность чисел, упорядоченную по возрастанию. 
           Вывести ее на экран. 
           Если таких последовательностей несколько (самых длинных с одинаковой длиной), то вывести их все.
         */

            Random d = new Random();
            int[] D = new int[15];
            for (int i = 0; i < D.Length; i++)
            {
                D[i] = d.Next(10,50);
            }

            for (int i = 0; i < D.Length; i++)
            {
                Console.WriteLine($"D[{i}] = {D[i]}");
            }

            //for (int i = 0; i < D.Length; i++)
            //{
            //    if (D[i] < D[i + 1])
            //    {
            //        Console.WriteLine($"{D[i]}  ");
            //    }
            //}




        }



        


}
}
