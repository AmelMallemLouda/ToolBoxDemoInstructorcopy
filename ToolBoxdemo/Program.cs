﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBoxdemo
{
    class Program
    {
        static void Main(string[] args) // acts as our program's aka executable. This is the file double click on to start any program
        {

            Console.WriteLine("Welcome to your tool Box");
            KeyToContinue();

            Console.ReadLine();


            // Functions are methods written outside of a custum class
            // Methods are functions written inside of a custum class


            //functions below this line

            void KeyToContinue()
            {

                Console.WriteLine("Hit ENTER to clear the Console and continue on with the code...");
                Console.ReadLine();
                Console.ReadLine();
            }

            void ClearConsole()
            {

               Console.Clear();
                Console.WriteLine("Congratulations! You've cleared the console!... hit enter to close the programm");
            
            }
        }
    }
}
