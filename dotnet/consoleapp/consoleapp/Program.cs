﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace consoleapp
{
    class Program
    {
        static void greating(string fname = "students")
        {
            Console.WriteLine($"hello {fname}!!");
        }

        static void Main(string[] args)
        {
             Console.WriteLine("hellow");
            //input
            int j = 11;
            do
            {
                try
                {

                    Console.WriteLine("give a no. 2");
                    j = Convert.ToInt32(Console.ReadLine());
                    break;

                }
                catch (Exception ex)
                {
                    Console.WriteLine("give a no not a charaters \n" + ex);
                }

            } while (j.GetType() == typeof(System.Int32));

            //if else
            if (j > 10)
            {
                Console.WriteLine("j is not > 10 ");
            }
            else if (j > 20)
            {
                Console.WriteLine("j is not greater then 20");
            }
            else
            {
                Console.WriteLine("j < 10");
            }
            //switch 
            switch (j = 2)
            {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2 iam switch");
                    break;
                case 3:
                    Console.WriteLine("1");
                    break;
                default:
                    Console.WriteLine("iam default");
                    break;

            }

            // while loop
            int i = 4;
            while (i > 0)
            {
                Console.WriteLine(i);
                i--;
            }
            //do while

            

            //for loop
            for (i = 1; i <= 10; i++)
            {

                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine($"i am for loop {i}");
            }
            //array and foreach 
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string car in cars)
            {
                Console.WriteLine($"i am foreach loop {car}");
            }

            greating("ravi");
            greating("anuj");
            greating("achal");
            greating();
        }

    }

}