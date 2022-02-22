using System;
// Opgave 3.02 - Sandwichmenu

// Lav en menuvælger til en sandwichbutik. Her får man altid en tilfældig sandwich!
// Lav 3 arrays: brødtype, kød/hovedingrediens, og topping

string[] brødtype = { "Ciabatta", "Toast", "Rugbrød", "Baguette", "Knækbrød" };

string[] ingrediens = { "kylling", "roastbeef", "æggesalat", "spegepølse", "leverpostej" };

string[] topping = { "salat", "ost", "bacon", "ananas", "rucola" };

// Laver et random object:
Random rand = new Random();

// Finder et tilfældigt objekt fra array:
int brødRand = rand.Next(brødtype.Length);
int ingrediensRand = rand.Next(ingrediens.Length);
int toppingRand = rand.Next(topping.Length);

// Udskriver resultatet:
Console.WriteLine($"{brødtype[brødRand]} med {ingrediens[ingrediensRand]} og {topping[toppingRand]}");
Console.WriteLine("Det lyder godt nok lækkert hva'?");