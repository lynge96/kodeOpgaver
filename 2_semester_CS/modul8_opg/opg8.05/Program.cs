using System;

// Ekstra 8.05 - To-dimensionelle arrays

// I en konsol-applikation, lav en to-dimensionel array med strenge. Den skal indeholde to rækker og tre kolonner. Udskriv i konsollen værdien i den anden række og den tredje kolonne.

// Opretter et to-dimensionelt array:
String[,] array2d;
// 2 rækker, 3 kolonner.
array2d = new String[,] { { "Anders", "Lynge", "Ravnsbæk" }, { "Rikke", "Schouby", "Hein" } };
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Printer to-dimensionelt array:");
Console.ResetColor();
// Udskriver hele arrayet.
for (int i = 0; i < array2d.GetLength(0); i++) // .GetLength(0) finder antal rows.
{
    for (int j = 0; j < array2d.GetLength(1); j++) // .GetLength(1) finder antal kolonner.
    {
        if (j == 2)
        {
            Console.Write($"{array2d[i, j]}\n");
        }
        else
        {
            Console.Write($"{array2d[i, j]} ");
        }
    }
}
// Udskriver [2,3], anden række og tredje kolonne:
Console.WriteLine("-----------------------------");
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.WriteLine($"Udskriver [1, 2]:");
Console.ResetColor();
Console.WriteLine($"{array2d[1, 2]}");