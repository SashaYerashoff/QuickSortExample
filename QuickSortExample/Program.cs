using System;

namespace QuickSortExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 1, 5, 0, 34, 3, 9 };

            SortArray(numbers);

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        private static void SortArray(int[] numbers)
        {
            Quicksort(numbers, 0, numbers.Length - 1);
        }

        private static void Quicksort(int[] numbers, int left, int right)
        {
            int i = left;
            int j = right;

            var pivot = numbers[(left + right) / 2];//var pivot = (numbers[left] + numbers[right]) / 2;
            Console.Write("the pivot is: {0} | ", pivot);

            while (i <= j)
            {
                while (numbers[i] < pivot)
                    i++;

                while (numbers[j] > pivot)
                    j--;

                if (i <= j)
                {
                    var tmp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = tmp;

                    i++;
                    j--;
                }
            }

            if (left < j)
                Quicksort (numbers, left, j);
            if (i < right)
                Quicksort(numbers, i, right);
        }
    }
}
