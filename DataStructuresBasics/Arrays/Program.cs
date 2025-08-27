class ArrayExample
{
    static void Main()
    {
        // Declaration and initialization of an array
        int[] numbers = new int[5] { 10, 20, 30, 40, 50 };

        // Alternative initialization, shorter syntax
        int[] otherNumbers = { 5, 15, 25, 35, 45 };

        Console.WriteLine("Initial array");
        PrintArray(numbers);

        // Mdification of an element in the array
        numbers[2] = 99;
        Console.WriteLine("\nModification of element at index 2");
        PrintArray(numbers);

        // Iteration over the array using a for loop
        Console.WriteLine("\nElements and their index");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"Index {i}: {numbers[i]}");
        }

        // Searching the element, linear search
        int target = 40;
        bool found = false;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == target)
            {
                Console.WriteLine($"\nElement {target} found on the index {i}");
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine($"\nElement {target} not found");
        }

        // Alternative search using Array.IndexOf
        int index = Array.IndexOf(numbers, 20);
        Console.WriteLine(index >= 0? $"\nElement 20 is found on the index {index}": "\nElemnt 20 is not found");

        // Sorting the array
        Array.Sort(numbers);
        Console.WriteLine("\nArray after sorting");
        PrintArray(numbers);

        // Reversing the array
        Array.Reverse(numbers);
        Console.WriteLine("\nArray after reversing");
        PrintArray(numbers);

        // Finding minimum and maximum
        int max = numbers[0];
        int min = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max) max = num;
            if (num < min) min = num;
        }
        Console.WriteLine($"\nMaximal value in the array: {max}");
        Console.WriteLine($"Minimal value in the array: {min}");

        // Two dimension array
        int[,] matrix = new int[,]
        {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };

        Console.WriteLine("\nTwo dimensional array:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Additional method to print an array
    static void PrintArray(int[] arr)
    {
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
