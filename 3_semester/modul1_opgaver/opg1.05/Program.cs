// Opgave 5 - Gennemlæsning af mappe på disken

// Console.WriteLine(Opgave5.ScanDirCount("C:\\Users\\Anders\\Desktop\\kodeOpgaver\\3_semester"));

class Opgave5
{
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

    public static int ScanDirCount(string path)
    {
        DirectoryInfo dir = new DirectoryInfo(path);
        FileInfo[] files = dir.GetFiles();

        int count = 0;

        DirectoryInfo[] dirs = dir.GetDirectories();

        foreach (DirectoryInfo subdir in dirs)
        {
            count++;
            count += ScanDirCount(subdir.FullName);
        }

        return count;
    }


}