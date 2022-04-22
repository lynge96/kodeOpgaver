using modul17_opg;

Console.WriteLine("Lad os spille gris!\nHvad er dit navn?");
string navn = Console.ReadLine();

GrisPlayer spiller = new(navn, 0, false, new PairOfDice(new Dice(), new Dice()));
GrisPlayer computer = new("Computer", 0, false, new PairOfDice(new Dice(), new Dice()));

// Starter spillet:
Gris(spiller, computer);

static void Gris(GrisPlayer spiller, GrisPlayer computer)
{
    spiller.KastTerningerne();

    Console.WriteLine("\nVil du kaste igen eller stoppe? (k / s)");
    string input = Console.ReadLine();


}






