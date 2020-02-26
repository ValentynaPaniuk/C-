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
             * сумму четных элементов массива А, 
             * сумму нечетных столбцов массива В.    
             */
            Console.WriteLine(" *** Exercise 1 ***");

            int[] A = new int[5];
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(" ========== >>>>>    Array A :");
            for (int i = 0; i < A.Length; i++)
            {
                //Console.WriteLine($"A[{i}] = {A[i]}");
                Console.Write(A[i] + " ");
            }

            Console.WriteLine("\n========== >>>>>    Array A :");
            float[,] B = new float[3,4];
            Random r = new Random();
            for (int i = 0; i < B.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < B.GetUpperBound(1) + 1; j++)
                {
                    B[i, j] = r.Next(0,10);
                   
                }
            }

            Console.WriteLine(" ========== >>>>>    Array B :");
            for (int i = 0; i < B.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < B.GetUpperBound(1) + 1; j++)
                {
                    Console.Write("{0} ", B[i, j]);

                }
                Console.Write("\n");
            }
            Console.WriteLine(" ========== >>>>>    Array B :");


            Console.WriteLine(" ========== >>>>>  FIND MAX 1  :");

            
            for (int i = 0; i < B.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < B.GetUpperBound(1) + 1; j++)
                {
                    if (B[i, j] == A[i])
                    {
                        Console.WriteLine($"A[{i}] = {A[i]}");
                                
                    }
                }
                Console.Write("\n");
            }
            Console.WriteLine(" ========== >>>>>  FIND MAX 2  :");

            int sum1 = 0;
            float sum2 = 0;
            for (int i = 0; i < A.Length; i++)
            {
               sum1 += A[i];
            
            }
            for (int i = 0; i < B.GetUpperBound(0)+1; i++)
            {
                for (int j = 0; j < B.GetUpperBound(1)+1; j++)
                {
                    sum2 += B[i,j];
                    

                }
            }
            Console.WriteLine(" ========== >>>>>  ALL SUMMA   :");
            Console.WriteLine($"Summa1 = {sum1}");
            Console.WriteLine($"Summa2 = {sum2}");
            Console.WriteLine($"Summa = {sum1+sum2}");
            Console.WriteLine(" ========== >>>>>  ALL SUMMA   :");


            int sumA = 0;
            float sumB = 0;
            Console.WriteLine(" ========== >>>>>  SUMMA A   :");
            for (int i = 0; i < A.Length; i++)
            {
                if (i%2 == 0)
                {
                    sumA += A[i];
                  
                }
            }
            Console.WriteLine($"Summa A = {sumA}");
            Console.WriteLine(" ========== >>>>>  SUMMA A   :");
            Console.WriteLine(" ========== >>>>>  SUMMA B   :");

            for (int i = 0; i < B.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < B.GetUpperBound(1) + 1; j++)
                {
                    if (j % 2 == 0)
                    {
                        sumB += B[i,j];
                       
                    }

                }
            }
            Console.WriteLine($"Summa B = {sumB}");
            Console.WriteLine(" ========== >>>>>  SUMMA B   :");

        }
    }
}
