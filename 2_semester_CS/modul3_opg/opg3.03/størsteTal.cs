using System;
// Opgave 3.03 - Største tal

// Lav et array og fyld den med 7 integers.
// Find ud af, hvilket tal der er det højeste og skrive det ud i konsollen - for og if sætninger.

int[] array = { 54, 75, 34, 132, 76, 23, 78 };

int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    // Finder det højeste tal i arrayet og erstatter sum variablen:
    if (array[i] > sum)
    {
        sum = array[i];
    }
}
// Udskriver det højeste tal i arrayet:
Console.WriteLine(sum);