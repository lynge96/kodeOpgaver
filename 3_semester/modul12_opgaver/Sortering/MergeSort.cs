namespace Sortering;

public static class MergeSort
{

    public static void Sort(int[] array)
    {
        _mergeSort(array, 0, array.Length - 1);
    }

    private static void _mergeSort(int[] array, int l, int h)
    {
        if (l < h)
        {
            int m = (l + h) / 2;
            _mergeSort(array, l, m);
            _mergeSort(array, m + 1, h);
            Merge(array, l, m, h);
        }
    }

    private static void Merge(int[] array, int low, int middle, int high)
    {
        int lowArrayLength = middle - low + 1;
        int highArrayLength = high - middle;

        int[] lowArray = new int[lowArrayLength];
        int[] highArray = new int[highArrayLength];

        for (int i = 0; i < lowArrayLength; ++i)
        {
            lowArray[i] = array[low + i];
        }

        for (int j = 0; j < highArrayLength; ++j)
        {
            highArray[j] = array[middle + 1 + j];
        }

        int indexLow = 0;
        int indexHigh = 0;
        int indexArray = low;

        while (indexLow < lowArrayLength && indexHigh < highArrayLength)
        {
            if (lowArray[indexLow] <= highArray[indexHigh])
            {
                array[indexArray] = lowArray[indexLow];
                indexLow++;
            }
            else
            {
                array[indexArray] = highArray[indexHigh];
                indexHigh++;
            }

            indexArray++;
        }

        while (indexLow < lowArrayLength)
        {
            array[indexArray] = lowArray[indexLow];
            indexLow++;
            indexArray++;
        }

        while (indexHigh < highArrayLength)
        {
            array[indexArray] = highArray[indexHigh];
            indexHigh++;
            indexArray++;
        }

        return;
    }

}
