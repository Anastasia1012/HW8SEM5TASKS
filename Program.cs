using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8SEM5TASKS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Задача 54: Задайте двумерный массив. Напишите программу, 
             * которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8*/
            void PrintArray(int[,]Arr)
            {
                for (int i = 0; i < Arr.GetLength(0); i++)
                { 
                    for (int j = 0; j < Arr.GetLength(1); j++)
                        Console.Write(Arr[i,j] +"\t");
                    Console.WriteLine();
                }  
       
            }
            Console.WriteLine("Задайте двумерный массив. Напишите программу, " +
                "которая упорядочит по убыванию элементы каждой строки двумерного массива.");
            int[,] Array;
            int row;
            int column;
            Console.WriteLine("Введите количество строк");
            row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов");
            column = Convert.ToInt32(Console.ReadLine());
            Array = new int[row, column];
            Random random = new Random();
            for ( int i = 0; i < row; i++ )
            {
                for (int j = 0; j < column; j++)
                    Array[i, j] = random.Next(1, 10);
            }
            PrintArray(Array);
            Console.WriteLine();
            int n;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    for (int k = 0; k < column; k++)
                    {
                        if (Array[i, j] > Array[i, k]) 
                        {
                            n = Array[i, j];
                            Array[i, j] = Array[i, k];
                            Array[i, k] = n;
                        }
                    }
                }
            }
            PrintArray(Array);

            Console.ReadKey();

        }
    }
}
