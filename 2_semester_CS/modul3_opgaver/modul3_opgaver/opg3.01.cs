using System;
// Opgave 3.01 Reversed Array

// Brugeren bestemmer hvor mange elementer der skal gemmes i dit array, og hvilke værdier der skal gemmes.
// Bagefter svarer du med værdierne i omvendt rækkefølge.

Console.WriteLine("Hvor langt skal dit array være?");
int arrayLængde = int.Parse(Console.ReadLine());

Console.WriteLine($"Skriv {arrayLængde} værdier du vil have i arrayet:");
// Laver et tomt array med den givne længde
int[] array = new int[arrayLængde];

// Laver et loop som spørger efter hvilke værdier der skal gemmes i arrayet.
for (int i = 0; i < arrayLængde; i++)
{
    Console.Write($"Indtast {i + 1}. værdi: ");
    // Indsætter værdier ind i det tomme array:
    array[i] = int.Parse(Console.ReadLine());
}

// Sætter nu værdierne i omvendt rækkefølge.
Array.Reverse(array);
Console.WriteLine("Dit array er nu vendt om. Wooo!");
// Bruger foreach til at printe værdierne i arrayet.
Array.ForEach(array, Console.WriteLine);