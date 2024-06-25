namespace Swap_Even_Number_Indicies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            PrintArray(ints);
            ReverseEvenNumberElementsInArray(ints);
            PrintArray(ints);

        }

        static void ReverseEvenNumberElementsInArray(int[] arr)
        {
            int n = arr.Length;

            for (int left = 0; left < n / 2; left = left + 2)
            {
                int right = n - 1 - left;
                SwapElementValues(arr, left, right);
            }
        }

        static void SwapElementValues(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        static void PrintArray(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
