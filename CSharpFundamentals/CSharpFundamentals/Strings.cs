using System;
namespace CSharpFundamentals
{
    public class Strings
    {
        public Strings()
        {
            //String format specifiers: https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings#the-currency-c-format-specifier

            var fullName = "Ciaran McGoldrick ";

            //Trim removes whitespace before and after string. This can be useful for using user input.
            Console.WriteLine(fullName.Trim());
            Console.WriteLine(fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);

            var names = fullName.Split(' ');
            Console.WriteLine("Firstname: " + names[0]);
            Console.WriteLine("Lastname:  " + names[1]);

            fullName.Replace("Ciaran", "Legend");
            fullName.Replace("a", "o");
            fullName.Replace(" ", "-");
            // Strings are immutable. Original string is not affected by any of these method calls. 

            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("invalid");

            var str = "25";
            Convert.ToString(str);
            Convert.ToByte(str);

        }
    }
}
