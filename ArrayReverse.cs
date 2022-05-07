using System;

namespace ReversedArray
{
    class Program
    {
        static void Main(string[] args)
        { 
            // Declare and initialize an array
            int[] myArray = { 23, 45, 67, 12 };

            // Create a reversed array
            int[] revArray = new int[myArray.Length];
            
            // Initialize the reversed array
            for(int index = 0; index < myArray.Length; index++)
            {
                revArray[myArray.Length - index - 1] = myArray[index];               
            }

            // Print the reversed array
            for(int index = 0; index < myArray.Length; index++)
            {
                Console.Write(revArray[index] + " ");
            }

            // Reading array from the console
            Console.WriteLine("-------------------------");
            Console.Write("Enter an integer: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            Console.WriteLine("Enter the array: ");
            
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
               
            }
            // Print the array
            for (int index = 0; index < n; index++)
            {

                Console.WriteLine("Element[{0}] = {1}", index, array[index]);
            }

            Console.Read();
        }
    }
}
