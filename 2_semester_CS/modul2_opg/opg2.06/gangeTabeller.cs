using System;

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
        }
        else
        {
            Console.Write($"{i}x{j} = {i * j}, ");
        }
    }
}