using modul5_opg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Laver et Card objekt:
Card eksempel = new Card("Hjerter", 13);

// Printer kortet:
Console.WriteLine(eksempel.ToString());

// Laver et Stack objekt:
Deck_of_cards stack = new Deck_of_cards();

// Spil krig
int player1 = 0;
int player2 = 0;
int uafgjort = 0;

Deck_of_cards p1deck = new Deck_of_cards();
Deck_of_cards p2deck = new Deck_of_cards();

for (int i = 0; i < 52; i++)
{
    int p1kort = p1deck.getCard().Rank;
    int p2kort = p2deck.getCard().Rank;
    if (p1kort > p2kort)
    {
        player1++;
    }
    else if (p1kort == p2kort)
    {
        uafgjort++;
    }
    else
    {
        player2++;
    }
}
Console.WriteLine($"" +
    $"\nPlayer 1 point:\t{player1}" +
    $"\nPlayer 2 point:\t{player2}" +
    $"\n\nOg {uafgjort} uafgjorte runder!\n");
if (player1 > player2)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("Player 1 vandt, wooo!");
}
else if (player1 < player2)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("Player 2 vandt, syyyyygt!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Uafgjort!");
}
Console.ForegroundColor = default(ConsoleColor);
