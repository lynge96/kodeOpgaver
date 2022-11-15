using System.Diagnostics;

namespace Sortering;

public class SortTester
{
    public static void Run()
    {
        int testSize = 100000;
        int Min = 0;
        int Max = 10000;
        Random randNum = new Random();

        int[] bigArray = Enumerable
            .Repeat(0, testSize)
            .Select(i => randNum.Next(Min, Max))
            .ToArray();

        int[] bigArray1 = (int[]) bigArray.Clone();
        int[] bigArray2 = (int[]) bigArray.Clone();
        int[] bigArray3 = (int[]) bigArray.Clone();
        int[] bigArray4 = (int[]) bigArray.Clone();
        int[] bigArray5 = (int[]) bigArray.Clone();

        Stopwatch stopWatch = new Stopwatch();
        
        // Bubble Sort Test
        stopWatch.Start();
        BubbleSort.Sort(bigArray1);
        stopWatch.Stop();
        TimeSpan ts = stopWatch.Elapsed;
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
        Console.WriteLine("BubbleSort " + elapsedTime);

        // Insertion Sort Test
        stopWatch.Reset();
        stopWatch.Start();
        InsertionSort.Sort(bigArray2);
        stopWatch.Stop();
        ts = stopWatch.Elapsed;
        elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
        Console.WriteLine("InsertionSort " + elapsedTime);

        // Selection Sort Test
        stopWatch.Reset();
        stopWatch.Start();
        SelectionSort.Sort(bigArray3);
        stopWatch.Stop();
        ts = stopWatch.Elapsed;
        elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
        Console.WriteLine("SelectionSort " + elapsedTime);

        // Merge Sort Test
        stopWatch.Reset();
        stopWatch.Start();
        MergeSort.Sort(bigArray4);
        stopWatch.Stop();
        ts = stopWatch.Elapsed;
        elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
        Console.WriteLine("MergeSort " + elapsedTime);

        // Quick Sort Test
        stopWatch.Reset();
        stopWatch.Start();
        QuickSort.Sort(bigArray5);
        stopWatch.Stop();
        ts = stopWatch.Elapsed;
        elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
        Console.WriteLine("QuickSort " + elapsedTime);
    }

}
