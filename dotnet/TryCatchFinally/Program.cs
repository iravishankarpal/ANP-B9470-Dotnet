using System;

namespace TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {

// two types of 1 system based exceptionHandeling 2 custom based exceptionHandeling
// Q3 rd 
            // try catch finally 
        try{
            Console.WriteLine("hello");
            int[] num ={1,2,4,5,6};
            Console.WriteLine(num[15]);

        }   
        catch(Exception e){
            Console.WriteLine("something went wrong: {0}" , e);
        } 
        finally{
            Console.WriteLine("its finally");
        }

//  Q5
                    // int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19 , 23, 29 };  
                    //   
                    //  public int FindPrimeNumber(int index)  
                    // {  
                    // if (index < 0 || index >= primes.Length)  
                    // {  
                    // throw new IndexOutOfRangeException();  
                    // }  
                    // return primes[index];  
                    // }  
                    //   
                    // public double DivideNumber(int num1, int num2)  
                    // {  
                    // // If num2 is 0, throw an exception  
                    // if (num2 == 0)  
                    // throw new DivideByZeroException();  
                    // if (num1 < num2)  
                    // num1 += 20;  
                    // return num1 / num2;


        }
    }
}
