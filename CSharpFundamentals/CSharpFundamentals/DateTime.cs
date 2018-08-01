﻿using System;

namespace CSharpFundamentals
{
    public class Datetime
    {
        public Datetime()
        {
            var datetime = new DateTime(2018,1,2);
            var now = DateTime.Now;
            var today = DateTime.Today;
             
            //Console.WriteLine("Hour: " + now.Hour);
            //Console.WriteLine("Minute: " + now.Minute);
            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));
        }
    }
}
