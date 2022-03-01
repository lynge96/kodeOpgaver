using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// Opretter et objekt af klassen vehicle med constructor 1:
Vehicle Ferrari = new Vehicle("DA 45 622", "Rød");
// Printer parametrerne på bilen:
Console.WriteLine($"Bilen har farven {Ferrari.colour} og registrerings nummer {Ferrari.regno}");

// Opretter et objekt af klassen vehicle med constructor 2:
Vehicle Porsche = new Vehicle("AE 12 762", "Shark Blue", 2022, "Germany", "911 GT3 992");
// Printer Parametrerne på bilen:
Console.WriteLine(
    $"\nBilen har:" +
    $"\nReg no. - {Porsche.regno}" +
    $"\nFarve - {Porsche.colour}" +
    $"\nÅrgang - {Porsche.getYear()}" +
    $"\nMake - {Porsche.getMake()}" +
    $"\nModel - {Porsche.getModel()}"
    );