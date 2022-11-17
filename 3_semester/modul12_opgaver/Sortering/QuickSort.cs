namespace Sortering;

public static class QuickSort
{

    private static void Swap(int[] array, int k, int j)
    {
        int tmp = array[k];
        array[k] = array[j];
        array[j] = tmp;
    }

    private static void _quickSort(int[] array, int low, int high)
    {
        if (low < high)
        {
            int pivot = Partition(array, low, high);
            _quickSort(array, low, pivot - 1);
            _quickSort(array, pivot + 1, high);
        }
    }

    private static int Partition(int[] array, int low, int high)
    {
        int pivot = array[low];

        int i = low + 1;
        int j = high;

        while (i <= j)
        {
            if (array[i] <= pivot)
            {
                i++;
            }
            else if (array[j] > pivot)
            {
                j--;
            }
            else
            {
                Swap(array, i, j);
                i++;
                j--;
            }
        }
        Swap(array, low, j);

        return j;
    }

    public static void Sort(int[] array)
    {
        _quickSort(array, 0, array.Length - 1);
    }
}