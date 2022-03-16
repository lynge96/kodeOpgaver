using System;

// Ekstra 8.05 - To-dimensionelle arrays

// I en konsol-applikation, lav en to-dimensionel array med strenge. Den skal indeholde to rækker og tre kolonner. Udskriv i konsollen værdien i den anden række og den tredje kolonne.

// Opretter et to-dimensionelt array:
String[,] array2d;
// 2 rækker, 3 kolonner.
array2d = new String[2, 3] { { "Anders", "Lynge", "Ravnsbæk" }, { "Rikke", "Schouby", "Hein" } };
// Udskriver hele arrayet.
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 3; j++)
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
Console.WriteLine($"--------------------\n" +
    $"Udskriver [1, 2]:" +
    $"\n{array2d[1, 2]}");