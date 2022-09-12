// Opgave 4 - Flere rekursions opgaver
Console.WriteLine(Opgave4.sfd(20, 15));
Console.WriteLine(Opgave4.nPotens(5, 3));
Console.WriteLine(Opgave4.GangeToTal(5, 4));
Console.WriteLine(Opgave4.Reverse("EGAKNANAB"));

class Opgave4
{
    // Delopgave 1
    public static int sfd(int a, int b)
    {
        if (b <= a && a % b == 0)
        {
            return b;
        }
        else
        {
            if (a < b)
            {
                return sfd(b, a);
            }
            else
            {
                return (sfd(b, a % b));
            }
        }
    }
    // Delopgave 2
    public static int nPotens(int n, int p)
    {

        if (p == 0)
        {
            return 1;
        }
        else
        {
            return n * nPotens(n, p - 1);
        }
    }

    // Delopgave 3
    public static int GangeToTal(int a, int b)
    {

        if (b == 0)
        {
            return 0;
        }
        else
        {
            return a + GangeToTal(a, b - 1);
        }
    }

    //Delopgave 4
    public static string Reverse(string ord)
    {

        if (ord.Length == 0) return ord;
        else return Reverse(ord.Substring(1)) + ord[0];
    }
}