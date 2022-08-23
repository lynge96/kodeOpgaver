// EKSTRA - 8.04 Loops - let

// a)
// Opret en array med 12 tilfældige integers. Skriv en metode der returnerer det største tal i dette array.

Random rng = new();
int[] array12 = new int[12];

for (int i = 0; i < array12.Length; i++)
{
    array12[i] = rng.Next(100);
    Console.Write($"{array12[i]} ");
}

Console.WriteLine($"\nDet største tal i arrayet er {StørsteTal(array12)}\n");

static int StørsteTal(int[] array)
{
    int størsteTal = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > størsteTal)
        {
            størsteTal = array[i];
        }
    }
    return størsteTal;
}

// b)
// Opret en array med 20 tilfældige integers. Skriv en metode der returnerer antal gange der står to 7'ere ved siden af hinanden.

int[] array20 = new int[20];

for (int i = 0; i < array20.Length; i++)
{
    array20[i] = rng.Next(0, 10);
    Console.Write($"{array20[i]} ");
}

Console.WriteLine($"\nDer er {SyverPar(array20)} 7-par\n");

static int SyverPar(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i > 1 && array[i] == 7 && array[i - 1] == 7) { sum++; }
        else if (i == 0 && array[i] == 7 && array[i + 1] == 7) { sum++; }
    }
    return sum;
}

// c)
// Lav en metode der som input tager en integer, og som output returnerer summen af de enkelte tal i input. Så altså input 5434 bliver til 5+4+3+4 = 16.

Console.WriteLine("Skriv et vilkårligt tal:");
int input = int.Parse(Console.ReadLine());

Console.WriteLine($"Tallene i {input} lagt sammen, giver {InputTalSum(input)}");

static int InputTalSum(int tal)
{
    int sum = 0;
    string talInput = tal.ToString();

    for (int i = 0; i < talInput.Length; i++)
    {
        sum += int.Parse(talInput.Substring(i, 1));
    }
    return sum;
}

// d)
// Lav en metode, der tager en string som input. Eksempel input "En to". Metoden skal finde mellemrummet, og så bytte plads på de to ord, sådan at der outputtes "to En".

Console.WriteLine("\nSkriv en sætning:");
string sætningInput = Console.ReadLine();

Console.WriteLine($"\nSætningen: {sætningInput} bliver byttet om til: {BytRundtPåOrd(sætningInput)}");

static string BytRundtPåOrd(string sætningInput)
{
    for (int i = 0; i < sætningInput.Length; i++)
    {
        if (sætningInput.Substring(i, 1) == " ")
        {
            sætningInput = $"{sætningInput.Substring(i + 1, sætningInput.Length - 1 - i)} {sætningInput.Substring(0, i)}";
        }
    }
    return sætningInput;
}