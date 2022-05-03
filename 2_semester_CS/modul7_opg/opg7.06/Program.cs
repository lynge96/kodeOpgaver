Console.WriteLine("Hvor mange minutter?");
int minutterInput = int.Parse(Console.ReadLine());

Console.WriteLine($"{minutterInput} minutter er {AntalSekunder(minutterInput)} sekunder\n");

// a)
static int AntalSekunder(int antalMinutter)
{
    int antalSekunder = antalMinutter * 60;

    return antalSekunder;
}


Console.WriteLine("Hvor gammel er du?");
int alderInput = int.Parse(Console.ReadLine());

Console.WriteLine($"{alderInput} år er det samme som {AlderTilDage(alderInput)} dage\n");

// b)
static int AlderTilDage(int alder)
{
    int antalDage = alder * 365;

    return antalDage;
}


Console.WriteLine("Er dit tal mindre en 0?");
int talInput = int.Parse(Console.ReadLine());

Console.WriteLine($"Er tallet {talInput} mindre end nul?: {MindreEndNul(talInput)}");

// c)
static bool MindreEndNul(int tal)
{
    if (tal < 0)
    {
        return true;
    }
    else return false;
}