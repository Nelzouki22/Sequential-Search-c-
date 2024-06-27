using System;

class Program
{
    static int SequentialSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
            {
                return i; // Return the index if the target is found
            }
        }
        return -1; // Return -1 if the target is not found
    }

    static void Main()
    {
        int[] arr = { 5, 3, 7, 1, 9, 4 };
        int target = 7;

        int result = SequentialSearch(arr, target);

        if (result != -1)
        {
            Console.WriteLine("Element found at index " + result);
        }
        else
        {
            Console.WriteLine("Element not found in the list");
        }
    }
}
