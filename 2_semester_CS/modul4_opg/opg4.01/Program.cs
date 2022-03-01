using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Opretter et objekt af klassen Coin
Coin mønt = new Coin();
mønt.Throw();
// Printer coin.throw
Console.WriteLine($"Kaster en mønt\nMønten lander på {mønt.Throw()}!");