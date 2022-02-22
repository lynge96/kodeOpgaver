using System;

// Opgave 2.02
// Esbjerg Ugeavis leverer avisbundter til deres omdelere efter følgende algoritme:
// Aviserne leveres i bundter á 50 stk. kaldet standardbundter.
// og resten af aviserne leveres i et restbundt.


Console.WriteLine("Hvor mange aviser skal du bede om?");
int antalAviser = int.Parse(Console.ReadLine());

int antalBundter = antalAviser / 50; // Finder antal standardbundter.
int restAviser = antalAviser % 50; // Finder rest antallet.
                                   // Printer antal standardbundter og rest aviser:
Console.WriteLine($"Mate, du får {antalBundter} standardbundter og {restAviser} aviser oveni!!");