using System;

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