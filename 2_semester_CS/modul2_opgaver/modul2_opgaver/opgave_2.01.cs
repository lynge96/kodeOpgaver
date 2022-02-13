using System;

namespace opg_2_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave 2.01
            // Spørge efter brugerens navn:
            Console.WriteLine("Hvad er dit navn?");
            string navnInput = Console.ReadLine();
            // Spørge hvor mange timer personen har sovet i nat:
            Console.WriteLine($"Hvor mange timer har du sovet i nat, {navnInput}?");
            int søvnInput = int.Parse(Console.ReadLine());

            if (søvnInput < 8) // Sovet mindre end 8 timer
            {
                Console.WriteLine($"{navnInput}... Du må være træt");
            }
            else // Sovet mere end 8 timer
            {
                Console.WriteLine($"Du ser mega udhvilet ud {navnInput}!");
            }



            // Opgave 2.02
            // Esbjerg Ugeavis leverer avisbundter til deres omdelere efter følgende algoritme:
            // Aviserne leveres i bundter á 50 stk. kaldet standardbundter.
            // og resten af aviserne leveres i et restbundt.


            Console.WriteLine("Hvor mange aviser skal du bede om?");
            int antalAviser = int.Parse(Console.ReadLine());

            int antalBundter = antalAviser / 50; // Finder antal standardbundter.
            int restAviser = antalAviser % 50; // Finder rest antallet.
                                               // Printer antal standardbundter og rest aviser:
            Console.WriteLine($"Mate, du får {antalBundter} standardbundter og {restAviser} aviser oveni!!");


            // Opgave 2.03
            // Lav et program, der beder brugeren indtaste navnet på en måned. 
            // Brug switch til at udskrive hvor mange dage der er i den gældende måned
            // med en default case om at spørge brugeren igen hvis den ikke matchede nogle.

            Console.WriteLine("Indtast en måned!");
            string month = Console.ReadLine().ToLower();
            switch (month)
            {
                case "januar":
                    Console.WriteLine("Der er 31 dage");
                    break;
                case "februar":
                    Console.WriteLine("Der er 28 dage");
                    break;
                case "marts":
                    Console.WriteLine("Der er 31 dage");
                    break;
                case "april":
                    Console.WriteLine("Der er 30 dage");
                    break;
                case "maj":
                    Console.WriteLine("Der er 31 dage");
                    break;
                case "juni":
                    Console.WriteLine("Der er 30 dage");
                    break;
                case "juli":
                    Console.WriteLine("Der er 31 dage");
                    break;
                case "august":
                    Console.WriteLine("Der er 31 dage");
                    break;
                case "september":
                    Console.WriteLine("Der er 30 dage");
                    break;
                case "oktober":
                    Console.WriteLine("Der er 31 dage");
                    break;
                case "november":
                    Console.WriteLine("Der er 30 dage");
                    break;
                case "december":
                    Console.WriteLine("Der er 31 dage");
                    break;
            }

            // Opgave 2.05
            // Fling-Flang Game
            for (int i = 0; i <= 100; i++)
            {
                if (i % 5 == 0 && i % 3 == 0 && i != 0)
                {
                    Console.WriteLine("fling flang");
                }
                else if (i % 3 == 0 && i != 0)
                {
                    Console.WriteLine("fling");
                }
                else if (i % 5 == 0 && i != 0)
                {
                    Console.WriteLine("flang");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            // Opgave 2.06
            // Lav et program som beder om input -> antal gangetabeller der udskrives.
            // Starter ved 1-tabellen.
            // Printes på en linje i formaten: 1x1 = 1, 1x2 = 2 ... 1x10 = 10

            // Beder om input:
            Console.WriteLine("Hvor mange gangetabeller vil du have?");
            int inputTabel = int.Parse(Console.ReadLine());

            // Skal lave 2 loops.
            // Første loop går til og med inputtet:
            for (int i = 1; i <= inputTabel; i++)
            {
                // Andet loop går til 10:
                for (int j = 1; j <= 10; j++)
                {
                    // Laver en if-sætning så det kan printes på én linje og skifte linje til sidst:
                    if (j == 10)
                    {
                        Console.WriteLine($"{i}x{j} = {i * j}");
                    } else
                    {
                        Console.Write($"{i}x{j} = {i * j}, ");
                    }
                }
            }
        }
    }
}