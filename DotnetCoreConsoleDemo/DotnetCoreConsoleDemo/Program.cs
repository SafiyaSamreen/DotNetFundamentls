using System;
using DotNetStandardLibDemo;

namespace DotnetCoreConsoleDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = args[0];
            DateNameConcatination d = new DateNameConcatination();

            var result = d.GetGreetings(name);

            Console.WriteLine(result);
        }
    }
}
