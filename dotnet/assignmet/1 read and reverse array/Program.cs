using System;

namespace _1_read_and_reverse_array
{
    class Program
    {
        static void Main(string[] args)
        {
            
        // Write a program in C# Sharp to read n number of values in an array and display it in reverse order.

  
                  

   int[] list = { 29, 15, 30, 98};
         int[] temp = list;
         Console.Write("Original Array: ");
         foreach (int i in list) {
            Console.Write(i + " ");
         }
         Console.WriteLine();
         // reverse the array
         Array.Reverse(temp);
         Console.Write("Reversed Array: ");
         foreach (int i in temp) {
            Console.Write(i + " ");
         }
         Console.ReadKey();
        }
    }
}
