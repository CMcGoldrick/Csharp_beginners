using System;
namespace CSharpFundamentals
{
    public class Conditionals
    {
        public Conditionals()
        {
            //int num;
            //Console.WriteLine("Enter a number: ");
            //num = Convert.ToInt32(Console.ReadLine());

            //if (num > 1 && num < 10)
            //{
            //    Console.WriteLine("Valid!");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid!");
            //}

            //-------------
            //Console.WriteLine("Enter a number:");
            //var input1 = Console.ReadLine();
            //int num1 = Convert.ToInt32(input1);

            //Console.WriteLine("Enter another number:");
            //var input2 = Console.ReadLine();
            //int num2 = Convert.ToInt32(input2);

            //if (num1 > num2)
            //    Console.WriteLine(num1);
            //else 
            //Console.WriteLine(num2);

            //---------------

            //Console.WriteLine("Enter the height");
            //int height = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the width");
            //int width = Convert.ToInt32(Console.ReadLine());

            //if (height > width)
            //    Console.WriteLine("Portrait");
            //else
            //Console.WriteLine("Landscape");

            //---------------

            //Console.WriteLine("Enter the SPEED!");
            //int speed = Convert.ToInt32(Console.ReadLine());
            //int speedlimit = 50;

            //int demerit = 0;
            //int overage = (speed - speedlimit);

            //if (speed < speedlimit)
            //    Console.WriteLine("OK");
            //else
            //{
            //    demerit = (overage / 5);
            //    if (demerit >= 12)
            //        Console.WriteLine("License Suspended motherfucker!");
            //    else
            //        Console.WriteLine($"Too Fast!!\n Demerit Points: {demerit}");
            //}

            //---------------
            //1 - Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.Display the count on the console.
            //var x = 0;
            //var counter = 0;
            //for (x = 1; x < 100; x++)
            //{
            //    if (x % 3 == 0)
            //    {
            //        counter++;
            //    }
            //}

            //Console.WriteLine($"there are {counter} numbers divisible by 3");

            //---------------
            //2 - Write a program and continuously ask the user to enter a number or "ok" to exit. 
            //Calculate the sum of all the previously entered numbers and display it on the console.

            //int counter = 0;

            //while(true)
            //{
            //    Console.WriteLine("Please enter a number or type 'ok' to exit");
            //    var input = Console.ReadLine();
            ////BY DEFAULT READLINE TAKES IN A STRING

            //    if (input == "ok")
            //    {
            //        Console.WriteLine($"Bye!\nTotal amount is:{counter}");
            //        break;
            //    }

            //    counter += Convert.ToInt32(input);
            //}
            //---------------
            //3 - Write a program and ask the user to enter a number. Compute the 
            //factorial of the number and print it on the console. For example, 
            //if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

            //Console.WriteLine("Please enter a number:");
            //int num = Convert.ToInt32(Console.ReadLine());

            //var x = 0;
            //int counter = 1;
            //for (x = num; x > 0; x--)
            //{
            //    counter = counter * num;
            //    num = num - 1;
            //}

            //Console.WriteLine(counter);

            //---------------
            //4 - Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number.
            //If the user guesses the number, display “You won"; otherwise, display “You lost". 
            //(To make sure the program is behaving correctly, you can display the secret number on the console first.)

            //int random = new Random().Next(1, 10);
            //Console.WriteLine(random);

            //Console.WriteLine("Please enter 4 numbers between 1 and 10 and we'll tell you if you guessed the right number.");

            //Console.WriteLine("number 1:");
            //int input1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("number 2:");
            //int input2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("number 3:");
            //int input3 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("number 4:");
            //int input4 = Convert.ToInt32(Console.ReadLine());

            //if (input1 == random || input2 == random || input3 == random || input4 == random)
            //{
            //    Console.WriteLine("You won!");
            //}
            //else
            //{
            //    Console.WriteLine("You lost!!");
            //}

            //ALTERNATIVE SOLUTION
            //var number = new Random().Next(1, 10);

            //Console.WriteLine("Secret is " + number);
            //for (var i = 0; i < 4; i++)
            //{
            //    Console.Write("Guess the secret number: ");
            //    var guess = Convert.ToInt32(Console.ReadLine());

            //    if (guess == number)
            //    {
            //        Console.WriteLine("You won!");
            //        return;
            //        //THIS TERMINATES THE METHOD
            //    }
            //}
            //Console.WriteLine("You lost!");

            //---------------
            //5 - Write a program and ask the user to enter a series of numbers separated by comma.
            //Find the maximum of the numbers and display it on the console. For example, if the user enters 
            //“5, 3, 8, 1, 4", the program should display 8.

            //Console.WriteLine("Enter comma separated numbers: ");
            //var input = Console.ReadLine();

            //var numbers = input.Split(',');

            //var max = Convert.ToInt32(numbers[0]);

            //foreach (var str in numbers)
            //{
            //    var number = Convert.ToInt32(str);
            //    if (number > max){
            //        max = number;
            //    }
            //}
            //Console.WriteLine($"the max number is: {max} ");

            //---------------

        }
    }
}
