using opg4._05;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Laver et objekt af Person ved brug af første constructor:
Person Anders = new Person("0406960269");

// Printer køn for Anders:
Console.WriteLine($"Anders er en {Anders.getSex()}");

// Laver et objekt af Person ved brug af anden constructor:
Person Lars = new Person("Lars", "Larsen", "Dawg", "02052623237");

// Printer navn for Lars:
Console.WriteLine($"\nHans fulde navn er {Lars.getName()}");

// Printer køn for Lars:
Console.WriteLine($"Lars er en {Lars.getSex()}");

// Printer fødselsdag for Lars:
Console.WriteLine($"Lars har fødselsdag d. {Lars.getBirthday()}");

// Printer alder for Lars:
Console.WriteLine($"Lars er {Lars.getAge()} år gammel");
