using System;
// Opgave 3.05 - Temperatur

// Lav en konsol applikation. I main-metoden deklarerer du en variabel temperatur af typen double[]
// Læg mindst 10 tal i det array.

double[] tempArray = { 23, 34, 12, 32, 14, 23, 30, 15, 25, 18, 29, 8, 11, 30, 26 };

// a) Skriv en foreach løkke til at tælle antal temperaturer der er højere end 25 grader og udskriv.
double antalTemp = 0;
foreach (double temperatur in tempArray)
{
    if (temperatur > 25)
    {
        antalTemp++;
    }
}
Console.WriteLine($"Der er {antalTemp} temperaturer i arrayet over 25 grader!");

// b) Skriv en metode GreaterCount med signaturen:
// Som returnerer antal elementer i listen som er større end eller lig med input værdien.

// Metodekald:
int størreVærdier = GreaterCount(tempArray, 16);
Console.WriteLine($"Der er {størreVærdier} værdier som er højere end inputtet.");

// Metodens signatur:
static int GreaterCount(double[] array, double min)
{
    int størreSum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= min)
        {
            størreSum++;
        }
    }
    return størreSum;
}


// EKSTRA opgave
// Skriv en metode randomInRange som taget to integer parametre. Metoden skal returnere en tilfældig integer der er større end eller lig med den første parametre
// og lig med eller mindre end den anden. Brug denne metode til at sætte dine 10 temperaturtal i stedet for selv at indtaste:

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("\nEkstra Opgave:");
Console.ResetColor();
// Metodekald:
double randomTemp = randomInRange(6, 33);
Console.WriteLine(randomTemp);

// Metodens signatur:
static double randomInRange(int min, int max)
{
    Random rand = new Random();
    // Definerer et array med 10 pladser:
    double[] randomTempArray = new double[10];
    for (int i = 0; i < randomTempArray.Length; i++)
    {
        // Indsætter 10 random tal imellem min og max værdien.
        randomTempArray[i] = rand.Next(min, max+1);
    }
    // Printer arrayet:
    foreach (int i in randomTempArray)
    {
        Console.Write($"{i}, ");
    }
    Console.WriteLine("\n\nTilfældigt tal fra temperatur arrayet:");
    // Finder et random index fra arrayet:
    int temp = rand.Next(randomTempArray.Length);
    return randomTempArray[temp];
}