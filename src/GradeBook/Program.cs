using System;
using System.Collections.Generic;

namespace GradeBook
{
 
   class program
   {

       static void Main(string[] args)
       {
           
           var numbers = new [] {12.7, 10.3, 6.11} ;

           var result = 0.0;
           foreach(double number in numbers)
           {
               result += number;
           }
            Console.WriteLine(result);

           if(args.Length > 0)
           {
               Console.WriteLine($"Hello {args[0]}!");
           }
           else
           {
               System.Console.WriteLine("generic hello");
           }
       }
   }
} 