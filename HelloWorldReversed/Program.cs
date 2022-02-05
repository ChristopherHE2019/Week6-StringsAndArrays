using System;

namespace HelloWorldReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloWorld = "Hello, World!";
            string reversedString = "";


            for (int i = helloWorld.Length - 1; i >= 0; i--)
            {
                reversedString += helloWorld[i];
            }
            Console.WriteLine(reversedString);
        }
    }
}
