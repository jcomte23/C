using System;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int currentYear = 2022;
            int yearOfBirth; 

            Console.WriteLine("What is your name? Please write your full name");
            var fullName=Console.ReadLine();
            Console.WriteLine("Welcome " + fullName+", this is my first program");
            Console.WriteLine("how old are you?");
            int age=Convert.ToInt32(Console.ReadLine());
            yearOfBirth=currentYear-age;
            Console.WriteLine("you were born in " + yearOfBirth);

        }
    }
}
