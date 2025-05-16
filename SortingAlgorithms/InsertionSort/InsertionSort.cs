namespace SortingAlgorithms
{
    public class InsertionSort
    {
        public void Sort(int[] array)
        {
            for (int j = 1; j < array.Length; j++)
            {
                int key = array[j];
                int i = j - 1;

                while (i >= 0 && array[i] > key)
                {
                    array[i + 1] = array[i];
                    i--;
                }

                array[i + 1] = key;

                string left = string.Join(" ", array.Take(j));
                string right = string.Join(" ", array.Skip(j));
                Console.WriteLine($"Step {j}: {left} # {right}");
            }
        }

        public void SortWithSwap(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i;
                while (j > 0 && array[j - 1] > array[j])
                {
                    Swap(array, j, j - 1);
                    j--;
                }

                string left = string.Join(" ", array.Take(i));
                string right = string.Join(" ", array.Skip(i));
                Console.WriteLine($"Step {i}: {left} # {right}");
            }
        }

        private void Swap(int[] array, int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
    }

 /*
1. In the first step the sorted array consists on one element [0] from array[0] and the key is the second element [1].
1. In the classical approach sorted array is on the left side of the key.
2. The sorted array changed its length and in each step has the range [0..j-1] depending on the index of actual element [j].
3. From usorted array key is the first element of the unsorted array in the conqrete interation j, key=array[j]. 
*/

}
