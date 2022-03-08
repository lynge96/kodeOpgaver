using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using opg6._03;

// Opretter et par terninger:
PairOfDice terninger = new PairOfDice(new Dice(), new Dice());

// Variabel til at tælle seksere
int antalSeksere = 0;

// Looper 1000 kast:
for (int i = 0; i < 1000; i++)
{
    terninger.ThrowDices();
    if (terninger.Terning1.show() == 6 && terninger.Terning2.show() == 6)
    {
        antalSeksere += 2;
    }
    else if (terninger.Terning1.show() == 6 || terninger.Terning2.show() == 6)
    {
        antalSeksere++;
    }
}
Console.WriteLine($"Der er {antalSeksere} seks'ere efter 1000 kast!");