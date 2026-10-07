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

            Console.WriteLine("Skriv in ett räknesätt (+, -, *, /)");
            string räknesätt = Console.ReadLine();

            switch(räknesätt)
            {
                case "+":
                    Console.WriteLine(tal1 + tal2);
                    break;
                case "-":
                    Console.WriteLine(tal1 - tal2);
                    break;
                case "*":
                    Console.WriteLine(tal1 * tal2);
                    break;
                case "/":
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
