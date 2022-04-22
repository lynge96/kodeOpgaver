using modul17_opg;

Console.WriteLine("Lad os spille gris!\n\nHvad er dit navn?");
string navn = Console.ReadLine();

GrisPlayer spiller = new(navn, 0, false, new PairOfDice(new Dice(), new Dice()));
GrisPlayer computer = new("Computer", 0, false, new PairOfDice(new Dice(), new Dice()));

// Starter spillet:
Gris(spiller, computer);

static void Gris(GrisPlayer spiller, GrisPlayer computer)
{
    while (spiller.Færdig == false)
    {
        if (spiller.PlayerPoint < 100)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\nNuværende stilling" +
                $"\n\t{spiller.PlayerNavn}: {spiller.PlayerPoint}" +
                $"\n\t{computer.PlayerNavn}: {computer.PlayerPoint}\n" +
                $"\nVil du kaste eller stoppe? (k / s)");
            Console.ResetColor();
            string input = Console.ReadLine();

            if (spiller.pointRunde + spiller.PlayerPoint >= 100)
            {
                computer.PointSamlet();
                computer.EndTurn();
            }
            else if (input.ToLower() == "k")
            {
                spiller.KastTerningerne();
            }
            else if (input.ToLower() == "s")
            {
                spiller.PointSamlet();
                spiller.EndTurn();
            }

        }
        else
        {
            break;
        }

    }

    while (computer.Færdig == false)
    {
        if (computer.PlayerPoint < 100)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nComputeren kaster terningerne.");
            Console.ResetColor();
            Thread.Sleep(750);

            computer.KastTerningerne();
            Thread.Sleep(750);

            if (computer.pointRunde + computer.PlayerPoint >= 100)
            {
                computer.PointSamlet();
                computer.EndTurn();
            } else if (computer.pointRunde >= 20)
            {
                Console.WriteLine("Computeren har fået mere end 20 point, så runden afsluttes");
                computer.PointSamlet();
                computer.EndTurn();

            }

        }
        else
        {
            break;
        }

    }

    if (spiller.Færdig == true && computer.Færdig == true)
    {
        SpilVidere(spiller, computer);
    }

}

static void SpilVidere(GrisPlayer spiller, GrisPlayer computer)
{
    if (spiller.PlayerPoint >= 100)
    {
        Console.WriteLine("Tillykke! Du har fået 100 point, så du har vundet spillet!");
    } else if (computer.PlayerPoint >= 100)
    {
        Console.WriteLine("Computeren har fået over 100 point, og har derfor vundet!");
    } else
    {
        spiller.Færdig = false;
        computer.Færdig = false;

        Gris(spiller, computer);
    }

}




