using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hellow");
            Class1 s = new Class1();
            Console.WriteLine(s);
            s.nano();


            int k = 4;

            Console.WriteLine(k);
            Console.WriteLine(k.GetType());

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

       
          


        }
    }
}
