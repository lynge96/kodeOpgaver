// Program.cs
Console.WriteLine(Opgave3.Faculty(5)); // Output skal være '120'.
Console.WriteLine(Opgave4.sfd(20, 15));
Console.WriteLine(Opgave4.nPotens(5, 3));
Console.WriteLine(Opgave4.GangeToTal(5, 4));
Console.WriteLine(Opgave4.Reverse("EGAKNANAB"));
Opgave5.ScanDir("C:\\Users\\lynge\\Desktop\\kodeOpgaver");

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
    public static int GangeToTal(int a, int b) {
        int result;

        if (b == 0) {
            result = 0;
        } else {
            result = a + GangeToTal(a, b - 1);
        }
        return result;
    }

    //Delopgave 4
    public static string Reverse(string ord) {

        if (ord.Length == 0) {
            return ord;
        }
        return Reverse(ord.Substring(1)) + ord[0];
    }
}
// Opgave 5 - Gennemlæsning af mappe på disken
class Opgave5 {
    public static void ScanDir(string path)
    {
        DirectoryInfo dir = new DirectoryInfo(path);
        FileInfo[] files = dir.GetFiles();

        // Udskriver alle filerne
        foreach (FileInfo file in files)
        {
            Console.WriteLine(file.Name);
        }
        DirectoryInfo[] dirs = dir.GetDirectories();

        // Kalder rekursivt på alle undermapper
        foreach (DirectoryInfo subdir in dirs)
        {
            ScanDir(subdir.FullName);
        }
    }
}