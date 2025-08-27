int[] data = { 5, 3, 8, 4, 2, 4, 6 };

Console.WriteLine("Unsorted data " + string.Join(", ", data));

BubbleSort(data);

Console.WriteLine("Sorted array: " + string.Join(", ", data));

void BubbleSort(int[] input)
{
    for (int i = 0; i < input.Length - 1; i++)
    {
        for (int j = 0; j < input.Length - 1 - i; j++)
        {
            if (input[j] > input[j + 1])
            {
                int temp = input[j];
                input[j] = input[j + 1];
                input[j + 1] = temp;
            }
        }
    }
}