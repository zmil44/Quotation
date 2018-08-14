/*
 * Zachary Miller
 * 11/6/2017
 * Assignment 1.2 
 * Quotation.cs
 * The purpose of this program is to display my favorite quotation in a console application
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quotation
{
    class Quotation
    {
        static void Main(string[] args)
        {
            displayQuote();//calls displayQuoute
            Console.Read();//pauses the console so that there is time to read the qoute
        }

        static void displayQuote()//displays the quote I have chosen
        {
            Console.WriteLine("'Happiness can be found even in the darkest of times, when one only remembers to turn on the light' - J.K. Rowling");
        }
    }
}
