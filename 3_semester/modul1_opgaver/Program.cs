// Opgave 3 - Beregn fakultet med rekursion
Console.WriteLine(Opgave3.Faculty(5)); // Output skal være '120'.

class Opgave3
{
    public static int Faculty(int n)
    {
        // TODO: Skriv koden til fakultet her!
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * Faculty(n - 1);
        }
    }
}