﻿using System;
using System.Collections.Generic;

namespace GradeBook
{

    class program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a students names");

            var book = new DiskBook(Console.ReadLine() + "'s GradeBook");
            book.GradeAdded += OnGradeAdded;

            EnterGrade(book);

            var stats = book.GetStatistics();

            Console.WriteLine($"For the book {book.Name}");
            Console.WriteLine($"The lowest grade is {stats.Low}!");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"The letter grade is {stats.Letter}");

        }

        private static void EnterGrade(IBook book)
        {
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
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("***");
                }
            }
        }

        static void OnGradeAdded(object sender, EventArgs e)
        {

        }
    }
}