using System;
namespace CSharpFundamentals
{
    public class Arrays
    {
        public Arrays()
        {
            //int[] numbersint = new int[] { 1, 2, 8, 4, 6, 9 };
            var numbers = new[] { 1, 2, 8, 4, 6, 9 };

            //Length
            Console.WriteLine("numbers:" + " " + numbers.Length);

            //IndexOf()
            var index = Array.IndexOf(numbers, 1);
            Console.WriteLine("index of 9: " + "" + index);

            //Clear()
            Array.Clear(numbers, 0, 2);

            Console.WriteLine("Effect of Clear():");
            foreach (var n in numbers)
                Console.WriteLine(n);

            //Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effect of Copy()");
            foreach (var n in another)
                Console.WriteLine(n);

            //Sort()
            Array.Sort(numbers);

            Console.WriteLine("Effect of Sort()");
            foreach (var n in numbers)
                Console.WriteLine(n);

            //Reverse()
            Array.Reverse(numbers);

            Console.WriteLine("Effect of Reverse()");
            foreach (var n in numbers)
                Console.WriteLine(n);
            
                 
        }
    }
}
