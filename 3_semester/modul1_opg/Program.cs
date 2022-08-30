// Program.cs
Console.WriteLine(Opgave3.Faculty(5)); // Output skal være '120'.
Console.WriteLine(Opgave4.sfd(20, 15));
Console.WriteLine(Opgave4.nPotens(5, 3));
Console.WriteLine(Opgave4.GangeToTal(5, 4));
Console.WriteLine(Opgave4.Reverse("EGAKNANAB"));
// Console.WriteLine(Opgave5.ScanDirCount("C:\\Users\\Anders\\Desktop\\kodeOpgaver\\3_semester"));

// Opgave 3 - Beregn fakultet med rekursion
class Opgave3 {
    public static int Faculty(int n) {
       // TODO: Skriv koden til fakultet her!
       if (n == 0) {
            return 1;
       } else {
            return n * Faculty(n-1);
       }
    }
}
// Opgave 4 - Flere rekursions opgaver
class Opgave4 {
    // Delopgave 1
    public static int sfd(int a, int b) {
        if (b <= a && a % b == 0) {
            return b;
        } else {
            if (a < b) {
                return sfd(b, a);
            } else {
                return (sfd(b, a % b));
            }
        }
    }
    // Delopgave 2
    public static int nPotens(int n, int p) {

        if (p == 0) {
            return 1;
        }
        else {
            return n * nPotens(n, p - 1);
        }
    }

    // Delopgave 3
    public static int GangeToTal(int a, int b) {

        if (b == 0) {
            return 0;
        } else {
            return a + GangeToTal(a, b - 1);
        }
    }

    //Delopgave 4
    public static string Reverse(string ord) {

        if (ord.Length == 0) return ord;
        else return Reverse(ord.Substring(1)) + ord[0];
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

    public static int ScanDirCount(string path) {
        DirectoryInfo dir = new DirectoryInfo(path);
        FileInfo[] files = dir.GetFiles();

        int count = 0;

        DirectoryInfo[] dirs = dir.GetDirectories();

        foreach (DirectoryInfo subdir in dirs) {
            count++;
            count += ScanDirCount(subdir.FullName);
        }

        return count;
    }

    
}