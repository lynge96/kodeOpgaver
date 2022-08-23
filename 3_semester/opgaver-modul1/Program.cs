// Program.cs
Console.WriteLine(Opgave3.Faculty(5)); // Output skal være '120'.
Console.WriteLine(Opgave4.sfd(20, 15));
Console.WriteLine(Opgave4.nPotens(5, 3));

// Opgave 3 - Beregn fakultet med rekursion
class Opgave3 {
    public static int Faculty(int n) {
       // TODO: Skriv koden til fakultet her!
       int resultat;
       if (n <= 1) {
        resultat = 1;
       } else {
        resultat = n * Faculty((n-1)!);
       }
       return resultat;
    }
}
// Opgave 4 - Flere rekursions opgaver
class Opgave4 {
    // Delopgave 1
    public static int sfd(int a, int b) {
        if (a % b == 0) {
            return b;
        } else {
            return (sfd(b, a % b));
        }
    }
    // Delopgave 2
    public static int nPotens(int n, int p) {
        int result;

        if (p == 0) {
            return 1;
        }
        else {
            result = n * nPotens(n, p-1);
        }
        return result;
    }

    // Delopgave 3
}