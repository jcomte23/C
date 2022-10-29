using System;

namespace MyMethods
{
    class Program
    {
        public void IntegerAddition(int a, int b)
        {
            int Addition = a + b;
            Console.WriteLine("El resultado es " + Addition);
        }

        public int IntegerMultiplication(int a, int b)
        {
            int Multiplication = a * b;
            return Multiplication;
        }

        public static void Main(string[] args)
        {
            Program MyProgram = new Program();
            MyProgram.IntegerAddition(3, 6);

            int result = MyProgram.IntegerMultiplication(12, 2);
            Console.WriteLine("El resultado de la multiplicación es " + result);
            Console.ReadKey();
        }
    }
}

