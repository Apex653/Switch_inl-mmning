using System;


namespace switch_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            string ålder = Console.ReadLine();

            switch(ålder)
            {
                case "ålder > 18":
                    Console.WriteLine("Du är vuxen");
                    break;
                case "ålder < 18":
                    Console.WriteLine("Du är inte vuxen");
                    break;
                default:
                    Console.WriteLine("Vet ej");
                    break;
            }

            }




        }
    }

