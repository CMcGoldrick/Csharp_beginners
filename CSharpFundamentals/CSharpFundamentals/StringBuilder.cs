using System;
using System.Text;

namespace CSharpFundamentals
{
    public class stringBuilder
    {
        public stringBuilder()
        {
            var builder = new StringBuilder();
            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);

            builder.Replace('-', '+');
            //builder.Remove(0, 10);
            //builder.Insert(0, new String('-', 10));

            Console.WriteLine(builder);



        }
    }
}
