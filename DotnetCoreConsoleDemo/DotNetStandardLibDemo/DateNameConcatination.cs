using System;

namespace DotNetStandardLibDemo
{
    public class DateNameConcatination
    {
        public string GetGreetings(string Username)
        {
            var time = DateTime.Now;

            var result = time + " " + "Hello, " + Username;

            return result;
        }
    }
}
