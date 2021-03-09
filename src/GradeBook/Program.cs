﻿using System;
using System.Collections.Generic;

namespace GradeBook
{

    class program
    {

        static void Main(string[] args)
        {
            var book = new Book("Jakes Grade Book");

            while (true)
            {
                Console.WriteLine("Please enter a Grade or 'q' to quit");
                var input = Console.ReadLine();

                if (input == "q")
                {
                   break;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade); 
                }   
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("***");
                }
            }
            var stats = book.GetStatistics();

            Console.WriteLine($"The lowest grade is {stats.Low}!");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"The letter grade is {stats.Letter}");

        }
    } 
}