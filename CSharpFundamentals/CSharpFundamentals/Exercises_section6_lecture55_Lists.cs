using System;
using System.Linq;
using System.Collections.Generic; 

namespace CSharpFundamentals
{
    public class Exercises_section6_lecture55
    {
        public Exercises_section6_lecture55()
        {
            //exercise1
            //var names = new List<string>() { };

            //Console.WriteLine("Please enter names, hit Enter when you're done");

            //while (true)
            //{
            //    Console.Write("Name: ");
            //    string input = Convert.ToString(Console.ReadLine());

            //    if (String.IsNullOrWhiteSpace(input))
            //        break;

            //    names.Add(input); 
            //}

            //if (names.Count == 0)
            //{
            //    Console.WriteLine("-___-");
            //}
            //else if (names.Count == 1)
            //{
            //    Console.WriteLine(names[0] + " Likes your post");
            //}
            //else if (names.Count == 2)
            //{
            //    Console.WriteLine(names[0] + " and " + names[1] + " Like your post");
            //}
            //else
            //{
            //    Console.WriteLine(names[0] + ", " + names[1] + " and " + (names.Count - 2) + " other people like your post :)");
            //}


            //exercise2
            //YOU CANNOT RESIZE ARRAYS - THEREFORE DEFINE THE SIZE IF YOU WANT TO ADD VALUES!
            //Console.WriteLine("Please enter your name: ");
            //string name = Console.ReadLine();
            //char[] arr = new char[name.Length];

            //int x = 0;

            //for (var i = (name.Length - 1); i >= 0; i--)
            //{
            //    arr[x] = name[i];
            //    x++;
            //    // IF YOU HAVE MORE THAN ONE LINE IN A LOOP. PUT BETWEEN QUOTES!!!!!!
            //}

            //foreach (var n in arr)
            //Console.Write(n);
            //Console.WriteLine();


            //exercise3
            //3 - Write a program and ask the user to enter 5 numbers.If a number has been previously entered, 
            //display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, 
            //sort them and display the result on the console.

            //int[] array = new int[5];

            //Console.WriteLine("Hi there! Please enter 5 unique numbers:");

            //while(true)
            //{
            //    var x = 1;
            //    for (var i = 1; i <= 5; i++)
            //    {
            //        Console.Write($"#{x++}: ");
            //        int input = Convert.ToInt32(Console.ReadLine());

            //        if (array.Contains(input))
            //        {
            //            Console.WriteLine($"ERROR, you entered #{input} already. Try again putita....");
            //            Array.Clear(array, 0, array.Length);
            //            break;
            //        }

            //        array[i - 1] = input;
            //    }

            //    if (array[4] != 0)
            //        break;
            //}

            //Array.Sort(array);
            //Console.WriteLine("Here is are your sorted numbers: ");

            //foreach (var y in array)
            //Console.Write(y);
            //Console.WriteLine();


            //4 - Write a program and ask the user to continuously enter a number or type "Quit" to exit.
            //The list of numbers may include duplicates. Display the unique numbers that the user has entered.

            //Console.WriteLine("Enter a number or type 'Quit' to exit: ");

            //var numbers = new List<string>();

            //while(true)
            //{
            //    var input = Console.ReadLine();

            //    if (input.ToLower() == "quit")
            //        break;

            //    if (numbers.Contains(input))
            //        continue;

            //    numbers.Add(input);
            //}

            //foreach (var m in numbers)
            //Console.WriteLine(m);


            //5 - Write a program and ask the user to supply a list of comma separated numbers(e.g 5, 1, 9, 2, 10). 
            //If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; 
            //otherwise, display the 3 smallest numbers in the list.

            //while (true)
            //{
            //    Console.WriteLine("Please enter a list of numbers separated by a comma ',' ");
            //    string input = Console.ReadLine();

            //    List<int> numbers = input.Split(',').Select(int.Parse).ToList();
            //    //  THIS IS THE SAME THING
            //    //List<int> numbers = new List<int>(input.Split(',').Select(int.Parse));

            //    if (numbers.Count() == 0 || numbers.Count < 5)
            //    {
            //        Console.WriteLine("INVALID LIST! \nTry again please:");
            //        numbers.Clear();
            //    }
            //    else
            //    {
            //        numbers.Sort();
            //        Console.WriteLine($"These are the smallest three numbers: \n   {numbers[0]}, {numbers[1]}, {numbers[2]}");
            //        break;
            //    }
            //}

        }
    }
}
