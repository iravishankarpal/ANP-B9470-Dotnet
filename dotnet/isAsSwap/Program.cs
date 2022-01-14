using System;




namespace isAsSwap
{
    class Program
    {
          static void SwapNum(ref int x, ref int y)  
        {  
  
            int tempswap = x;  
            x = y;  
            y = tempswap;  
                  
        } 
       // taking a class
        public class P { }
  
        // taking a class
        // derived from P
        public class P1 : P { }
        




        static void Main(string[] args)
        {


            // is start
         // creating an instance
        // of class P
        P o1 = new P();
  
        // creating an instance
        // of class P1
        P1 o2 = new P1();

        Console.WriteLine(o1 is P);
  
            // is end


            // as stat
        object[] list1 = new object[5];
    
        list1[0] = "Hello";
        list1[1] = 4759.0;
        list1[2] = null;
  
        for (int q = 0; q < list1.Length; ++q) {
  
            // using as operator
            string str1 = list1[q] as string;
  
            Console.Write("{0}:", q);
  
            // checking for the result
            if (str1 != null) {
                Console.WriteLine("'" + str1 + "'");
            }
            else {
                Console.WriteLine("Is is not a string");
            }
        }

        // as end
        // swap start

             int a = 100;  
           int b = 500;  
            
  
           Console.WriteLine( "Value of a and b before sawapping");  
           Console.WriteLine();  
           Console.WriteLine("a=" + " " + a);  
           Console.WriteLine( "b=" + " " + b);  
           SwapNum(ref a, ref b);  
           Console.WriteLine();  
           Console.WriteLine("Value of a and b after sawapping");  
           Console.WriteLine();  
           Console.WriteLine("a=" + " " + a);  
           Console.WriteLine("b=" + " " + b);  
           Console.ReadLine(); 
        //    swap end
        }
    }
}
