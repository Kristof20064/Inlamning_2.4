using System; 

namespace uppgift_2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad är lönen för den första personen?");
            int först = int.Parse(Console.ReadLine());

            Console.WriteLine("Vad är lönen för den andra personen?");
            int andra = int.Parse(Console.ReadLine());

            Console.WriteLine("Vad är lönen för den tredje personen");
            int tredje = int.Parse(Console.ReadLine());

            int sum = först + andra + tredje;
            int medellön = sum / 2;

            Console.WriteLine("Medellönen av de tre anställda är " + medellön + " kronor.");
        }
        
    }
}