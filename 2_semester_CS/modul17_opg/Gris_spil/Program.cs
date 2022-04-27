using modul17_opg;

Console.WriteLine("Lad os spille gris!\n\nHvad er dit navn?");
Console.Write(">");
string navn = Console.ReadLine();

GrisPlayer spiller = new(navn, 0, false, new PairOfDice(new Dice(), new Dice()));
GrisPlayer computer = new("Computer", 0, false, new PairOfDice(new Dice(), new Dice()));

// Spil Indstillinger
int vinderTal = 100;
int computerHandicap = 20;

// Starter spillet:
Console.BackgroundColor = ConsoleColor.DarkCyan;
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("\nSpillet starter!");
Console.ResetColor();

spiller.KastTerningerne();
Gris(spiller, computer, vinderTal, computerHandicap);

static void Gris(GrisPlayer spiller, GrisPlayer computer, int vinderTal, int computerHandicap)
{
    // Spiller Logic
    if (spiller.PlayerPoint + spiller.pointRunde < vinderTal)
    {
        while (spiller.Færdig == false)
        {

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\nNuværende stilling" +
                $"\n\t>{spiller.PlayerNavn}: {spiller.PlayerPoint}" +
                $"\n\t>{computer.PlayerNavn}: {computer.PlayerPoint}\n" +
                $"\nVil du kaste eller stoppe? (Tryk K/S)");
            Console.ResetColor();

            // Input til Kast eller Stop
            // Tager tastetur tryk som input.
            Console.Write(">");
            ConsoleKeyInfo key = Console.ReadKey();

            if (key.KeyChar == 'k') // Trykker 'k' for at kaste igen.
            {
                spiller.KastTerningerne();
            }
            else if (key.KeyChar == 's') // Trykker 's' for at stoppe runden.
            {
                spiller.PointSamlet();
                spiller.EndTurn();
            }

            // Tester om pointRunde og PlayerPoint giver mere end vindertallet.
            // Spillet stopper hvis man har flere point.
            if (spiller.pointRunde + spiller.PlayerPoint >= vinderTal)
            {
                spiller.PointSamlet();
                spiller.EndTurn();
                TjekScore(spiller, computer, vinderTal);
            }
        }
    }
    else
    {
        TjekScore(spiller, computer, vinderTal);
    }
    // Computer Logic
    while (computer.Færdig == false)
    {
        if (computer.PlayerPoint + computer.pointRunde < vinderTal && spiller.PlayerPoint + spiller.pointRunde < vinderTal)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nComputeren kaster terningerne.");
            Console.ResetColor();
            Thread.Sleep(650);

            computer.KastTerningerne();
            Thread.Sleep(650);

            if (computer.pointRunde + computer.PlayerPoint >= vinderTal)
            {
                computer.PointSamlet();
                computer.EndTurn();
            }
            else if (computer.pointRunde >= computerHandicap)
            {
                Console.WriteLine($"Computeren har fået mere end {computerHandicap} point, så runden afsluttes");
                computer.PointSamlet();
                computer.EndTurn();

            }

        }
        else
        {
            break;
        }

    }
    // Genstarter spillet.
    if (spiller.Færdig == true && computer.Færdig == true)
    {
        SpilVidere(spiller, computer, vinderTal, computerHandicap);
    }
}

static void SpilVidere(GrisPlayer spiller, GrisPlayer computer, int vinderTal, int computerHandicap)
{
    spiller.Færdig = false;
    computer.Færdig = false;

    if (spiller.PlayerPoint >= vinderTal || computer.PlayerPoint >= vinderTal)
    {
        TjekScore(spiller, computer, vinderTal);
    }
    else
    {
        Gris(spiller, computer, vinderTal, computerHandicap);
    }

}

static void TjekScore(GrisPlayer spiller, GrisPlayer computer, int vinderTal)
{
    if (spiller.PlayerPoint >= vinderTal)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"\nTillykke! Du har fået over {vinderTal} point, så du har vundet spillet!");
        Console.ResetColor();
    }
    else if (computer.PlayerPoint >= vinderTal)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"\nComputeren har fået over {vinderTal} point, og har derfor vundet!");
        Console.ResetColor();
    }
}