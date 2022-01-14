using System;
using System.Text.RegularExpressions;

namespace regularExpresion
{
    class Program
    {
        static void Main(string[] args)
        {

            // reguqlar expression text
            Regex r = new Regex(@"^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}"); 
            string[]str={"+91-9678967101","9678967101","+91-9678-967101","+91-96789-67101","+919678967101"};
            foreach(string s in str)
            {
                Console.WriteLine("{0}{1} avalid mobile number.",s,r.IsMatch(s)?" is ":" is not");
                };

// email test 
  
            string email  = "iravishankarpal@gmail.com";
            var result = Regex.IsMatch(email, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");


            Console.Write("is valid email :{0}",result);
            Console.ReadLine();
    




// password check
                string regularExpression = @"^(?=.?\d.?\d)(?=.?\w.?\w)[\d\w]{8,20}$"; 
            Console.WriteLine("Please input password for check:");  
            string inputString = Console.ReadLine();  
            var check = Regex.IsMatch(inputString, regularExpression);
            if (check == true){
            Console.WriteLine("between 8 to 20  it's right");
                
            }
            else{
                Console.WriteLine("not between 8 to 20 it's wrong");
            }
        //   Regex.IsMatch(inputString, regularExpression) {  
        //         Console.WriteLine("It's correct security password");  
        //     } else {  
        //         Console.WriteLine("It's incorrect Security Password.");  
        //     }  
        //     Console.Read();  
        }
    }
}
