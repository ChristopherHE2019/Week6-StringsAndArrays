using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Sisesta perekonnanimi:");
            string familyName = Console.ReadLine();

            if(familyName.Length < firstName.Length)
            {
                Console.WriteLine("Sinu eesnimi on pikem.");
            }
            else if (familyName.Length > firstName.Length)
            {
                Console.WriteLine("Sinu perekonnanimi on pikem.");
            }
            else
            {
                Console.WriteLine("Su nimed on sama pikad.");
            }
        }
    }
}
