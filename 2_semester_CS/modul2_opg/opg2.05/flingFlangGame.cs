using System;

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