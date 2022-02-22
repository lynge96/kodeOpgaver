using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// Udskriv resultatet af et plus-stykke

int a = 12;
int b = 30;

int c = a + b;
Console.WriteLine(c);

// Udskriv resultatet af et minus-stykke
int minusStykke = 34 - 23;
Console.WriteLine(minusStykke);

// Udskriv resultatet af et gange-stykke
int gangeStykke = 3 * 23;
Console.WriteLine(gangeStykke);

// Udskriv resultatet af et divisions-stykke der går op 
int ligeDivision = 50 / 2;
Console.WriteLine(ligeDivision);

// Udskriv resultatet af et divisions-stykke der ikke går op 
int uligeDivison = 23 / 2;
Console.WriteLine(uligeDivison);

// Udskriv resultatet af dette divisionsstykke "rest" (kaldes modulo)
int moduloDivision = 21 % 4;
Console.WriteLine(moduloDivision);

// Udskriv resultatet af følgende givne matematikopgaver: 
int stykke1 = -1 + 4 * 6;
Console.WriteLine(stykke1);
try
{
    Assert.AreEqual(stykke1, 26);
}
catch
{
    Console.WriteLine("Kæmpe fejl lol xD");
}

int stykke2 = (35 + 5) % 7;
Console.WriteLine(stykke2);

float stykke3 = 14 + -4 * 6 / 11;
Console.WriteLine(stykke3);

float stykke4 = 2 + 15 / 6 * 1 - 7 % 2;
Console.WriteLine(stykke4);