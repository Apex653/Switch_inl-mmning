using System;


namespace switch_inlämmning5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in 2 heltal på 2 rader");
            int tal1 = int.Parse(Console.ReadLine());
            int tal2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Välj ett räknesätt");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");

            int räknesätt = int.Parse(Console.ReadLine());



            switch(räknesätt)
            {
                case 1:
                    Console.WriteLine(tal1 + tal2);
                    break;
                case 2:
                    Console.WriteLine(tal1 - tal2);
                    break;
                case 3:
                    Console.WriteLine(tal1 * tal2);
                    break;
                case 4:
                    {
                        Console.WriteLine(tal1 / tal2);
                    }
                    break;
                default:
                    Console.WriteLine("Ogiltigt räknesätt");
                    break;

            }



        }
    }
}
