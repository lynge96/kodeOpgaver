using System;

// Spørger brugeren hvor mange ting der skal i listen:
Console.BackgroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Hvor mange ting skal der være i listen?");
Console.ResetColor();
int antalItems = int.Parse(Console.ReadLine());

// Opretter en liste.
List<int> nyListe = new List<int>();
nyListe = opretListe(antalItems, nyListe);

// Printer listen:
Console.BackgroundColor = ConsoleColor.DarkRed;
Console.WriteLine($"\nListen er fyldt med {antalItems} tilfældige tal fra 0 - 100");
Console.ResetColor();

foreach (int item in nyListe)
{
    Console.Write($"{item}, ");
}


// Finder det højeste tal i listen:
int højesteInt = højesteTal(nyListe);
Console.WriteLine($"\n\nDet højeste tal i listen er: {højesteInt}");


// Tjekker om tal er i listen:
Console.BackgroundColor = ConsoleColor.DarkRed;
Console.WriteLine("\nHvilke tal skal tjekkes i listen?");
Console.ResetColor();

int inputTal = int.Parse(Console.ReadLine());

bool talTjek = tjekTal(inputTal, nyListe);
Console.WriteLine($"\nFindes tallet {inputTal} i listen?: {talTjek}");


// Metode til at fylde liste:
static List<int> opretListe(int tal, List<int> liste)
{
    // Laver en random variabel
    Random rng = new Random();
    // Skyder random tal ind i listen:
    for (int i = 0; i < tal; i++)
    {
        liste.Add(rng.Next(100));
    }
    return liste;
}

// Metode til at finde det højeste tal:
static int højesteTal(List<int> liste)
{
    int højesteTal = liste.Max();
    return højesteTal;
}


// Metode til at tjekke om tallet er i listen
static Boolean tjekTal(int tal, List<int> liste)
{
    if (liste.Contains(tal))
    {
        return true;
    }
    return false;
}