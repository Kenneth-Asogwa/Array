using System;

namespace MultidimentionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multidimensional Arrays(Matrices)");
            int[,] matrix = { { 23, 45, 12, 34 }, { 13, 45, 67, 67 }, };

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                { 
                    Console.Write(" " + matrix[row, col]);

                }
                Console.WriteLine();
            }  
            Console.WriteLine("Multidimensional Arrays using console input");
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of columns: ");
            int cols = int.Parse(Console.ReadLine());
            // Initialize the matrix
            int[,] intMatrix = new int[rows, cols];

            Console.WriteLine("Enter the cells of the matrix: ");
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("Matrix[{0},{1}] = ", row, col);
                    intMatrix[row, col] = int.Parse(Console.ReadLine());
                }
            }
            for (int row = 0; row < intMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < intMatrix.GetLength(1); col++)
                {

                    Console.Write(" " + intMatrix[row, col]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Jagged Arrays(Pascal Triangle)");
            // Get the height of the array
            Console.Write("Enter the height of the triangle: ");
            int height = int.Parse(Console.ReadLine());

            // Allocate the array in a triangle form
            long[][] triangle = new long[height + 1][];
            for(int row = 0; row < height; row++)
            {
                triangle[row] = new long[row + 1];
            }
            // Calculate the Pascal's triangle
            triangle[0][0] = 1;
            for(int row = 0; row <  height - 1; row++)
            {
                for(int col = 0; col <= row; col++)
                {
                    triangle[row + 1][col] += triangle[row][col];
                    triangle[row + 1][col + 1] += triangle[row][col];
                }        
            }
            // Print the Pascal's  triangle
            for(int row = 0; row < height; row++)
            {
                Console.Write(" ".PadRight((height - row) * 2));
                for (int col = 0; col <= row; col++)
                {
                    Console.Write("{0,3} ", triangle[row][col]);
                }
                Console.WriteLine();

            }
            Console.Read();

        }
    }



}
     

