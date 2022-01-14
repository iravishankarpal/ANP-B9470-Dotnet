using System;

namespace toStringHashcode
{
    class Program
    {
        static void Main(string[] args)
        {


        // tostring start
           var a = 10;
           Console.WriteLine(a);
         Console.WriteLine(a.GetType());

        //    conver to string
           var x = a.ToString();

           Console.WriteLine(x.GetType());

        //    tostrinig end
        // hashcode start
        // string name = 'ravi';
        // Console.WriteLine(name + "  " + name.GetType());

        // hashcode end
        }
    }
}
