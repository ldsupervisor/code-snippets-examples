int[] data = { 5, 4, 67, 4, 5, 6, 6 };

Console.WriteLine("Initial table: " + string.Join(", ", data));

QuickSort.QuickSortFunction(data, 0, data.Length - 1);

Console.WriteLine("After sorting: " + string.Join(", ", data));
class QuickSort
{
    public static void QuickSortFunction(int[] array, int lowIndex, int highIndex)
    {
        if (lowIndex < highIndex)
        {
            int pivotIndex;
            Partition(array, lowIndex, highIndex, out pivotIndex);

            QuickSortFunction(array, lowIndex, pivotIndex - 1);
            QuickSortFunction(array, pivotIndex + 1, highIndex);
        }
    }

    private static void Partition(int[] array, int low, int high, out int pivotIndex)
    {
        // pivot is the last element in the divided array
        int pivot = array[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (array[j] < pivot)
            {
                i++;
                (array[i], array[j]) = (array[j], array[i]); //swap
            }
        }

        (array[i + 1], array[high]) = (array[high], array[i + 1]);
        pivotIndex = i + 1;
    }
}