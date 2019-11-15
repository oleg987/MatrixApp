using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Roads();

            //Bridges();
        }

        private static void Bridges()
        {
            Console.Write("Enter matrix size: ");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter colours count: ");
            int colours = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            matrix = FillMatrix(size);

            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = 0; j < size; j++)
            //    {
            //        Console.Write(matrix[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            Console.WriteLine($"\n\nBridges: {BridgesCounter(matrix, GetColoursArray(colours, size))}");
        }

        private static int BridgesCounter(int[,] matrix, int[] colours)
        {
            int counter = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i < j && matrix[i, j] == 1 && colours[i] != colours[j])
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }

        private static int[] GetColoursArray(int colourCount, int arraySize)
        {
            int[] colours = new int[arraySize];
            Random r = new Random();

            for (int i = 0; i < arraySize; i++)
            {
                colours[i] = r.Next(colourCount + 1);
            }

            return colours;
        }

        private static void Roads()
        {
            Console.Write("Enter matrix size: ");
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            matrix = FillMatrix(size);

            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = 0; j < size; j++)
            //    {
            //        Console.Write(matrix[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            Console.WriteLine($"\n\nRoads: {RoadCounter(matrix)}");
        }

        private static int RoadCounter(int[,] matrix)
        {
            int counter = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i < j && matrix[i, j] == 1)
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }

        private static int[,] FillMatrix(int size)
        {
            int[,] matrix = new int[size, size];
            Random r = new Random();

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if(i == j)
                    {
                        matrix[i, j] = 0;
                    }
                    else if(i < j)
                    {
                        matrix[i, j] = r.Next(2);
                        matrix[j, i] = matrix[i, j];
                    }                    
                }
            }
            return matrix;
        }
    }
}
