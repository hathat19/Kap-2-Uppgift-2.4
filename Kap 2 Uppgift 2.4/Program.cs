using System;
namespace Uppgift2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Frågar lönen för anställd 1
            Console.WriteLine("Hur mycket pengar tjänar anställd 1?");
            int salary1 = int.Parse(Console.ReadLine());

            //Anställd 2 
            Console.WriteLine("Hur mycket pengar tjänar anställd 2?");
            int salary2 = int.Parse(Console.ReadLine());

            //Anställd 3
            Console.WriteLine("Hur mycket pengar tjänar anställd 3?");
            int salary3 = int.Parse(Console.ReadLine());

            //Medellönen
            int average = (salary1 + salary2 + salary3)/3;
            
            //Skriver ut medellönen
            Console.WriteLine($"Medellönen för personalen är {average}kr.");
            Console.ReadKey();
        }
    }
}
