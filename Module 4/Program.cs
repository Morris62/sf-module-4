namespace Module_4;

class Program
{
    static void Main(string[] args)
    {
        int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
        for (int i = 0; i <= arr.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= arr.GetUpperBound(1); j++)
            {
                for (int k = j + 1; k <= arr.GetUpperBound(1); k++)
                {
                    if (arr[i, j] > arr[i, k])
                    {
                        var temp = arr[i, j];
                        arr[i, j] = arr[i, k];
                        arr[i, k] = temp;
                    }
                }
            }
        }

        for (int i = 0; i <= arr.GetUpperBound(0); i++)
        {
            Console.WriteLine();
            for (int j = 0; j <= arr.GetUpperBound(1); j++)
            {
                Console.Write($"{arr[i, j]} ");
            }
        }
    }
}