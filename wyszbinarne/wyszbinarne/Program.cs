using System;

class BinarySearch
{
    static void Main()
    {
        Console.WriteLine("Wprowadź posortowaną tablicę liczb całkowitych, oddzielając je przecinkami:");
        string[] input = Console.ReadLine().Split(',');
        int[] array = Array.ConvertAll(input, int.Parse);

        Console.WriteLine("Wprowadź liczbę, którą chcesz znaleźć:");
        int target = int.Parse(Console.ReadLine());

        int result = BinarySearchAlgorithm(array, target);

        if (result != -1)
        {
            Console.WriteLine($"Liczba {target} została znaleziona na pozycji {result + 1} w tablicy.");
        }
        else
        {
            Console.WriteLine($"Liczba {target} nie została znaleziona w tablicy.");
        }
    }

    static int BinarySearchAlgorithm(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (array[mid] == target)
            {
                return mid;
            }
            else if (array[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return -1;
    }
}
