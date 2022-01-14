using System;

namespace stingsArray
{
    class Program
    {
        static void Main(string[] args)
        {

            

            char[] charArray={'C','o','d','e','s','D','o','p','e'};
            String s = new String(charArray);
            Console.WriteLine(s + " equal");


            string a="Codes";
            string b="Dope";
            int x=String.Compare(a,b);
            int y=String.Compare(b,a);
            Console.WriteLine(x);
            Console.WriteLine(y);



            string c = string.Concat(a,b);
            Console.WriteLine(c + " concat");


            Console.WriteLine(a.Equals(b) + " equal");



            string d="CodesDope";
            Console.WriteLine(d.IndexOf('D')+ " Index");


            Console.WriteLine(d.LastIndexOf('o') + " lastIndex");



            string r=d.Replace("Dope","Codes");
            Console.WriteLine(r + "   replace");


            string sub=d.Substring(5);
            Console.WriteLine(sub + "    substring");

            Console.WriteLine(d.ToLower() + "   lower");
             Console.WriteLine(d.ToUpper()  + "   upper");



        }
    }
}
