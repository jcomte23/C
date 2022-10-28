using System;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name? Please write your full name");
            var fullName=Console.ReadLine();
            Console.WriteLine("hello "+fullName+", Welcome ,this is my first program");
        }
    }
}
