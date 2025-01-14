namespace Module_4;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        Console.WriteLine($"Количество строк: {array.GetUpperBound(0)+1}");
        Console.WriteLine($"Количество колонок: {array.GetUpperBound(1)+1}");
        
        for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
        {
            for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
                Console.Write($"{array[j, i]} ");
            Console.WriteLine();
        }

        foreach (var item in array)
        {
            Console.Write($"{item} ");
        }
    }
}