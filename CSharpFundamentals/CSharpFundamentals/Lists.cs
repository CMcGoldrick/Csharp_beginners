using System;
using System.Collections.Generic; 

namespace CSharpFundamentals
{
    public class Lists
    {
        public Lists()
        {
            var numbers = new List<int>() { 1, 2, 3, 4 ,1};
            //numbers.Add(1);
            numbers.AddRange(new int[3] { 4, 5, 6 });

            foreach (var n in numbers)
                Console.WriteLine(n);
     
            Console.WriteLine();
            Console.WriteLine(numbers.IndexOf(1));
            Console.WriteLine(numbers.LastIndexOf(1));

            Console.WriteLine("Count: " + numbers.Count);


            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }
            Console.WriteLine("----------");
            foreach (var n in numbers)
                Console.WriteLine(n);


            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count);
        }
    }
}
