using System;

// Opgave 3.04 - Lidt array gymnastik

// a) Lav et program der fylder et array med 50 tilfældige tal mellem 1 og 50 og udskriv indholdet:
int[] array50 = new int[50];
// Laver en variabel til random tal:
Random rand = new Random();
// Fylder arrayet op med random tal.
for (int i = 0; i < array50.Length; i++)
{
    array50[i] = rand.Next(1, 51);
}
// Printer arrayet.
Console.WriteLine("Printer arrayet:");
foreach (int i in array50)
{
    Console.Write(i + ", ");
}

// b) Udskriv arrayets indhold i omvendt rækkefølge i konsollen:
// Vender arrayet om.
Array.Reverse(array50);
Console.WriteLine("\n");
// Udskriver det omvendte array.
Console.WriteLine("Printer det omvendte array");
foreach (int j in array50)
{
    Console.Write(j + ", ");
}

// c) Udskriv et givent interval af arrayets elementer fx fra element nr. 14 til nr. 23.
Console.WriteLine("\n");
// Laver et for-loop.
Console.WriteLine("Printer arrayet fra index 14 til 23:");
for (int k = 14; k <= 23; k++)
{
    Console.Write(array50[k] + ", ");
}

// d) Udskirv et givent interval af arrayets værdier fx all tal fra >10 og <20
Console.WriteLine("\n");
// Lavet et loop der printer de sidste 10 værdier.
Console.WriteLine("Printer de sidste 10 værdier i arrayet");
for (int i = 40; i < array50.Length; i++)
{
    Console.Write(array50[i] + ", ");
}

// e) Lav en metode der finder antallet af forekomster af en given værdi i arrayet.
// Metoden skal som parametre modtage et array og den værdi der skal søges efter, og skal returnere
// antal forekomster af den søgte værdi.
Console.WriteLine("\n");
// Metodekald
int forekomster = findAntal(array50, 25);
Console.WriteLine($"Det valgte tal forekommer {forekomster} gange!");

// Metodens signatur
static int findAntal(int[] tabel, int tal)
{
    int sum = 0;
    for (int i = 0; i < tabel.Length; i++)
    {
        if (tabel[i] == tal)
        {
            sum++;
        }
    }
    return sum;
}

// f) Lav en metode der finder første forekomst af en given værdi i arrayet.
// Metoden skal som parametre modtage et array og den værdi der skal søges efter, og skal returenere
// positionen af den søgte værdi i arrayet.

// Metodekald
int førsteForekomst = findFørste(array50, 25);
Console.WriteLine($"Det valgte tal forekommer først ved index {førsteForekomst}!");

// Metodens signatur
static int findFørste(int[] array, int tal)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == tal)
        {
            return i;
        }
    }
    return -1;
}