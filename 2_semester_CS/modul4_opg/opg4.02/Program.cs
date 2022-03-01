using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// Laver et objekt af klassen Dice:
Dice terning = new Dice();
// Bruger Dice metoder
terning.Throw();
terning.show();
// Printer terningen
Console.WriteLine($"Kaster en terning, og den viser {terning.show()} øjne");

// Spørger hvor mange gange terningen skal kastes:
Console.WriteLine("\nHvor mange gange skal terningen kastes?");
int antalKast = int.Parse(Console.ReadLine());

int en = 0;
int to = 0;
int tre = 0;
int fire = 0;
int fem = 0;
int seks = 0;

for (int i = 0; i < antalKast; i++)
{
    terning.Throw();
    Console.Write($"{terning.show()}, ");
    if (terning.show() == 1)
    {
        en++;
    } else if (terning.show() == 2)
    {
        to++;
    } else if (terning.show() == 3)
    {
        tre++;
    } else if (terning.show() == 4)
    {
        fire++;
    } else if (terning.show() == 5)
    {
        fem++;
    } else if (terning.show() == 6)
    {
        seks++;
    }
}
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("\n\nAntal kast af hver:");
Console.ResetColor();
Console.WriteLine($"\nAntal en'ere: {en}");
Console.WriteLine($"Antal to'ere: {to}");
Console.WriteLine($"Antal tre'ere: {tre}");
Console.WriteLine($"Antal fire'ere: {fire}");
Console.WriteLine($"Antal fem'ere: {fem}");
Console.WriteLine($"Antal seks'ere: {seks}");
