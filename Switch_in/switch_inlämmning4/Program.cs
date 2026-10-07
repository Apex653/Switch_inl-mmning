using System;


namespace switch_inlämmning4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur lång är låten i 2 heltal?");
            Console.WriteLine("Skriv på 2 rader");
            int minuter = int.Parse(Console.ReadLine());
            int sekunder = int.Parse(Console.ReadLine());

            if (minuter >= 4 || (minuter == 4 && sekunder > 20))
            {
                Console.WriteLine("Låten är för lång för att spelas i radio");
            }
            else if ( minuter <= 2 || (minuter == 2 && sekunder < 20))
            {
                Console.WriteLine("Låten är för kort för att spelas i radio");
            }
            else
            {
                Console.WriteLine("Låten är lagom lång för att spelas i radio");
            }



        }
    }
}
