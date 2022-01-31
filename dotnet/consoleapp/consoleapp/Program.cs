using System;
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
            greating("ravi");
            greating("anuj");
            greating("achal");
            greating();
        }

    }

}