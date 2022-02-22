using System;

// Opgave 2.03
// Lav et program, der beder brugeren indtaste navnet på en måned. 
// Brug switch til at udskrive hvor mange dage der er i den gældende måned
// med en default case om at spørge brugeren igen hvis den ikke matchede nogle.

Console.WriteLine("Indtast en måned!");
string month = Console.ReadLine().ToLower();
switch (month)
{
    case "januar":
        Console.WriteLine("Der er 31 dage");
        break;
    case "februar":
        Console.WriteLine("Der er 28 dage");
        break;
    case "marts":
        Console.WriteLine("Der er 31 dage");
        break;
    case "april":
        Console.WriteLine("Der er 30 dage");
        break;
    case "maj":
        Console.WriteLine("Der er 31 dage");
        break;
    case "juni":
        Console.WriteLine("Der er 30 dage");
        break;
    case "juli":
        Console.WriteLine("Der er 31 dage");
        break;
    case "august":
        Console.WriteLine("Der er 31 dage");
        break;
    case "september":
        Console.WriteLine("Der er 30 dage");
        break;
    case "oktober":
        Console.WriteLine("Der er 31 dage");
        break;
    case "november":
        Console.WriteLine("Der er 30 dage");
        break;
    case "december":
        Console.WriteLine("Der er 31 dage");
        break;
}