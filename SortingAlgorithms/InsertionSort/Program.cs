using SortingAlgorithms;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        // Generate random numbers for the unsorted array
        Random random = new Random();
        int[] numbers = new int[10];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(-10, 10);
        }

        Console.WriteLine("Array before sorting:");
        Console.WriteLine(string.Join(" ", numbers) + "\n");

        // Create two independent copies the same array
        int[] arrayShift = new int[numbers.Length];
        int[] arraySwap = new int[numbers.Length];

        Array.Copy(numbers, arrayShift, numbers.Length);
        Array.Copy(numbers, arraySwap, numbers.Length);

        InsertionSort sorter = new InsertionSort();

        // the sorting method with shift
        Stopwatch timeShift = Stopwatch.StartNew();
        Console.WriteLine("Standard approach with shift\n");
        sorter.Sort(arrayShift);
        timeShift.Stop();
        Console.WriteLine("\nArray after insertion sort:" + string.Join(" ", arrayShift));

        Console.WriteLine("\n\nArray before sorting:");
        Console.WriteLine(string.Join(" ", numbers) + "\n");

        // calling the sorting method with swap
        Stopwatch timeSwap = Stopwatch.StartNew();
        Console.WriteLine("Swap approach\n");
        sorter.SortWithSwap(arraySwap);
        timeSwap.Stop();

        Console.WriteLine("\nArray after insertion sort:" + string.Join(" ", arraySwap));

        Console.WriteLine("\nExecution time:");
        Console.WriteLine($"Insert sort with shift:{timeShift.Elapsed.TotalMilliseconds} ms");
        Console.WriteLine($"Insert sort with swap: {timeSwap.Elapsed.TotalMilliseconds} ms");

        Console.ReadLine();
    }
}
