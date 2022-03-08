using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using opg6._01;

// Opretter et nyt objekt af Car klassen:
Car Porsche = new Car("AB 23 653", "Shark Blue", 2022, "Porsche", "911 GT3 992", 2, 2);
// Udskriver den nye Car object:
Console.WriteLine($"Den nye {Porsche.getMake()} {Porsche.getModel()} har {Porsche.antalDøre} døre og {Porsche.antalSæder} sæder!");

// Opretter et nyt objekt af Truck klassen:
Truck Scania = new Truck("FH 73 624", "White", 2018, "Scania", "S500", 7500, 44000);
// Udskriver den nye Truck object:
Console.WriteLine($"Den bedste lastbil er {Scania.getMake()} {Scania.getModel()}. Dens maxload er {Scania.getMaxLoad()} kg og max vægt er på {Scania.getTotalWeight()} kg!");

// Opretter et nyt objekt af Bus klassen:
Bus Volvo = new Bus("SJ 91 426", "Grøn", 2020, "Volvo", "7900 Electric", 150);
// Udskriver den nye Bus object:
Console.WriteLine($"{Volvo.getMake()}'s nye bus {Volvo.getModel()} er elektrisk og kan have {Volvo.Passengers} passagerer på en gang");