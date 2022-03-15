using static System.Console;
using System.Diagnostics;

int[] intArray = new int[] { 10, 80, 90, 60, 30, 20, 3, 5, 6, 7 };

QuickSort(0, intArray.Length);

void QuickSort(int left, int right)
{
    if (left < right)
    {
        split(intArray, left, right);
    }
}

void split(int[] arr, int left, int right)
{
    int pivot = arr[left];
    int i = left, indexLow = 0, indexHigh = 0;
    int[] low = new int[arr.Length];
    int[] high = new int[arr.Length];

    while (i < right)
    {
        if (arr[i] <= pivot)
        {
            low[indexLow] = arr[i];
            indexLow++;
        }
        else
        {
            high[indexHigh] = arr[i];
            indexHigh++;
        }
        i++;
    }
    WriteLine("low");
    test(low);

    /* WriteLine("high");
     test(high);*/
}

void test(int[] arr)
{
    /*foreach (var item in arr)
    {
        WriteLine(item);
    }*/

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != 0)
        {
            WriteLine(arr[i]);
        }
    }
}