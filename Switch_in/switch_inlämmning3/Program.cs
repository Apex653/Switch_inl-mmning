using System;
using System.Resources;


namespace switch_inlämmning3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många timmar vill du hyra bilen?");
            Console.WriteLine("Svara i hela timmar");
            int timmar = int.Parse(Console.ReadLine());
            int kostnad = timmar * 80;

            if (kostnad > 950)
            {
                kostnad = 950;
            }

            Console.WriteLine("Det kommer att kosta " + kostnad + " kronor");


            





        }
    }
}
