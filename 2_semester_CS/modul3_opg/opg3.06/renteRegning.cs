using System;
// Opgave 3.06 - Renteregning

// Renten i banken er pt. for lille, så du investere din lille formue i en amerikansk aktie.
// Hvornår vil din balance være doblet, hvis renten holder sig stabil på 5% om året?

double balance = 10000;
double rente = 1.05;
for (double i = 1; i < 20; i++)
{
    // Lægger renten til den nye balance hvert år.
    balance *= rente;
    Console.WriteLine($"År: {i} - Balance: {Math.Round(balance, 2)}");
    // Hvis balancen er over 20000, stopper loopet, og den printer året + beløbet.
    if (balance >= 20000)
    {
        Console.WriteLine($"Formuen er fordoblet efter {i} år.\nBalancen er på {Math.Round(balance, 2)}");
        break;
    }
}