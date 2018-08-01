using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace CSharpFundamentals
{
    public class Exercises_section_8_lecture68_Strings
    {
        public Exercises_section_8_lecture68_Strings()
        {
            //1 - Write a program and ask the user to enter a few numbers separated by a hyphen.
            //Work out if the numbers are consecutive.For example, if the input is "5-6-7-8-9" or "20-19-18-17-16",
            //display a message: "Consecutive"; otherwise, display "Not Consecutive".

            //Console.WriteLine("Please enter several numbers separated by a hyphen:");
            //var input = Console.ReadLine();
            //var array = input.Split("-");
            //Array.Sort(array);
            //var sorted = String.Join("-", array);

            ////Console.WriteLine(input);
            ////Console.WriteLine(sorted);

            //if (!input.Contains("-"))
            //{
            //    Console.WriteLine("Wrong input fuck face");   
            //}
            //else if (input == sorted)
            //{
            //    Console.WriteLine("Consecutive");
            //}
            //else
            //{
            //    Console.WriteLine("Not Consecutive");
            //}

            //-----------------------------------------------------
            //2 - Write a program and ask the user to enter a few numbers separated by a hyphen
            //If the user simply presses Enter, without supplying an input, exit immediately; otherwise
            //check to see if there are duplicates. If so, display "Duplicate" on the console.

            //Console.WriteLine("Please enter several numbers separated by a hyphen:");
            //string input = Console.ReadLine();

            //var array = input.Split("-");

            //if (String.IsNullOrWhiteSpace(input))
            //{
            //    Console.WriteLine("DONE!");
            //}
            //else if (array.Count() != array.Distinct().Count())
            //{
            //    Console.WriteLine("Duplicate!");
            //}
            //else
            //{
            //    Console.WriteLine("No Duplicates!");
            //}

            //-----------------------------------------------------
            //3 - Write a program and ask the user to enter a time value in the 24 - hour time format(e.g. 19:00)
            //A valid time should be between 00:00 and 23:59.If the time is valid, display "Ok"; 
            //otherwise, display "Invalid Time".If the user doesn't provide any values, consider it as invalid time. 

            //Console.WriteLine("Please enter a time in the 24-hour time format:");
            //var input = Console.ReadLine();
            //var split = input.Split(":");

            ////convert string array into into array
            //var intsplit = Array.ConvertAll(split, int.Parse);

            //if ((intsplit[0] >= 0 && intsplit[0] <= 24) && (intsplit[1] >= 0 && intsplit[1] <= 60))
            //{
            //    Console.WriteLine("OK Time BUD");
            //    Console.WriteLine("Entered time: " + intsplit[0] + ":" + intsplit[1]);
            //}   
            //else 
            //{
            //    Console.WriteLine("Invalid Time Entry FUCK FACE");
            //}

            //-----------------------------------------------------
            //4 - Write a program and ask the user to enter a few words separated by a space
            //Use the words to create a variable name with PascalCase. For example, if the user types: 
            //"number of students", display "NumberOfStudents".Make sure that the program is not dependent on the input
            //So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".

            //Console.WriteLine("Yo please enter some words separated by a space");
            //var input = Console.ReadLine().ToLower();
            //var array = input.Split(" ");
            //var length = array.Length;

            //var i = 0;
            //for (i = 0; i < length; i++)
            //{
            //    array[i] = (array[i].First().ToString().ToUpper()) + (array[i].Substring(1));
            //}

            //Console.WriteLine(String.Join("", array));

            //-----------------------------------------------------
            //5 - Write a program and ask the user to enter an English word. Count the number of vowels(a, e, o, u, i)
            //the word. So, if the user enters "inadequate", the program should display 6 on the console.

            string word = "indadequate";
            char[] array = word.ToCharArray();

            //var counter = 0;
            var i = 0;
            for (i = 0; i < array.Length; i++)
            {
                
            }

        }
    }
};
