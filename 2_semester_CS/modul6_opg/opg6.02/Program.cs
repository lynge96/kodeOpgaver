using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using opg6._02;
// Spil krig

// Opretter to spillere:
// Player 1:
KrigPlayer Player1 = new KrigPlayer("Abinash", 0, new Deck_of_cards());
// Player 2:
KrigPlayer Player2 = new KrigPlayer("Anders", 0, new Deck_of_cards());

int uafgjort = 0;

for (int i = 0; i < 52; i++)
{
    int p1kort = Player1.PlayerDeck.getCard().Rank;
    int p2kort = Player2.PlayerDeck.getCard().Rank;
    if (p1kort > p2kort)
    {
        Player1.PointSum++;
    }
    else if (p1kort == p2kort)
    {
        uafgjort++;
    }
    else
    {
        Player2.PointSum++;
    }
}
Console.WriteLine($"Så er der krig!" +
    $"\nPlayer 1 - {Player1.SpillerNavn} point: {Player1.PointSum}" +
    $"\nPlayer 2 - {Player2.SpillerNavn} point: {Player2.PointSum}" +
    $"\n\nOg {uafgjort} uafgjorte runder!\n");
if (Player1.PointSum > Player2.PointSum)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine($"{Player1.SpillerNavn} vandt, wooo!");
}
else if (Player1.PointSum < Player2.PointSum)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine($"{Player2.SpillerNavn} vandt, syyyyygt!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Uafgjort!");
}
Console.ForegroundColor = default(ConsoleColor);
